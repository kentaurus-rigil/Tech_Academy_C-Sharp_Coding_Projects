using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{firstName = "Joe", lastName = "Ramone", id = 101},
                new Employee{firstName = "Roger", lastName = "Daltrey", id = 102},
                new Employee{firstName = "John", lastName = "Lennon", id = 103},
                new Employee{firstName = "Jim", lastName = "Morrison", id = 104},
                new Employee{firstName = "Freddie", lastName = "Mercury", id = 105},
                new Employee{firstName = "Robert", lastName = "Plant", id = 106},
                new Employee{firstName = "Mick", lastName = "Jagger", id = 107},
                new Employee{firstName = "Joe", lastName = "Crocker", id = 108},
                new Employee{firstName = "Brian", lastName = "Wilson", id = 109},
                new Employee{firstName = "Chris", lastName = "Cornell", id = 110}
            };


            List<Employee> joeList = new List<Employee>();
            foreach (Employee item in employees)
            {
                if (item.firstName == "Joe")
                {
                    joeList.Add(new Employee { firstName = item.firstName, lastName = item.lastName, id = item.id });
                    Console.WriteLine("{0} {1}",item.firstName, item.lastName);
                }
            }
            List<Employee> newList = employees.Where(x => x.firstName == "Joe").ToList();
            
            foreach (Employee name in newList)
            {
                Console.WriteLine("{0} {1}", name.firstName, name.lastName);
            }

            List<Employee> idList = employees.Where(x => x.id > 5).ToList();
            foreach (Employee name in idList)
            {
                Console.WriteLine("{0} {1} {2}", name.firstName, name.lastName, name.id);
            }
            Console.ReadLine();
        }
    }
}
        


