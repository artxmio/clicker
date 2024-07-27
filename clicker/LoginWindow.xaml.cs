using System;
using System.Diagnostics;
using System.Windows;
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

        private void exit_program(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void window_moving(object sender, MouseButtonEventArgs e)
        {
            if(Mouse.LeftButton == MouseButtonState.Pressed) 
                this.DragMove();
        }

        /// <summary>
        /// переделать на что-то внятное
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void telegram_click(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                Process.Start(new ProcessStartInfo("https://t.me/temikgamecompany") { UseShellExecute = true });
        }
        private void inst_click(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                Process.Start(new ProcessStartInfo("https://www.instagram.com/no.needany?igsh=M3hoaHRqMmg1Njlw") { UseShellExecute = true });
        }
        private void youtube_click(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                Process.Start(new ProcessStartInfo("https://www.youtube.com/@artxmixx") { UseShellExecute = true });
        }

        private void close_MouseEnter(object sender, MouseEventArgs e)
        {
            close.Foreground = Brushes.Red;
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

        private void close_MouseLeave(object sender, MouseEventArgs e)
        {
            close.Foreground = Brushes.Linen;
        }
    }
}
