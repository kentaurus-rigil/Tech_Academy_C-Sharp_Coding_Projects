﻿using System;
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
            Employee myEmployee = new Employee();
            myEmployee.Quit();

            {
                Employee employee1 = new Employee();
                employee1.firstName = "Sample";
                employee1.lastName = "Student";
                employee1.SayName();
                Console.ReadLine();
            }

        }   
    }
}
