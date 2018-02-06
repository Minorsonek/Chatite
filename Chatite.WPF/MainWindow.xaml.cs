using System.Windows;

namespace Chatite.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set DataContext of this window
            DataContext = new WindowViewModel(this);
        }
    }
}
