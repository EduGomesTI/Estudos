using System;

namespace NewStore.Domain.StoreContext.Queries
{
    public class CustomerOrdersCountResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public int Orders { get; set; }
    }
}