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

namespace clicker
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void sing_in_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(log_box.Text))
            {
                warning.Content = "Warning: Login field is empty";
                return;
            }
            if (String.IsNullOrEmpty(pass_box.Password))
            {
                warning.Content = "Warning: Password field is empty";
                return;
            }

            var main_window = new MainWindow();
            main_window.Show();
            this.Close();
        }
    }
}
