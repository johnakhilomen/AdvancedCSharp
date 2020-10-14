using System;
using System.Collections.Generic;

namespace LambdaStuff
{
    public class EmployeeList
    {
        private List<Employee> _employees;
        public EmployeeList()
        {
            _employees = new List<Employee>
            {
                new Employee {Username = "Joe user", Address = "Joe's Address", Position = "Manager"},
                new Employee {Username = "Bob user", Address = "Bob's Address", Position = "Director"},
                new Employee {Username = "Sam user", Address = "Sam's Address", Position = "Manager" }
            };
        }
        public List<Employee> GetEmployees()
        {
            return this._employees;
        }
    }
}
