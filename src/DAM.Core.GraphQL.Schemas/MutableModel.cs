using DAM.Core.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DAM.Core.GraphQL.Schemas
{
    public class MutableModel : IEntityId<Guid>
    {
        private HashSet<string> _mutatedProperties = new HashSet<string>();


        public Guid Id { get; set; }


        public bool IsPropertyMutated(string propertyName) => _mutatedProperties.Contains(propertyName);

        public void SetMutableFields<TEntity>(TEntity mutated) where TEntity : MutableModel
        {
            var mutatedProperties = mutated.GetType().GetProperties().Where(p => mutated.IsPropertyMutated(p.Name));
            foreach (var property in mutatedProperties)
            {
                var mutatedValue = property.GetValue(mutated);

                switch (mutatedValue)
                {
                    case MutableModel mutableChild:
                        SetMutableChildFields(property, mutableChild);
                        break;

                    default:
                        property.SetValue(this, mutatedValue);
                        break;
                }
            }
        }

        private void SetMutableChildFields(PropertyInfo property, MutableModel mutableChild)
        {
            var originalValue = property.GetValue(this) as MutableModel;
            if (originalValue == null)
            {
                property.SetValue(this, mutableChild);
            }
            else
            {
                originalValue.SetMutableFields(mutableChild);
            }
        }

        protected void SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            field = value;

            SetFieldMutated(propertyName);
        }

        private void SetFieldMutated(string propertyName)
        {
            if (!_mutatedProperties.Contains(propertyName))
            {
                _mutatedProperties.Add(propertyName);
            }
        }
    }
}
