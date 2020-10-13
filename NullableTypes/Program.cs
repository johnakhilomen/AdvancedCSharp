using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            //date = date.HasValue == false ? DateTime.Today : date.GetValueOrDefault();
            //OR
            date = date ?? DateTime.Today; 
            Console.WriteLine("Date: " + date);
            string? someName = null;
            someName = someName ?? "Jane";
            Console.WriteLine(someName);
        }
    }
}
