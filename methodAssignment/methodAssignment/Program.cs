using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAssignment
{
   public class Program
    {
        static void Main(string[] args)
        {
            Math ObjOne = new Math();
            Console.WriteLine("Enter a number.");
            int numOne = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine (ObjOne.methodOne(numOne));
            Console.WriteLine(ObjOne.methodTwo(numOne));
            Console.WriteLine(ObjOne.methodThree(numOne));
            Console.ReadLine();
        }
        
       
    }
}
