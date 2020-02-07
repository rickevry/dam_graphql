using System;

namespace Dam.Repository.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class EntityNameAttribute : Attribute
    {
        public EntityNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public static implicit operator string(EntityNameAttribute a) => a.Name;

        public override string ToString()
        {
            return Name;
        }
    }
}
