using System;
namespace CleanArchitectureECommerce.Core.Entities
{
    public class ShippingCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public string CustomerServiceNumber { get; set; }
        public string TrackingUrlTemplate { get; set; } // For generating tracking URLs
        public bool SupportsInternational { get; set; }
        public string SupportedCountries { get; set; } // Could be JSON or delimited string
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

