using System;

namespace ShopApp.Helpers
{
    public class IntegerParser
    {
        public static int Parse(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (Exception e)
            {
                throw new ArgumentException();
            }
        }
    }
}