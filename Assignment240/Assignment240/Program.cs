using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment240
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee();
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            employee.ID = 0100;
            employee1.ID = 0101;
            Console.WriteLine(employee1.ID == employee.ID);
             
            Employee myEmployee = new Employee();
            myEmployee.Quit();

            {
                
                employee1.firstName = "Sample";
                employee1.lastName = "Student";
                employee1.SayName();
                Console.ReadLine();
            }

        }   
    }
}
