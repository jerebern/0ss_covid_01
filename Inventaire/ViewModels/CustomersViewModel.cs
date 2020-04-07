using app_models;
using BillingManagement.UI.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;

namespace BillingManagement.UI.ViewModels
{
   public class CustomersViewModel : BaseViewModel
    {
        CustomersDataService customersDataService = new CustomersDataService();

        private ObservableCollection<Customer> customers;
        private Customer selectedCustomer;

        public AddCustomerCommand addClientCommand { get; set; }

        public ObservableCollection<Customer> Customers
        {
            get => customers;
            private set
            {
                customers = value;
                OnPropertyChanged();
            }
        }

        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                OnPropertyChanged();
            }
        }


        public CustomersViewModel()
        {
            InitValues();
            addClientCommand = new AddCustomerCommand(Add_Customer);
            
        }

        private void InitValues()
        {
            Customers = new ObservableCollection<Customer>(customersDataService.GetAll());
            Debug.WriteLine(Customers.Count);
        }

        private void Add_Customer()
        {
            Console.WriteLine("TEST");

            ///ICI VA LE CODE A RAJOUTER POUR FAIRE FONCTIONNER L'AJOUT mon command binding n'a jamais fonctioner :(
            


        }

    }
}
