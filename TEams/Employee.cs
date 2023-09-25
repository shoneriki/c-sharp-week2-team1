using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TEams
{
    public class Employee
    {
        public long EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; } = 60000;
        public Department Department { get; set;}
        public string HireDate { get; set; }
        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }

        public Employee(long employeeID, string firstName, string lastName, string email, Department department, string hireDate)
        {
            EmployeeId = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Department = department;
            HireDate = hireDate;
        }
        public Employee()
        {
        }
        public double RaiseSalary(double percent)
        {
            Salary = (percent / 100) * Salary + Salary;
            return Salary;
        }
        
        





    }
}
