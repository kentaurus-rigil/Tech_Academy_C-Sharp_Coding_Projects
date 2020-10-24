using System;
using System.Collections.Generic;
using System.Text;

namespace ConstantAssignment2
{
    class Employee
    {
        public Employee(string name) : this(name, 2312)
        {

        }
        public Employee(string name, int idNum)
        {
            Name = name;
            EmployeeID = idNum;
        }
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        Employee emp = new Employee("This is a name");
        Console.WriteLine(emp.EmployeeID);
    }
}
    

