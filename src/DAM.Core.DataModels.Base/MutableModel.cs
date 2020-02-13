using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DAM.Core.DataModels.Base
{
    public class MutableModel
    {
        protected object _id;

        private HashSet<string> _mutatedProperties = new HashSet<string>();

        public bool IsPropertyMutated(string propertyName) => _mutatedProperties.Contains(propertyName);

        public object GetEntityId()
        {
            if (_id == null)
            {
                _id = ExtractEntityId();
            }

            return _id;
        }

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

        private object ExtractEntityId()
        {
            var properties = GetType().GetProperties();
            if (properties != null && properties.Any())
            {
                var idProposalsByPriority = new Dictionary<int, object>();
                var entityName = GetType().GetCustomAttributes(typeof(ModelNameAttribute), false).Select(qn => qn as ModelNameAttribute).FirstOrDefault();

                foreach (var property in properties)
                {
                    var keyAttribute = property.GetCustomAttributes(typeof(KeyAttribute), true).Select(a => a as KeyAttribute).FirstOrDefault();
                    if (keyAttribute != null)
                    {
                        return property.GetValue(this);
                    }

                    if (property.Name.ToLower() == "id")
                    {
                        idProposalsByPriority.Add(0, property.GetValue(this));
                    }
                    else if (property.Name == $"{entityName}Id")
                    {
                        idProposalsByPriority.Add(1, property.GetValue(this));
                    }
                    else if (property.Name == $"{GetType().Name}Id")
                    {
                        idProposalsByPriority.Add(2, property.GetValue(this));
                    }
                }

                if (idProposalsByPriority.Any())
                {
                    var bestProposalKey = idProposalsByPriority.Keys.Min();
                    return idProposalsByPriority[bestProposalKey];
                }
            }

            return null;
        }
    }
}
