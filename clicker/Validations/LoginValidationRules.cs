using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace clicker.Validations
{
    public class LoginValidationRules : ValidationRule
    {
        private Regex regex = new Regex(@"^[A-Za-z0-9]{5,25}$");

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string? input = value.ToString();

            if (!regex.IsMatch(input))
            {
                if (input.Length < 5 || input.Length > 25)
                    return new ValidationResult(false, "Login have atleast 5 characters and maximum 25 characters");

                return new ValidationResult(false, "Enter a valid login");
            }
            else
                return ValidationResult.ValidResult;
        }
    }
}
