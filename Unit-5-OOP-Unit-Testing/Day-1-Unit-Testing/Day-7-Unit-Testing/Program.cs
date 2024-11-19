using System;
using GeneralPurposeFunctions;

namespace Day_7_Unit_Testing
{
    internal class Program
    {
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();

        static void Main(string[] args)
        {
            CheckingAccount frankAccount = new CheckingAccount("Frank", -100);
            CheckingAccount jennaAccount = new CheckingAccount("Jenna", 900);

            frankAccount.DisplayAccount();
            jennaAccount.DisplayAccount();

            frankAccount.Withdraw(90);       // Balance is 0 right now - should be -110 after Withdraw
            frankAccount.DisplayAccount();

            myFuncs.PauseProgram();
        }
    }
}
