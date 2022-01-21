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
    /// Interaction logic for UpdateErrandView.xaml
    /// </summary>
    public partial class UpdateErrandView : UserControl
    {
        ErrandsList _errands = new();        
        SqlService sql = new();

        public void GetErrandsList()
        {
            GetErrandsFromSql _errandsFromSql = new();
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
        public UpdateErrandView()
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
            ErrandId.Text = $"{_errand.Id}";            

            tbFirstName.Text = _customer.FirstName;
            tbLastName.Text = _customer.LastName;

            tbTitle.Text = _errand.Title;
            tbErrandDescription.Text = _errand.ErrandDescription;
            tbAdminstrator.Text = _errand.Adminstrator;

            switch (_errand.ErrandStatus)
            {
                case "Inte Påbörjat":
                    cbStarted.IsChecked = false;
                    cbFinished.IsChecked = false;
                    cbNotStarted.IsChecked = true;
                    break;
                case "Påbörjat":
                    cbNotStarted.IsChecked = false;
                    cbFinished.IsChecked = false;
                    cbStarted.IsChecked = true;
                    break;
                case "Avslutat":
                    cbNotStarted.IsChecked = false;
                    cbStarted.IsChecked = false;
                    cbFinished.IsChecked = true;
                    break;
                default:
                    break;
            }
        }


        private void btnUppdate_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTitle.Text) && !string.IsNullOrEmpty(tbErrandDescription.Text) && !string.IsNullOrEmpty(tbAdminstrator.Text) && !string.IsNullOrEmpty(Status.Text))
            {
                DateTime now = DateTime.Now;
                Errand _errand = new Errand
                {
                    Title = tbTitle.Text,
                    ErrandDescription = tbErrandDescription.Text,
                    Adminstrator = tbAdminstrator.Text,
                    ErrandStatus = Status.Text,
                    ChangedTime = now,
                };

                sql.UpdateErrand(Int32.Parse(ErrandId.Text), _errand);               

                tbTitle.Text = "";
                tbErrandDescription.Text = "";
                tbAdminstrator.Text = "";
                cbNotStarted.IsChecked = false;
                cbStarted.IsChecked = false;
                cbFinished.IsChecked = false;
                Status.Text = "";                
                GetErrandsList();                
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
            cbNotStarted.IsChecked = false;
            cbFinished.IsChecked = false;
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
