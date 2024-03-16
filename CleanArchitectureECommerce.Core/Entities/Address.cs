using System;
using System.Net;

namespace CleanArchitectureECommerce.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string UserName { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool IsPhoneVerified { get; set; }
        public string Nationality { get; set; }
        public string Language { get; set; }
        public string TimeZone { get; set; }
        public string CurrencyPreference { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string LastLoginIp { get; set; }
        public bool NewsletterSubscribed { get; set; }
        public string Notes { get; set; } // For internal use
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}

