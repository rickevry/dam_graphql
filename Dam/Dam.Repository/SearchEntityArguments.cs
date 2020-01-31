using System;

namespace Dam.Repository
{
    public class SearchEntityArguments
    {
        public Guid? Id { get; set; }

        public bool HasSearchByIdParam
            => Id.HasValue && Id.Value != Guid.Empty;

        public bool HasAnyParam
            => HasSearchByIdParam;
    }
}
