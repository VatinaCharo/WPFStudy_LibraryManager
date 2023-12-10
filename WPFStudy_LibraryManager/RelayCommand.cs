using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFStudy_LibraryManager
{
    internal class RelayCommand : ICommand
    {
        readonly Action _execute;
        readonly Func<bool> _canExecute;
        public RelayCommand(Action action, Func<bool> canExecute)
        {
            _execute = action;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { if(_canExecute != null) CommandManager.RequerySuggested += value; }
            remove { if (_canExecute != null) CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
