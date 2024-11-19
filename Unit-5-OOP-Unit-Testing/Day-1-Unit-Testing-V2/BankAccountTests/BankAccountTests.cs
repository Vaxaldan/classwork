namespace BankAccountTests
{
    using Day_1_Unit_Testing;
    using Xunit;

    // xUnit tests for testing BankAccount functionality

    /***********************************************************************************************************
     * Common xUnit Assertions
     *
     * Assertions need to be true for a test to pass
     *    
     *    Assert.Equal(expected, actual)    - True if two objects are equal
     *    Assert.NotEqual(expected, actual) - True if two objects are equal
     *
     *    Assert.Equal(expected, actual, fudge-factor) - True if two double/float values
     *                                                   are within "fudge-factor" of each other
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
    /*********************************************************************************************
     * 3 parts to every Unit Test:
     *
     *    Arrange - set up test data for the test
     *
     *    Act - run method you are testing with the test data
     *
     *    Assert - verify the result is what was expected using xUnit Assertations (Assert.xxxx)
     *
     * Occasionally the steps might be combined into one - not recommended, but OK if necessary
     *
     *
     * [Fact] - identifies the start of a Unit Test (if missing, xUnit doesn't know it's a test)
     *
     * XUnit tests are public return void and receive no parameters
     *
     * The name of test should describe in detail what you are testing
     * (it's the only time being verbose is a good thing)
     * You never use the test name again - it only appears in results
     *
     **********************************************************************************************/

    public class BankAccountTests
    {
        /*********************************************************************************************
         * Test Constructors - Do they initialize objects as expected
         *********************************************************************************************/

        [Fact]  // This is an xUnit test
        public void BankAccount_Is_Created_With_Correct_Information_When_Given_Valid_Balance()
        {
            // Arrange - Define data required for test
            string testAcctOwner = "TestAccount1";
            double testValidStartingBalance = 100;

            // Act - Execute process you are testing - run the constructor with the test data
            BankAccount testAccount = new BankAccount(testAcctOwner, testValidStartingBalance);

            // Assert - Verify result of process execution - be sure the correct data is in the object
            //          an assertion must be true to pass

            Assert.Equal(testAccount.Balance, testValidStartingBalance);
            Assert.Equal(testAccount.AccountOwner, testAcctOwner);
            Assert.NotNull(testAccount.AccountNumber);  // Does it have an AccountNumber?
        }

        [Fact]
        public void BankAccount_Is_Created_With_Correct_Information_When_Given_Invalid_Balance()
        {
            //    Arrange - Define data required for test

            string acctOwner = "TestAccount1";
            double invalidStartingBalance = -100;
            double expectedResult = 0;  // Typically expected is variable
                                        //  rather than a constant coded in the assert

            // Act - Execute process you are testing - run the constructor with the test data
            BankAccount testAccount = new BankAccount(acctOwner, invalidStartingBalance);

            // Assert - Verify result if process execution
            // Note: "fudge-factor" to indicate they are equal up to decimal places
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
            // Arrange 
            string testAcctOwner = "TestAccount1";
            double testValidStartingBalance = 10000;
            BankAccount testAccount = new BankAccount(testAcctOwner, testValidStartingBalance);

            // Act - run the method you are testing with the test data
            testAccount.Withdraw(6000); // expecting 4000

            // Assert
            Assert.Equal(4000, testAccount.Balance);
        }

    }  // End of BankAccountTests Class
} // End of namespace