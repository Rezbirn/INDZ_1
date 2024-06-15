using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace INDZ_1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            OK.IsEnabled = false;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.SecretPassword = PasswordNew1.Password;
            Visibility = Visibility.Hidden;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
        }
        private void PasswordNew_PasswordChanged(object sender, RoutedEventArgs e)
        {
            OnPasswordTextChanged(PasswordNew1.Password, PasswordNew2.Password);
        }

        private void OnPasswordTextChanged(string passwordNew1, string passwordNew2)
        {
            if (!string.IsNullOrEmpty(passwordNew1) && !string.IsNullOrEmpty(passwordNew2) && passwordNew1 == passwordNew2)
            {
                OK.IsEnabled = true;
                return;
            }
            OK.IsEnabled = false;
        }

        
    }
}
