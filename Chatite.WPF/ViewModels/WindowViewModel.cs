using Chatite.Core;
using System;
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

        /// <summary>
        /// The window resizer library to fix some window scaling issues
        /// </summary>
        private WindowResizer mWindowResizer;

        #endregion

        #region Public Properties

        /// <summary>
        /// The size of title bar in this window
        /// </summary>
        public int CaptionHeight { get; set; } = 32;

        #endregion

        #region Commands

        /// <summary>
        /// The command to show windows menu on icon button
        /// </summary>
        public ICommand MenuCommand { get; private set; }

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
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());

            // Catch the main window to this view model
            mWindow = window;
            mWindowResizer = new WindowResizer(mWindow);
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Returns current cursor position on the screen
        /// </summary>
        private Point GetMousePosition() => mWindowResizer.GetCursorPosition();

        #endregion
    }
}
