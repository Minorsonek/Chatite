using System;
using System.Windows.Input;

namespace Chatite.Core
{
    /// <summary>
    /// A basic command that runs an Action
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Private Members

        /// <summary>
        /// The action to run whenever this command is executed
        /// </summary>
        private Action mAction;

        #endregion

        #region Public Events

        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayCommand(Action action)
        {
            mAction = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Indicates if this command can be executed
        /// As default, this command is executable
        /// </summary>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// Executes the action this command is aligned to
        /// </summary>
        public void Execute(object parameter)
        {
            // Simply run the action 
            mAction();
        }

        #endregion
    }
}
