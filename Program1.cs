using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_and_events
{
 public   class Program1
    {
        static void Main()
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Experience = 15,
                Salary = 30000
            };
            List<Employee> lstEmployess = new List<Employee>();
            lstEmployess.Add(emp1);
            lstEmployess.Add(emp2);
            lstEmployess.Add(emp3);
            Employee.PromoteEmployee(lstEmployess, x => x.Experience > 5);
            Console.ReadKey();
        }
    }
}
