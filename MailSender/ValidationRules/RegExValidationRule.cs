using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MailSender.ValidationRules
{
    public class RegExValidationRule : ValidationRule
    {
        private Regex _Regex;

        public string Pattern
        {
            get => _Regex.ToString();
            set => _Regex = value is null ? null : value == string.Empty ? null : new Regex(value);
        }

        public bool AllowNull { get; set; } = true;

        public string ErrorMessage { get; set; }
        public override ValidationResult Validate(object value, CultureInfo Culture)
        {
            if (value is null)
                return AllowNull
                    ? ValidationResult.ValidResult
                    : new ValidationResult(false, ErrorMessage ?? "Отсутствует ссылка на строку");
            if(_Regex is null) return ValidationResult.ValidResult;
            if (!(value is string str))
                str = value.ToString();
            return _Regex.IsMatch(str)
                ? ValidationResult.ValidResult
                : new ValidationResult(false, ErrorMessage ?? 
                $"Строка не удовлетворяет регулярному выражению {Pattern}");

           
        }
    }
}
