using System;
namespace CleanArchitectureECommerce.Core.Entities
{
    public class ShippingMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public int EstimatedDeliveryTimeDays { get; set; }
        public bool IsActive { get; set; }
        public string SupportedRegions { get; set; } // Could be JSON or delimited string
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

