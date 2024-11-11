using System;

interface Account
{
    void Open_Account();
    void Close_Account();
}

interface Customer
{
    void Display_Customer_Detail();
}

class SavingAccount : Account, Customer
{
     string CustomerName;
     int AccountNumber;
     double Balance;

    public static string BankName;


    public SavingAccount()
    {
        CustomerName = "";
        AccountNumber = 0;
        Balance = 0;
    }

    public SavingAccount(string customerName, int accountNumber, double initialDeposit)
    {
        CustomerName = customerName;
        AccountNumber = accountNumber;
        Balance = initialDeposit;
    }

    static SavingAccount()
    {
        BankName = "Pnb Bank";  
    }

    public void Open_Account()
    {
        Console.WriteLine("Account opened for {0} with Account Number: {1}", CustomerName, AccountNumber);
    }

    public void Close_Account()
    {
        Console.WriteLine("Account with Account Number {0} is now closed.", AccountNumber);
        CustomerName = "";
        AccountNumber = 0;
        Balance = 0;
    }

    public void Display_Customer_Detail()
    {
        Console.WriteLine("Customer Name: {0}", CustomerName);
        Console.WriteLine("Account Number: {0}", AccountNumber);
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawal successful! You withdrew: ${0}", amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance. Cannot withdraw ${0}.", amount);
        }
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Deposit successful! You deposited: ${0}", amount);
    }

    public void Check_And_Display_Balance()
    {
        Console.WriteLine("Current balance: ${0}", Balance);
    }
}

class Program
{
    static void Main()
    {
        SavingAccount account1 = new SavingAccount("Anjali", 22421000, 1000.0);

        account1.Display_Customer_Detail();
        account1.Open_Account();

        account1.Check_And_Display_Balance();

        account1.Deposit(500.0);
        account1.Check_And_Display_Balance();
        account1.Withdraw(300.0);
        account1.Check_And_Display_Balance();

        account1.Close_Account();

        Console.WriteLine("Bank Name: " + SavingAccount.BankName);
    }
}
