using System.CodeDom.Compiler;
using System.Windows.Input;

namespace clicker.Commands
{
    class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _execute_action;
        private readonly Func<T, bool> _can_execute;

        public RelayCommand(Action<T> execution_action, Func<T, bool> canExecute = null)
        {
            _execute_action = execution_action ?? throw new ArgumentNullException(nameof(execution_action));
            _execute_action = execution_action;
        }
        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => _execute_action((T)parameter);

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
