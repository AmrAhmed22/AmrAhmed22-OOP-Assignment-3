using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections
{
    public static class StringValidationExtensions
    {
        public static bool IsValidEgyptianPhone(this string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            return Regex.IsMatch(input, @"^(\+20|0)1[0125]\d{8}$");
        }

        public static bool IsValidEgyptianNationalId(this string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            return Regex.IsMatch(input, @"^[23]\d{13}$");
        }

    }
}
