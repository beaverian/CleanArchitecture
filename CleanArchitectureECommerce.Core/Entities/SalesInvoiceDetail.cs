using System;
namespace CleanArchitectureECommerce.Core.Entities
{
    public class SalesInvoiceDetail
    {
        public int Id { get; set; }
        public int SalesInvoiceId { get; set; }
        public SalesInvoice SalesInvoice { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; } // Additional description for the invoiced item
        public decimal TaxAmount { get; set; }
        public decimal Discount { get; set; }
    }
}


