using System;
using System.Collections.Generic;

namespace Case_Management_System_WPF.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Errands = new HashSet<Errand>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public int AddressId { get; set; }        

        public virtual Address Address { get; set; }
        public virtual ICollection<Errand> Errands { get; set; }
    }
}
