using System;
using System.Linq;

namespace ExtensionStuff
{
    public static class StringExtensions
    {

        public static string ConvertFromStringToArray(this String str, int num)
        {
            var splitString = str.Split(" ");
            return string.Join(" ", splitString.Take(5));
        }
    }
}
