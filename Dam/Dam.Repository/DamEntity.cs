using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Dam.Repository
{
    public abstract class DamEntity
    {
        private HashSet<string> _mutatedProperties = new HashSet<string>();

        public bool IsPropertyMutated(string propertyName) => _mutatedProperties.Contains(propertyName);

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
