using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_One_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userEcho;
           
           


            Console.WriteLine("Hello! Please write a sentance to be echoed back!");
            userEcho = Console.ReadLine();
            Console.WriteLine(userEcho);


            Console.WriteLine("Please enter a number! (Numerical integer only ie: 7) ");
            int numberAdd = Convert.ToInt32(Console.ReadLine());
            int additionResult = numberAdd + 1;
            Console.WriteLine(additionResult);


            Console.WriteLine("Please enter a number with a decimal in the tenths position! (Numerical interger only ie: 10.5) ");
            double decNumber = Convert.ToDouble(Console.ReadLine());
            double decResult = decNumber + 0.5;
            Console.WriteLine(decResult);

            Console.WriteLine("Please enter a number!");
            double numOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter another number!");
            double numTwo = Convert.ToDouble(Console.ReadLine());

            double numResult = numOne + numTwo;

            Console.WriteLine(numResult);







            Console.WriteLine("Thank you for participating! Please press enter to end the program.");
            Console.ReadLine();

        }


    }
}
