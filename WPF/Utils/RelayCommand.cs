using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.Utils
{
    public class RelayCommand : ICommand
    {
        private Action _methodToExecute;
        private Func<bool> _canExecute;

        public RelayCommand(Action methodToExecute, Func<bool> canExecute)
        {
            _methodToExecute = methodToExecute;
            _canExecute = canExecute;
        }

        public RelayCommand(Action methodToExecute) : this(methodToExecute, null)
        {}

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            
            return _canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            _methodToExecute.Invoke();
        }
    }
}
