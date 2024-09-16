using Day_7_Unit_Testing;

namespace BankAccountTests
{
    using Xunit;

    /***********************************************************************************************************
     * Common xUnit Assertions
     *
     * Assertions need to be true for a test to pass
     *    
     *    Assert.Equal(expected, actual)    - True if two objects are equal
     *    Assert.NotEqual(expected, actual) - True if two objects are equal
     *
     *    Assert.Equal(expected, actual, fudge-factor) - True if two double/float values
     *                                                   are within "fudge-factor- of each other
     *
     *    Assert.Null(object)    - True if object is null
     *    Assert.NotNull(object) - True if object is not null
     *
     *    Assert.InRange(actual, low, high)    - True if actual falls between low and high (inclusive)
     *    Assert.NotInRange(actual, low, high) - True if actual does not fall between low and high (inclusive)
     *
     *    Assert.Same(expected, actual)     - True if the expected and actual object references are to the same object
     *    Assert.NotSame(expected, actual)  - True if the expected and actual object references are not the same object
     *
     *    Assert.IsAssignableFrom<T>(obj)  - True if an object is castable to the type <T>
     *    Assert.IsType<T>(obj)            - True if an object is the type <T>
     *
     *    Assert.Empty(collection)    - True if the collection is empty, while
     *    Assert.NotEmpty(collection) - True if the collection is not empty
     *
     *    Assert.Contains(expected, collection)        - True if the expected item is found in the collection
     *    Assert.DoesNotContain<(expected, collection) - True if the expected item is not found in the collection
     * 
     **********************************************************************************************************************/


    public class BankAccountTests
    {
        /*********************************************************************************************
         * Test Constructors
         *********************************************************************************************/
      
        [Fact]
        public void BankAccount_Is_Created_With_Correct_Information_When_Given_Valid_Balance()
        {
        // Arrange - Define data required for test
           string testAcctOwner = "TestAccount1";
           double testValidStartingBalance = 100;

        // Act - Execute process you are testing
           BankAccount testAccount = new BankAccount(testAcctOwner, testValidStartingBalance);

       // Assert - Verify result of process execution
       
            Assert.Equal(testAccount.Balance, testValidStartingBalance);
            Assert.Equal(testAccount.AccountOwner, testAcctOwner);
            Assert.NotNull(testAccount.AccountNumber);
        }

        [Fact]
        public void BankAccount_Is_Created_With_Correct_Information_When_Given_Invalid_Balance()
        {
        //    Arrange - Define data required for test

           string acctOwner = "TestAccount1";
           double invalidStartingBalance = -100;
           double expectedResult = 0;

         BankAccount testAccount = new BankAccount(acctOwner, invalidStartingBalance);

         // Assert - Verify result if process execution
            Assert.Equal(testAccount.Balance, expectedResult, .001);
        }

        [Fact]
        public void Account_Numbers_Are_Unique()
        {
            // Arrange - Define data required for test
            string testAcctOwner1 = "TestAccount1";
            string testAcctOwner2 = "TestAccount2";
            double testValidStartingBalance = 100;

            // Act - Execute process you are testing
            BankAccount testAccount1 = new BankAccount(testAcctOwner1, testValidStartingBalance);
            BankAccount testAccount2 = new BankAccount(testAcctOwner2, testValidStartingBalance);

            // Assert - Verify result of process execution
            Assert.NotEqual(testAccount1.AccountNumber, testAccount2.AccountNumber);
        }

        /*********************************************************************************************
         * Test Class Methods
         *********************************************************************************************/

        [Fact]
        public void Withdraw_Method_Withdraws_Proper_Amount()
        {
            string testAcctOwner = "TestAccount1";
            double testValidStartingBalance = 100;

            BankAccount testAccount = new BankAccount(testAcctOwner, testValidStartingBalance);

            Assert.Equal(testAccount.Balance, testValidStartingBalance);
        }

    }  // End of BankAccountTests Class
} // End of namespace