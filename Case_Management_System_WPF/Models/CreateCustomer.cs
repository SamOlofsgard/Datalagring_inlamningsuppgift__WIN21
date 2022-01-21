using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_System_WPF.Models
{
    internal class CreateCustomer
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } =null!;
        public string MobileNumber { get; set; } = null!;

        public virtual Address Address { get; set; } = null!;
    }
}
