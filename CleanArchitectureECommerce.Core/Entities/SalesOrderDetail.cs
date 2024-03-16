using System;
namespace CleanArchitectureECommerce.Core.Entities
{
    public class SalesOrderDetail
    {
        public int Id { get; set; }
        public int SalesOrderId { get; set; }
        public SalesOrder SalesOrder { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerItem { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DiscountApplied { get; set; }
        public string ProductName { get; set; } // Snapshot of product name at the time of order
        public string ProductSKU { get; set; } // Snapshot of SKU
        public string ProductImageUrl { get; set; } // Snapshot for historical accuracy
        public string Status { get; set; } // For tracking individual item status within an order
    }
}




