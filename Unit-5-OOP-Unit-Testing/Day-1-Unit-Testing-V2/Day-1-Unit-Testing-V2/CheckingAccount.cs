using System;
using System.Diagnostics.PerformanceData;

namespace Day_1_Unit_Testing

/*************************************************************************************************************
 * A CheckingAccount is a BankAccount with the following restrictions:
 *
 *      1. Account may be overdrawn, but by no more that $100
 *      2. If an account becomes overdrawn, a $10 overdraft fee will be charged to the account
 *
 * Examples:  An account has a balance of 0 and attempts a withdrawal of $90
 *            ALLOWED as the balance after the transaction would be -100 (with overdraft fee)
 *
 *            An account has a balance of 0 and attempts a withdrawal of $100
 *            NOT ALLOWED as the balance after the transaction would be -110 (with overdraft fee)
 * 
 *            An account has a balance of 100 and attempts a withdrawal of $100
 *            ALLOWED as the balance after the transaction would be 0
 *
 *************************************************************************************************************/

{
    public class CheckingAccount : BankAccount
    {

        private const double OverDrawnFee    = 10;
        private const double MaxOverdrawnAmt = -100;

        // sub-class ctor  must call the base-class ctor with the data for base class
        public CheckingAccount(string acctOwner, double startBalance)
                             : base(acctOwner, startBalance){}

        public override double Withdraw(double amount)
        {
            // Only allow the withdraw if the balance isn't going to go below -$100
            if (Balance - amount > MaxOverdrawnAmt)
            {
                // Process the withdrawal using the base class Withdraw function
                base.Withdraw(amount);
                // If the account is now overdrawn, charge overdraft fee
                if (Balance < 0)
                {
                    base.Withdraw(OverDrawnFee); // Process the withdrawal using the base class Withdraw function
                }
            }

            return Balance;
        }
    }
}