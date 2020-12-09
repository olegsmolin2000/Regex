using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public static class NewRegex
    {
        public static bool isTime(this string line)
        {
            Regex reg = new Regex(@"^(([0-1]\d)|(2[0-3])):([0-5]\d)$");
            return reg.IsMatch(line);
        }

        public static bool isMAC(this string line)
        {
            Regex reg = new Regex(@"^([0-9a-f]{2}:){5}[0-9a-f]{2}$", RegexOptions.IgnoreCase);
            return reg.IsMatch(line);
        }

        public static bool isEmail(this string line)
        {
            Regex reg = new Regex(@"^\w+@[a-zA-Z]+(\.?[a-zA-Z]+)?$");
            return reg.IsMatch(line);
        }

        public static bool isData(this string line)
        {
            Regex reg = new Regex(@"^((((([0-2]\d|3[0-1])/(01|03|05|07|08|10|12))|(([0-2]\d|30)/(04|06|09|11))|(([0-1]\d|2[0-9])/02))/\d\d(00|04|08|12|16|20))|(((([0-2]\d|3[0-1])/(01|03|05|07|08|10|12))|(([0-2]\d|30)/(04|06|09|11))|(([0-1]\d|2[0-8])/02))/\d\d\d\d))$");
            return reg.IsMatch(line);
        }

        public static bool isProcent(this string line)
        {
            Regex reg = new Regex(@"^\d+(\.\d{1,3}\s?)?%$");
            return reg.IsMatch(line);
        }

        public static bool isCorrectPassword(this string line)
        {
            Regex reg = new Regex(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(.{8,}))");
            return reg.IsMatch(line);
        }

    }
}
