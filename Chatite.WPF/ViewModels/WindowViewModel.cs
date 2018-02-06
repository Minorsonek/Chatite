using Chatite.Core;
using System.Windows;
using System.Windows.Input;

namespace Chatite.WPF
{
    /// <summary>
    /// The view model for main application window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// The main window which contains this application
        /// </summary>
        private Window mWindow;

        #endregion

        #region Public Properties

        /// <summary>
        /// The size of title bar in this window
        /// </summary>
        public int CaptionHeight { get; set; } = 20;

        #endregion

        #region Commands

        /// <summary>
        /// The command to maximize this window
        /// </summary>
        public ICommand MinimizeCommand { get; private set; }

        /// <summary>
        /// The command to maximize this window
        /// </summary>
        public ICommand MaximizeCommand { get; private set; }

        /// <summary>
        /// The command to close this window
        /// </summary>
        public ICommand CloseCommand { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public WindowViewModel(Window window)
        {
            // Create commands
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());

            // Catch the main window to this view model
            mWindow = window;
        }

        #endregion
    }
}
