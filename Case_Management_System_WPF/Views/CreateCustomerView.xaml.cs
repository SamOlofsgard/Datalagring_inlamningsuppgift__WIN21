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
    /// Interaction logic for CreateCustomerView.xaml
    /// </summary>
    public partial class CreateCustomerView : UserControl
    {
        public void NewCustomer(string firstName, string lastName, string email, string phoneNumber, string mobileNumber, string streetName, string postalCode, string city, string country)
        {
            CreateCustomer customer = new() 
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                MobileNumber = mobileNumber,
                Address = new Address
                {
                    StreetName = streetName,
                    PostalCode = postalCode,
                    City = city,
                    Country = country
                }
            };

            SqlService sql = new();
            sql.CreateCustomer(customer);
        }

        public CreateCustomerView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((tbPostalCode.Text.Length == 5) && !string.IsNullOrEmpty(tbFirstName.Text) && !string.IsNullOrEmpty(tbLastName.Text) && !string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbStreetName.Text) && !string.IsNullOrEmpty(tbPostalCode.Text) && !string.IsNullOrEmpty(tbCity.Text) && !string.IsNullOrEmpty(tbCountry.Text) && !string.IsNullOrEmpty(tbPhone.Text) && !string.IsNullOrEmpty(tbMobile.Text))
            {
                NewCustomer(tbFirstName.Text, tbLastName.Text, tbEmail.Text, tbPhone.Text, tbMobile.Text, tbStreetName.Text, tbPostalCode.Text, tbCity.Text, tbCountry.Text);
                tbFirstName.Text = "";
                tbLastName.Text = "";
                tbEmail.Text = "";
                tbPhone.Text = "";
                tbMobile.Text = "";
                tbStreetName.Text = "";
                tbPostalCode.Text = "";
                tbCity.Text = "";
                tbCountry.Text = "";
            }
        }
    }
}
