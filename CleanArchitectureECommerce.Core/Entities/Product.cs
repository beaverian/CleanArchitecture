using System;
namespace CleanArchitectureECommerce.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; }
        public string Category { get; set; }
        public string SKU { get; set; } // Stock Keeping Unit
        public string Manufacturer { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}

