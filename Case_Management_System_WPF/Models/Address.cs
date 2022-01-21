using System;
using System.Collections.Generic;

namespace Case_Management_System_WPF.Models
{
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
