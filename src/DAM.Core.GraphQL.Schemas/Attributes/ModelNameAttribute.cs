using System;

namespace DAM.Core.GraphQL.Schemas
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ModelNameAttribute : Attribute
    {
        public ModelNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public static implicit operator string(ModelNameAttribute a) => a.Name;

        public override string ToString()
        {
            return Name;
        }
    }
}
