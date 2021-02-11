using NewStore.Shared.Entities;

namespace NewStore.Domain.StoreContext.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, decimal quantity)
        {
            Product     = product;
            AddQuantity(quantity);
            Price       = product.Price;
        }

        public Product Product { get; private set; }
        public decimal Quantity { get; private set; }
        public decimal Price { get; private set; }

        public void AddQuantity(decimal quantity)
        {
           Quantity = quantity;
        }
    }
}