﻿using System;
using System.Windows.Input;

namespace BrokHub_VirtualPhoneNumber.MVVM.Base
{
    public class IBaseCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public IBaseCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute is null)
                throw new ArgumentNullException("Action is Null");
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute != null ? true : _canExecute.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
