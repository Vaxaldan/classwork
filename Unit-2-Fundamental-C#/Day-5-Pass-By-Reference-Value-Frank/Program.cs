using System;

namespace Day_5_Pass_By_Reference_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum   = 0;
            int yourNum = 0;

            Console.WriteLine("\n------ Calling method by value and by reference ------");
            Console.WriteLine("Values before call to method: myNum=" + myNum + "  yourNum=" + yourNum);
           
            method1(myNum, ref yourNum); // myNum is passed by value, yourNum is passed by reference
            
            Console.WriteLine("Values after call to method: myNum=" + myNum + "  yourNum=" + yourNum);

            Console.WriteLine("\nPlease press enter to end program");
            Console.Read();

        } // End of Main()
        // num1 is received by value, num2 is received by reference (has access to original data)
        static void method1(int num1, ref int num2)
        {
            Console.WriteLine("At start of method, num1=" + num1 + "   num2=" + num2);
            num1++;
            num2++;
            Console.WriteLine("At  end  of method, num1=" + num1 + "   num2=" + num2);
        }

    }// End of class Program
} // End of namespace
