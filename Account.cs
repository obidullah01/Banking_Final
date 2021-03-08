using System;
using System.Collections;

namespace C_sharp_core
{
    class Account
{
    private int type; // 0 = saving 1 = checking 
    static private int total = 0;
    private int accountNumber;
    private String accountName;
    private double balance;
    private Address address;
    private ArrayList details;
    public Account(String name, String road, String house, String city, String country, int type)
    {
        this.balance = 0;
        address = new Address(road, house, city, country);
        this.accountName = name;
        total++;
        this.accountNumber = total;
        details = new ArrayList();
        details.Add("\nAll Transaction Histories Are :");
        this.type = type;
    }
    public void Withdraw(double amount)
    {
        if (type == 0)
        {
            if (balance - amount <= 0)
            {
                Console.WriteLine("Saving Accounts Can't Be Empty ! ");
                return;
            }
        }
        if (balance >= amount)
        {
            this.balance -= amount;
            details.Add("Widthraw : " + amount);
        }
        else
        {
            Console.WriteLine("\nBalance is low !");
        }
    }
    public void Deposit(double amount)
    {
        balance += amount;
        details.Add("Deposited : " + amount);
    }
    public void Transfer(Account receiver, double amount)
    {
        if (receiver == null)
        {
            Console.WriteLine("\nInvalid acoount !");
        }
        else
        {
            if (balance >= amount)
            {
                receiver.Deposit(amount);
                balance -= amount;
                details.Add("Transferred : " + amount + " To : " + receiver.accountName + "  [ID -> " + receiver.accountNumber + "]");

            }
            else
            {
                Console.WriteLine("\nBalance is low, Can not transfar !");
            }
        }
    }
    public void ShowAccountInformation()
    {
        if (type == 0)
        {
            Console.WriteLine(String.Format("ID : {0}, Name : {1}, Balance : {2}, Type : {3}", accountNumber, accountName, balance, "Savings Account."));
        }
        else
        {
            Console.WriteLine(String.Format("ID : {0}, Name : {1}, Balance : {2}, Type : {3}", accountNumber, accountName, balance, "Checking Account."));
        }

        Console.WriteLine(address.GetAddress());
    }
    public int GetId()
    {
        return this.accountNumber;
    }
    public void History()
    {
        foreach (String x in details)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine("########## [End of List] ########## ");
    }


}
}