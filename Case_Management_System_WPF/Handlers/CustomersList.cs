using Case_Management_System_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_System_WPF.Handlers
{
    public class CustomersList
    {
        public List<Customer> CustomerList { get; set; } = new List<Customer>();

        public Customer Create(int id, string firstName, string lastName, string email, int addressId)
        {
            return new Customer { Id = id, FirstName = firstName, LastName = lastName, Email = email, AddressId = addressId };
        }

        public void AddToCustomersList(Customer item)
        {
            CustomerList.Add(item);
        }

        public void ClearCustomersList()
        {
            CustomerList.Clear();
        }

        public void RemoveCustomerFromList(Customer item)
        {
            CustomerList.Remove(item);
        }

    }
}
