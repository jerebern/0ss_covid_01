using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BillingManagement.UI.Commands
{
    public class AddCustomerCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action _execute;

        public AddCustomerCommand(Action action)
        {
            ////Console.WriteLine("RWEREW");

            _execute = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();

        }
    }
}
