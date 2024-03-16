using System;
namespace CleanArchitectureECommerce.Core.Entities
{
    public class SalesOrder
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public string OrderStatus { get; set; } // New, Confirmed, Shipped, Delivered, Cancelled
        public string ShippingAddress { get; set; }
        public int ShippingMethodId { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public decimal ItemsTotal { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DiscountApplied { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; } // Pending, Completed, Refunded
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string CustomerNotes { get; set; }
        public string InternalNotes { get; set; }
        public ICollection<SalesOrderDetail> OrderDetails { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}


