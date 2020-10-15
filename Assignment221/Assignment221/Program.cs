using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment221
{
    class Program
    {
        static public void Main(string[] args)
        {
            Class1 Object = new Class1();
            Object.method(100, 0);  //Call the method in the class and pass two numbers
            Object.method(x: 100, y: 15); //Call the method in the class specify the parameters by name
            Console.ReadLine();

        }
    }
}