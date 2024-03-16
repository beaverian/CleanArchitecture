using System;
namespace CleanArchitectureECommerce.Core.Entities
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Method { get; set; } // E.g., Credit Card, PayPal
        public string Provider { get; set; } // E.g., Visa, MasterCard, PayPal
        public string AccountNumber { get; set; } // Last 4 digits for cards
        public DateTime ExpiryDate { get; set; }
        public string HolderName { get; set; }
        public bool IsDefault { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

