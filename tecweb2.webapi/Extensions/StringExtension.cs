using System;
using System.Security.Cryptography;
using System.Text;

namespace tecweb2.webapi.Extensions
{
    public static class StringExtension
    {
        public static string CalculateMd5Hash(this string input)
        {
            byte[] hash = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte num in hash)
                stringBuilder.Append(num.ToString("X2"));
            return stringBuilder.ToString();
        }
        
        public static bool SearchContains(this string text, string value)
        {
            return SearchContains(text, value, StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool SearchContains(this string text, string value, StringComparison stringComparison)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }
        
        public static bool IsDigitsOnly(this string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

    }
}