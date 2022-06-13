using System;

namespace webapp
{

    class program
    {
        static void Main(string[] agrs)


        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit....");
            Console.ReadKey(true);
        }
    }




}