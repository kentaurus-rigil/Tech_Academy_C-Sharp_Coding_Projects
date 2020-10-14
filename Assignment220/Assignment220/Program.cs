using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Assignment220
{
    class Program
    {
        static public void Main(string[] args)
        {
            Class1 ObjOne = new Class1();
            Console.WriteLine("Please enter two numbers, one at a time.  The second number is optional.");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            string secondNumber = Console.ReadLine();
            if(secondNumber == "")
            {
                int results = ObjOne.AddNumber(firstNumber);
                Console.WriteLine("The answer is: " + results);
            }
            else
            {
                int answer = Convert.ToInt32(secondNumber);
                int results = ObjOne.AddNumber(firstNumber, answer);
                Console.WriteLine("The answer is: " + results);

            }
                
            
            Console.ReadLine();


        }
    }
    }

