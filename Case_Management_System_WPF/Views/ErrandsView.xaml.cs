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
    /// Interaction logic for ErrandView.xaml
    /// </summary>
    public partial class ErrandsView : UserControl
    {
        ErrandsList _errands = new();
        GetErrandsFromSql _errandsFromSql = new();

        public void GetErrandsList()
        {
            Errands.Items.Clear();
            _errandsFromSql.Database(_errands);
            int antal = 0;
            foreach (var item in _errands.ErrandList)
            {
                Errands.Items.Add(item);
                antal++;
            }
            AntalÄrenden.Text = $"{antal}";
        }

        public ErrandsView()
        {
            InitializeComponent();
            GetErrandsList();
        }

        private void tbErrandTitle_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var obj = (TextBlock)sender;
            var _errand = (Errand)obj.DataContext;
            SqlService sql = new SqlService();
            var _customer = sql.GetCustomer(_errand.CustomerId);
            tbFirstName.Text = _customer.FirstName;
            tbLastName.Text = _customer.LastName;
            tbEmail.Text = $"Email: {_customer.Email}";
            tbPhone.Text = $"Telefonnummer: {_customer.PhoneNumber}";
            tbMobile.Text = $"Mobilnummer: {_customer.MobileNumber}";

            if (_errand.ErrandDescription.Length > 58)
            {
                string _errand58 = _errand.ErrandDescription.Substring(0, 58);
                int _errandSplit1 = _errand58.LastIndexOf(" ");
                string _errand0_58 = _errand.ErrandDescription.Substring(0, _errandSplit1);
                string _errand3 = _errand.ErrandDescription.Substring(_errandSplit1 + 1);

                string _errand2 = _errand0_58.Substring(0, 29);
                int _errandSplit = _errand2.LastIndexOf(" ");
                string _errand1 = _errand0_58.Substring(0, _errandSplit);
                _errand2 = _errand0_58.Substring(_errandSplit + 1);
                tbErrandDescription.Text = $"{_errand1}\n{_errand2}\n{_errand3}";
            }
            else if (_errand.ErrandDescription.Length > 29)
            {
                string _errand29 = _errand.ErrandDescription.Substring(0, 29);
                int _errandSplit = _errand29.LastIndexOf(" ");
                string _errand1 = _errand.ErrandDescription.Substring(0, _errandSplit);
                string _errand2 = _errand.ErrandDescription.Substring(_errandSplit + 1);
                tbErrandDescription.Text = $"{_errand1}\n{_errand2}";
            }
            else
            {
                tbErrandDescription.Text = _errand.ErrandDescription;
            }
            tbCreated.Text = $"{_errand.CreatedTime}";
            tbChanged.Text = $"{_errand.ChangedTime}";
            tbStatus.Text = _errand.ErrandStatus;
            tbAdminstrator.Text = _errand.Adminstrator; 
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            var obj = (Button)sender;
            var _errand = (Errand)obj.DataContext;
            
            SqlService sql = new ();
            sql.DeleteErrand(_errand.Id);
            GetErrandsList();
        }
    }
}
