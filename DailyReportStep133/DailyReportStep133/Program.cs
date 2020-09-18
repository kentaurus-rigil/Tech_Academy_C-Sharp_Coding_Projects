using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("The Tech Academy \r\n Student Daily Report");

        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();
        Console.WriteLine("Welcome" + yourName);
       

        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();
        Console.WriteLine("You are on the" + courseName + "course.");

        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        int pgNumber = Convert.ToInt32(pageNumber);
        int total = pgNumber;
        Console.WriteLine("You are on page number:" + pageNumber);

        Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\". ");
        bool boolneedHelp = bool.Parse(Console.ReadLine());

        Console.WriteLine("Were there any positive experiences you'd like to share?  Please give specifics.");
        string posExp = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
        string feedBack = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string studyHours = Console.ReadLine();
        int stdyhrs = Convert.ToInt32(studyHours);
        int all = stdyhrs;

        Console.WriteLine("Thank you for your answers.  " +
                    "An Instructor will respond to this shortly.  Have a great day!");


        Console.ReadLine();
                    }
                }
            
        
    

