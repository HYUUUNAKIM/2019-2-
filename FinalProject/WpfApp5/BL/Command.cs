using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp5.BL
{
    class Command
    {
        Action<object> _execute;
        Func<object, bool> _canexecute;
        public Command(Action<object> execute, Func<object, bool> canexecute)
        {
            _execute = execute;
            _canexecute = canexecute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
