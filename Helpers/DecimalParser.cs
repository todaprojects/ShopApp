using System;

namespace ShopApp.Helpers
{
    public class DecimalParser
    {
        public static decimal Parse(string input)
        {
            try
            {
                return decimal.Parse(input);
            }
            catch (Exception e)
            {
                throw new ArgumentException();
            }
        }
    }
}