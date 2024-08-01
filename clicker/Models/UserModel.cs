using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace clicker.Models
{
    public class UserModel : IDataErrorInfo
    {
        public string login { get; set; }
        public string password { get; set; }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        readonly Regex regex = new Regex(@"^[A-Za-z0-9]{5,24}$");
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;

                if (login is not null && password is not null)
                    switch (columnName)
                    {
                        case "login":
                            string value = login;
                            if (!regex.IsMatch(value))
                                error = "Invalid login format";
                            break;
                        case "password":
                            if (!regex.IsMatch(password))
                                error = "Invalid password format";
                            break;
                    }
                return error;
            }
        }

        public UserModel()
        { }

        public UserModel(string login, string password)
        {
            this.login = login;
            this.password = password;
        }



    }
}
