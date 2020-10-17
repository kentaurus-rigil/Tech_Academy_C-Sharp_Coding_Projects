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
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>() 
            { "Mike Meyers", "Dana Carvey", "John Belushi", "Gilda Radner", "Phil Hartman", "Amy Poehler" };
            Employee<int> employee1 = new Employee<int>();
            employee1.things = new List<int>() { 100, 101, 102, 103, 104};
           
            foreach (string item in employee.things) // Loop through List with foreach
            {
                Console.WriteLine(item);
            }


            foreach (int item in employee1.things) // Loop through List with foreach
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            //Person person = new Employee();
            //Employee employee = new Employee();
            //Employee employee1 = new Employee();
            //employee.ID = 0100;
            //employee1.ID = 0101;
            //Console.WriteLine(employee1.ID == employee.ID);

            //Employee myEmployee = new Employee();
            //myEmployee.Quit();

            //{

            //    employee1.firstName = "Sample";
            //    employee1.lastName = "Student";
            //    employee1.SayName();
            //    Console.ReadLine();
            //}

        }   
    }
}
