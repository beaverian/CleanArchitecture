using System;
namespace CleanArchitectureECommerce.Core.Entities
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ShoppingCartDetail> Items { get; set; }
        public decimal ItemsTotalPrice { get; set; }
        public decimal EstimatedShippingCost { get; set; }
        public decimal EstimatedTax { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}

