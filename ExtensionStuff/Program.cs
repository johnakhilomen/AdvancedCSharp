using System;

namespace ExtensionStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello World to the man coming!";
            Console.WriteLine(sentence.ConvertFromStringToArray(5));
        }
    }
}
