using clicker.Models;
using clicker.Views;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace clicker
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            ((IComponentConnector)this).InitializeComponent();
        }

        private void window_moving(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void telegram_click(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                Process.Start(new ProcessStartInfo("https://t.me/artxmix") { UseShellExecute = true });
        }

        private void github_click(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                Process.Start(new ProcessStartInfo("https://github.com/artxmio") { UseShellExecute = true });
        }

        private void youtube_click(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                Process.Start(new ProcessStartInfo("https://www.youtube.com/@artxmixx") { UseShellExecute = true });
        }

        private void ref_to_registration_MouseEnter(object sender, MouseEventArgs e)
        {
            ref_to_registration.Foreground = Brushes.AliceBlue;
        }

        private void ref_to_registration_MouseLeave(object sender, MouseEventArgs e)
        {
            ref_to_registration.Foreground = Brushes.Lime;
        }

        private void ref_to_registration_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var registration_window = new RegistrationWindow();
            registration_window.Show();
            this.Close();
        }
    }
}
