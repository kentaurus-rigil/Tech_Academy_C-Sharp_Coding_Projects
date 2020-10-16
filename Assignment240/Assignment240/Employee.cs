using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment240
{
    public class Employee : Person, IQuittable
    {
        public List<Employee> Employees { get; set; }
        public int ID { get; set; }
        public void Quit() 
        {
            Console.WriteLine("This employee quit.");
        }

        public override void SayName()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }
        
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if(employee1.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Employee employee3, Employee employee4)
        {
            if (employee3.ID != employee4.ID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        }
        
    }



