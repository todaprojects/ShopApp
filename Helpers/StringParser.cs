using System;
using System.Text.RegularExpressions;

namespace ShopApp.Helpers
{
    public class StringParser
    {
        public static string[] Parse(string input)
        {
            try
            {
                return Regex.Split(input.ToLower() ?? string.Empty, "\\s+");
            }
            catch (Exception e)
            {
                throw new ArgumentException();
            }
        }
    }
}