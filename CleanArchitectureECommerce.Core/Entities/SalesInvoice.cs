using System;
namespace CleanArchitectureECommerce.Core.Entities
{
    public class SalesInvoice
    {
        public int Id { get; set; }
        public int SalesOrderId { get; set; }
        public SalesOrder SalesOrder { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal ShippingCost { get; set; }
        public decimal SubTotal { get; set; } // Total before taxes and shipping
        public string PaymentStatus { get; set; } // Paid, Pending, Overdue
        public DateTime? PaymentDueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public ICollection<SalesInvoiceDetail> InvoiceDetails { get; set; }
        public string Notes { get; set; } // Additional notes, if any
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

