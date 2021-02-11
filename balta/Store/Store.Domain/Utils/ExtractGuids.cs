using System;
using System.Collections.Generic;
using Store.Domain.Commands;

namespace Store.Domain.Utils
{
    public struct ExtractGuids
    {
        public static IEnumerable<Guid> Extract(IList<CreateOrderItemCommand> items)
        {
            var guids = new List<Guid>();
            foreach (var item in items)
            {
                guids.Add(item.Product);
            }

            return guids;
        }        
    } 
}