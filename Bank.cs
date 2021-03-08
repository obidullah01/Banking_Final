using System;
using System.Collections;

namespace C_sharp_core
{
    class Bank
{
    private String bankName;
    ArrayList mybank;
    public Bank(String name)
    {
        this.bankName = name;
        mybank = new ArrayList();
    }
    public void AddAccount(Account account)
    {
        mybank.Add(account);
    }
    public void DeleteAccount(int id)
    {
        foreach (Account i in mybank)
        {
            if (i.GetId() == id)
            {
                mybank.Remove(i);
                break;
            }
        }
    }
    public void Transaction(int type, int ownId, double amount)
    {
        if (type == 1 || type == 2)
        {
            foreach (Account i in mybank)
            {
                if (i.GetId() == ownId)
                {
                    if (type == 1)
                    {
                        i.Withdraw(amount);
                    }
                    else
                    {
                        i.Deposit(amount);
                    }
                    return;
                }
            }
            Console.WriteLine("\nID not found");
        }
        else
        {
            Console.WriteLine("\nWrong Function Called !");
        }
    }
    public void Transaction(int type, int ownId, int recieverId, double amount)
    {
        Boolean tmp = false;
        if (type == 3)
        {

            foreach (Account i in mybank)
            {
                if (i.GetId() == ownId)
                {

                    foreach (Account x in mybank)
                    {
                        if (x.GetId() == recieverId)
                        {
                            tmp = true;
                            i.Transfer(x, amount);
                        }
                    }

                }
            }
            if (!tmp)
            {
                Console.WriteLine("\nID not found");
            }
        }
        else
        {
            Console.WriteLine("\nWrong Function Called !");
        }
    }
    public void PrintAccountDetails()
    {
        Console.Clear();
        Console.WriteLine("\n##########  All Accounts are");
        foreach (Account i in mybank)
        {
            Console.WriteLine();
            i.ShowAccountInformation();
            Console.WriteLine();
        }
        Console.WriteLine("##########");

    }
    public void PrintAccountDetails(int id)
    {

        foreach (Account i in mybank)
        {
            Console.WriteLine();
            if (i.GetId() == id)
            {
                i.ShowAccountInformation();
                i.History();
                return;


            }


        }
        Console.WriteLine("\nInvalid ID !");


    }

}
}