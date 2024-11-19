using Day_1_Unit_Testing;
using Xunit;

namespace CheckingAccountTests
{
    public class CheckingAcountTests
    {
        /**********************************************************************************
         * Generate Unit tests for "Happy Path" and "Edge/Error" cases
         * 
         * Quite often, the requirements for the appliction has great starting points
         * for tests.
         * 
         * For this class we were given:
         * 
         *    An account has a balance of 0 and attempts a withdrawal of $90
         *    ALLOWED as the balance after the transaction would be -100 (with overdraft fee)
         *
         *    An account has a balance of 0 and attempts a withdrawal of $100
         *    NOT ALLOWED as the balance after the transaction would be -110 (with overdraft fee)
         * 
         *    An account has a balance of 100 and attempts a withdrawal of $100
         *    ALLOWED as the balance after the transaction would be 0
         *********************************************************************************/

        /*    An account has a balance of 0 and attempts a withdrawal of $90
         *    ALLOWED as the balance after the transaction would be -100 (with overdraft fee)
         **/

        [Fact]
        public void Withdrawl_With_Overdraft_Fee()
        {
            // Arrange - define test data for test

            double testStartBalance = 0; // Starting Balance

            // CheckingAccount with a known balance
            CheckingAccount testAccount = new CheckingAccount("test Owner", testStartBalance);

            // Withdrawal amount greater than the balance (but less than $10 more than balance)
            double testWithdrawal = 90;

            // Act - test method using test data
            testAccount.Withdraw(testWithdrawal);

            // Assert - verify we get the expected value
            //          is the balance -100
            Assert.Equal(-100, testAccount.Balance);
        }
    }
}