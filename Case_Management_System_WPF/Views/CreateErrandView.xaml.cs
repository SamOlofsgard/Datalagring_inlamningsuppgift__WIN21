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
    /// Interaction logic for CreateErrandView.xaml
    /// </summary>
    public partial class CreateErrandView : UserControl
    {
        CustomersList _customers = new CustomersList();
        GetCustomersFromSql _customersFromSql = new GetCustomersFromSql();


        public void CreateErrand(
            int customerId, 
            string title,            
            string errandDescription, 
            DateTime createdTime, 
            DateTime changedTime,
            string errandStatus,
            string adminstrator
            )
        {

            Errand errand = new()
            {
                CustomerId = customerId,
                Title = title,                
                ErrandDescription = errandDescription,
                CreatedTime = createdTime,
                ChangedTime = changedTime,
                ErrandStatus = errandStatus,
                Adminstrator = adminstrator
            };

            SqlService sql = new SqlService();
            sql.CreateErrand(errand);
        }


        public void GetCustomersList()        {

            Customers.Items.Clear();
            _customersFromSql.Database(_customers);

            foreach (var item in _customers.CustomerList)
                Customers.Items.Add(item);

        }
        public CreateErrandView()
        {
            InitializeComponent();
            GetCustomersList();
        }

        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {            
            var obj = (TextBlock)sender;
            var item = (Customer)obj.DataContext;            

            Kund.Text = $"Skapa ärende till kunden: {item.FirstName} {item.LastName}";
            CustomerId.Text = $"{item.Id}";  
        }
        

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTitle.Text) && !string.IsNullOrEmpty(tbErrandDescription.Text) && !string.IsNullOrEmpty(tbAdminstrator.Text) && !string.IsNullOrEmpty(Status.Text) && !string.IsNullOrEmpty(CustomerId.Text)) 
            {
                DateTime now = DateTime.Now;
                CreateErrand(
                    Int32.Parse(CustomerId.Text), 
                    tbTitle.Text,                    
                    tbErrandDescription.Text,
                    now,
                    now,
                    Status.Text,
                    tbAdminstrator.Text   
                    );

                tbTitle.Text = "";
                tbErrandDescription.Text = "";
                tbAdminstrator.Text = "";
                cbNotStarted.IsChecked = false;
                cbStarted.IsChecked = false;
                cbFinished.IsChecked = false;
                Status.Text = "";
            }
        }
        private void NotStartedCheck(object sender, RoutedEventArgs e)
        {            
            cbStarted.IsChecked = false;
            cbFinished.IsChecked = false;
            Status.Text = "Inte Påbörjat";
        }

        private void StartedCheck(object sender, RoutedEventArgs e)
        {            
            cbNotStarted.IsChecked=false;
            cbFinished.IsChecked=false;
            Status.Text = "Påbörjat";
        }

        private void FinishedCheck(object sender, RoutedEventArgs e)
        {            
            cbNotStarted.IsChecked = false;
            cbStarted.IsChecked = false;
            Status.Text = "Avslutat";
        }

        private void Unchecked(object sender, RoutedEventArgs e)
        {
            Status.Text = "";
        }
    }
}
