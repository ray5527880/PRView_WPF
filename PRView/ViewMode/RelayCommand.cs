using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PRView.ViewMode
{
    public class RelayCommand : ICommand
    {
        private readonly Action _action;
        private readonly Func<bool> _func;
        public RelayCommand(Action action)
        {
            _action = action;
        }
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _func = canExecute;
            _action = execute;
        }

        public bool CanExecute(object parameter) => _func == null || _func();

        public void Execute(object parameter) => _action();

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
