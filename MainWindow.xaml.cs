using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INDZ_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Window1 _window1;
        public static string SecretPassword = "qwerty";
        public MainWindow()
        {
            InitializeComponent();
            _window1 = new Window1();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (Password.Text == SecretPassword && !_window1.IsVisible)
            {
                _window1.Owner = this;
                _window1.ShowDialog();
            }
        }
    }
}