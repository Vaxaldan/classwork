using System;

namespace Day_7_Unit_Testing
{
    /*************************************************************************************************************
     * A generic BankAccount implementing the IBankAccount interface
     *
     * An account owner may own multiple BankAccounts
     *
     * Each Bank account will have a unique randomly assigned account number
     *************************************************************************************************************/
    public class BankAccount : IBankAccount
    {
        /**********************************************************************************************
         * Data Members - Class variables - only one defined and shared with all objects of the class
         *                static - indicates  a Class variable
         **********************************************************************************************/

        private static Random newAccountNumberGenerator = new Random();

        /***********************************************************************************************
         * Data Members - Instance variables - Each instance of the class gets its own set of variables
         ***********************************************************************************************/

        private string accountOwner;
        private string accountNumber;
        private double balance;

        /*****************************************************************************************
         * Data Members - Properties
         *****************************************************************************************/

        public string AccountOwner
        {
            get
            {
                return accountOwner;
            }
            set
            {
                accountOwner = value;
            }
        }

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        /*****************************************************************************************
         * Method Members - Constructors
         *****************************************************************************************/

        public BankAccount() {}

        public BankAccount(string accountOwner, double startingBalance)
        {
            if (startingBalance < 0)
            {
                startingBalance = 0;

            }
            this.accountOwner = accountOwner;
            this.balance = startingBalance;
            this.AccountNumber = newAccountNumberGenerator.Next(1000000, 9999999).ToString();

        }

        /*****************************************************************************************
         * Method Members - required by interface
         *****************************************************************************************/

        // Withdraw money from account and return balance after withdrawal
        // virtual keyword indicates sub-class may override this method
        public virtual double Withdraw(double withdrawalAmount)
        {
            Balance -= withdrawalAmount;
            return Balance;
        }

        // Deposit money from account and return balance after withdrawal
        // virtual keyword indicates sub-class may override this method
        public virtual double Deposit(double depositAmount)
        {
            Balance += depositAmount;
            return Balance;
        }

        // Display account information
        public void DisplayAccount()
        {
            Console.WriteLine(this); // Display object as a string (implied use of class ToString() method

        }

        /*****************************************************************************************
         * Method Members - Overrides
         *****************************************************************************************/
        public override string ToString()
        {
            return $"BankAccount:\n\tOwner: {AccountOwner}\n\tNumber: {AccountNumber}\n\tBalance: {Balance}";
        }

        public override bool Equals(object otherObject)
        {
            if (otherObject.GetType() != this.GetType())  // If object being compared is a different type...
            {
                return false;                             //    it cannot be equal the BankAccount is comparing to
            } 

            if (otherObject == this)                      // If object being compared is the same object it is being compared to...                    
            {
                return true;                              //    it must be equal the BankAccount is comparing to
            }

            BankAccount otherAccount = (BankAccount)otherObject;
            if (otherAccount.AccountNumber == this.AccountNumber) // If the two accounts have the same account number...
            {
                return true;                                      //    they are considered equal
            }

            return false;                                         // If any prior tests fail, the objects are not equal
        }

        public override int GetHashCode()
        {
            // Note: Balance is not included in GetHashCode calculation
            //       Only variables that do not change or do not change often should be used
            return AccountNumber.GetHashCode() + AccountOwner.GetHashCode();
        }
    } // End of BankAccount Class
} // End of BankAccount namespace