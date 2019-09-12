using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your Last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter number");
            string number = Console.ReadLine();

            int result = 0;

            while (!int.TryParse(number, out result))
            {
                Console.WriteLine("Your input is not a number", number);
                 number = Console.ReadLine();
            }
          


        string fullName = name + " " + lastName + "." + " " + "You have entered number" + " " + result;
            Console.WriteLine($"Hello, {fullName}");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}