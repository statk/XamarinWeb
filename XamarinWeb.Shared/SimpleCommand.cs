using System;
using System.Windows.Input;

namespace XamarinWeb.Shared
{
    public class SimpleCommand : ICommand
    {
        private readonly Action _executeCommandAction;

        public SimpleCommand(Action executeCommandAction)
        {
            _executeCommandAction = executeCommandAction;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter = null)
        {
            _executeCommandAction.Invoke();
        }
    }
}
