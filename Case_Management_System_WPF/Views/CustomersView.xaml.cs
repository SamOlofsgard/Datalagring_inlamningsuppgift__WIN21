using Case_Management_System_WPF.Handlers;
using Case_Management_System_WPF.Models;
using Case_Management_System_WPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Case_Management_System_WPF.Views
{
    /// <summary>
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView : UserControl
    {
        CustomersList _customers = new CustomersList();
        GetCustomersFromSql _customersFromSql = new GetCustomersFromSql();
        public void GetCustomersList()
        {
            Customers.Items.Clear();
            _customersFromSql.Database(_customers);
            int antal = 0;

            foreach (var item in _customers.CustomerList)
            {
                Customers.Items.Add(item);
                antal++;
            }
            AntalKunder.Text = $"{antal}";
        }
        public CustomersView()
        {
            InitializeComponent();
            GetCustomersList();
        }

        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var obj = (TextBlock)sender;
            var item = (Customer)obj.DataContext;
            SqlService sql = new SqlService();
            var address = sql.GetAddress(item.AddressId);
            tbStreetName.Text = $"{address.StreetName}";
            tbPostalCode.Text = $"{address.PostalCode}";
            tbCity.Text = $"{address.City}";
            tbCountry.Text = $"{address.Country}";

            tbFirstName.Text = item.FirstName;
            tbLastName.Text = item.LastName;
            tbEmail.Text = item.Email;
            tbPhone.Text = item.PhoneNumber;
            tbMobile.Text = item.MobileNumber;

        }
    }
}
