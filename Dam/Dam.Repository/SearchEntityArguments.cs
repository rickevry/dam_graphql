using System;

namespace Dam.Repository
{
    public class SearchEntityArguments
    {
        public object Id { get; set; }

        public bool HasSearchByIdParam
        {
            get
            {
                switch (Id)
                {
                    case Guid guidValue: return guidValue != Guid.Empty;
                    case string stringValue: return !string.IsNullOrWhiteSpace(stringValue);
                    case int intValue: return intValue > 0;
                    case long longValue: return longValue > 0;

                    default: return Id != null;
                }
            }
        }

        public bool HasAnyParam
            => HasSearchByIdParam;
    }
}
