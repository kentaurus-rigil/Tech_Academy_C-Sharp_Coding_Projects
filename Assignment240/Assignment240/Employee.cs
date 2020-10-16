using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment240
{
    public class Employee : Person, IQuittable
    {
        public void Quit() 
        {
            Console.WriteLine("This employee quit.");
        }

        public override void SayName()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }
        

        
        

        


    }



}


