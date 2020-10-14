using System;
using System.Collections.Generic;

namespace LambdaStuff
{
    class Program
    {
        private static Func<int, int, int> sumOfTwoIntegers;

        static void Main(string[] args)
        {
            sumOfTwoIntegers = (x, y) => x + y;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Sum of x and y is: " + sumOfTwoIntegers(50, 23));
            var findManagers = new EmployeeList().GetEmployees().FindAll(emp => emp.Position == "Manager");
            var findDirector = new EmployeeList().GetEmployees().Find(emp => emp.Position == "Director");
            Console.WriteLine("Director");
            Console.WriteLine(findDirector.EmployeeToString);
            findManagers.ForEach(emp => Console.WriteLine(emp.EmployeeToString));
        }

        
    }
}
