using System;
namespace LambdaStuff
{
    public class Employee
    {
        public string Username { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public string EmployeeToString
        {
            get
            {
                return $"Username: {this.Username} \n Address: {this.Address} \n Position: {this.Position}";
            }
        }
    }
}
