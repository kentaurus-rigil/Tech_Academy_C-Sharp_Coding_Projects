using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 0-100?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 100;  //For the While Loop

            do
            {
                switch (number)
                {
                    case 50:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("You guessed 29.  Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 75:
                        Console.WriteLine("You guessed 55.  Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 100:
                        Console.WriteLine("You guessed the number 12.  That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed);//For the While Loop "!isGuessed" is the same as isGuessed = false
            
            Console.Read();
        }
    }
}