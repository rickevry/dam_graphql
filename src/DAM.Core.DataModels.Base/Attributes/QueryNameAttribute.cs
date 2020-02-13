using System;

namespace DAM.Core.DataModels.Base
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class QueryNameAttribute : Attribute
    {
        public QueryNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public static implicit operator string(QueryNameAttribute a) => a.Name;

        public override string ToString()
        {
            return Name;
        }
    }
}
