using System;
using System.Net;

namespace CleanArchitectureECommerce.Core.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public bool IsDefault { get; set; }
        public string AddressType { get; set; } // E.g., Billing, Shipping
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Notes { get; set; }
    }
}


