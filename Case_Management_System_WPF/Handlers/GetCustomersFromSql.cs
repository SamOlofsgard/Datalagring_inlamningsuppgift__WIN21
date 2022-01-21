using Case_Management_System_WPF.Models;
using Case_Management_System_WPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Case_Management_System_WPF.Handlers
{
    internal class GetCustomersFromSql
    {

        SqlService sql = new();

        public void Database(CustomersList customersList)
        {
            customersList.ClearCustomersList();

            
           var _customerList = sql.GetCustomers();

            foreach (var customer in _customerList) 
                customersList.AddToCustomersList(customer);
                
                
                
        }
    }
}
