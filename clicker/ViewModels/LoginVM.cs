using clicker.Commands;
using clicker.Models;
using clicker.Views;
using System.Threading.Channels;
using System.Windows;
using System.Windows.Input;

namespace clicker.ViewModels
{
    class LoginVM : ViewModelBase
    {
        private UserModel user;

        public ICommand login_sing_in_command { get; }
        public ICommand login_close_command { get; }
        public LoginVM()
        {
            user = new UserModel();
            login_sing_in_command = new RelayCommand<Window>((param) => LoggedIn(param));
            login_close_command = new RelayCommand<Window>((param) => CloseWindow(param));
        }

        public string login
        {
            get => user.login;
            set
            {
                user.login = value;
                OnPropertyChanched(nameof(login));
            }
        }

        public string password
        {
            get => user.password;
            set
            {
                user.password = value;
                OnPropertyChanched(nameof(password));
            }
        }

        private void LoggedIn(Window window)
        {
            if (user.IsValid())
            {
                (new MainWindow()).Show();
                window?.Close();
            }
        }

        private void CloseWindow(Window window) => window?.Close();
    }
}