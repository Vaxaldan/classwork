namespace Day_7_Unit_Testing
{
    public interface IBankAccount
    {
        // Withdraw money from account and return balance after withdrawal
        double Withdraw(double withdrawalAmount);

        // Deposit money from account and return balance after withdrawal
        double Deposit(double depositAmount);

        // Display account information
        void DisplayAccount();
    }
}