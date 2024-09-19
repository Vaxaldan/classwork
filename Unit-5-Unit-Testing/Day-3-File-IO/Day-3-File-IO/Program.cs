using GeneralPurposeFunctions;
namespace Day_3_File_IO
{
    internal class Program
    {
        private static CommonlyUsedFunctions _myFuncs = new CommonlyUsedFunctions();

        static void Main(string[] args)
        {
            _myFuncs.WriteSeparatorLine("Welcome to a File I/O Example");


            _myFuncs.PauseProgram();
            _myFuncs.WriteSeparatorLine("Thanks for visiting a File I/O Example");

        }
    }
}
