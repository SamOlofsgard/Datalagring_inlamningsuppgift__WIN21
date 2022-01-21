using Case_Management_System_WPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_System_WPF.Models.ViewModels
{
    internal class MainWindowViewModel:ObservableObject
    {

        public RelayCommand CreateCustomerViewCommand { get; set; } = null!;
        public RelayCommand CreateErrandViewCommand { get; set; } = null!;
        public RelayCommand CustomersViewCommand { get; set; } = null!;
        public RelayCommand DefaultWindowViewCommand { get; set; } = null!;
        public RelayCommand ErrandsViewCommand { get; set; } = null!;        
        public RelayCommand UpdateErrandViewCommand { get; set; } = null!;

        
        public CreateCustomerViewModel CreateCustomerViewModel { get; set; }
        public CreateErrandViewModel CreateErrandViewModel { get; set; }
        public CustomersViewModel CustomersViewModel { get; set; }
        public DefaultWindowViewModel DefaultWindowViewModel { get; set; }
        public ErrandsViewModel ErrandsViewModel { get; set; }        
        public UpdateErrandViewModel UpdateErrandViewModel { get; set; }


        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            CreateCustomerViewModel = new CreateCustomerViewModel();
            CreateErrandViewModel = new CreateErrandViewModel();
            CustomersViewModel = new CustomersViewModel();
            DefaultWindowViewModel = new DefaultWindowViewModel();
            ErrandsViewModel = new ErrandsViewModel();
            UpdateErrandViewModel = new UpdateErrandViewModel();

            CurrentView = DefaultWindowViewModel;
            
            CreateCustomerViewCommand = new RelayCommand(x => CurrentView = CreateCustomerViewModel);
            CreateErrandViewCommand = new RelayCommand(x => CurrentView = CreateErrandViewModel);
            CustomersViewCommand = new RelayCommand(x => CurrentView = CustomersViewModel);
            DefaultWindowViewCommand = new RelayCommand(x => CurrentView = DefaultWindowViewModel);
            ErrandsViewCommand = new RelayCommand(x => CurrentView = ErrandsViewModel);
            UpdateErrandViewCommand = new RelayCommand(x => CurrentView = UpdateErrandViewModel);
        }
    }
}
