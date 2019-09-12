using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, number3, number4;

            Console.Write("Please enter first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
         number1, number2, number3, number4, result);
            Console.ReadKey();

        }
    }
}
