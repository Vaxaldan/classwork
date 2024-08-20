using System;using System.IO;


namespace practice_assessment_1_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Mock Assessment!");

            // Test IsTheSame() method
            //   1. with two equal values - expect method to return true
            Console.WriteLine("Test with two equal values is: " + IsTheSame(-1, -1));

            //   2. with two unequal value - expect method to return false
            Console.WriteLine("Test with two unequal values is: " + IsTheSame(-1, 1));

            // Test subtract method
            //  1. Send a big number and smaller number
            //  2. Send a smaller number and larger number
            //  3. Send two numbers with same value

           
            Console.WriteLine("Test Subtract(4, 10): "  + Subtract(4, 10));
            Console.WriteLine("Test Subtract(10, 10): " + Subtract(10, 10));

            Console.WriteLine("Test FindBuildingType(3): " + FindBuildingType(3));
            Console.WriteLine("Test FindBuildingType(1): " + FindBuildingType(1));
            Console.WriteLine("Test FindBuildingType(0): " + FindBuildingType(0));

            Console.WriteLine("Test FindBuildingType(4): " + FindBuildingType(4));
            Console.WriteLine("Test FindBuildingType(10): " + FindBuildingType(10));
            Console.WriteLine("Test FindBuildingType(4): " + FindBuildingType(5));

            Console.WriteLine("Test FindBuildingType(11): " + FindBuildingType(11));
            Console.WriteLine("Test FindBuildingType(49): " + FindBuildingType(49));
            Console.WriteLine("Test FindBuildingType(33): " + FindBuildingType(33));

            Console.WriteLine("Test FindBuildingType(50): " + FindBuildingType(50));
            Console.WriteLine("Test FindBuildingType(51): " + FindBuildingType(51));

            Console.WriteLine("Thanks for using my Mock Assessment!");

        } // End of main

        static string FindBuildingType(int floorAmount)
        {
            switch (floorAmount)
            {
                case int house when house <= 3:
                {
                    return "This is a house!";
                }
                case int officeBuilding when officeBuilding >= 4 && officeBuilding <= 10:
                {
                    return "This is a office building!";
                }
                case int skyscraper when skyscraper >= 11 && skyscraper <= 49:
                {
                    return "This is a skyscraper!";
                }
                case int superSkyscraper when superSkyscraper >= 50:
                {
                    return "This is a SUPER skyscraper!";
                }
                default:
                {
                    return "Invalid floor amount!";
                }
            }
        }


        static double Subtract(double num1, double num2)
        {
            /****** Overkill and not 100% correct (make the result -) *****
            // if num1 is greater than num2 - subtract num2 from num1
            //                      otherwise subtract num1 from num2
            //                                and return the negative of the result
            return (num1 > num2) ? num1 - num2 : -(num2 - num1);
            ***************************************************************/
            return num1 - num2;
        }



        // This method will receive two ints and return a bool
        //     return 
        //      type  name(parameters)
         static bool IsTheSame(int num1, int num2)
         {
             if (num1 == num2)
             {
                 return true; // terminate the method and return value to the caller
             }
             return false;  // else was not required since only choices are available
             /*
             else
             {
                 return false;
             } */

             // Every expression results in a value
             // the return statement returns a value
             // ergo and expression may be coded on a return statement

             // return num1 == num2;  // return the bool values from ==
         }
    } // End of class Program
} // End of namespace
