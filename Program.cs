using System;
using System.Collections;


namespace C_sharp_core
{
    class Program
    {
        static void Wrong()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWrong Command !");
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            //parameter || account = 0/savings 1/checkings
            //parameter || transfer = 1/withdraw 2/deposit 3/transfer

            ArrayList X = new ArrayList();
            Account a = new Account("Musa", "12", "4A", "Natore", "Bangladesh", 0);
            Account b = new Account("Mim", "13", "8B", "Natore", "Bangladesh", 1);
            Account c = new Account("Piash", "10", "XB", "Rajshahi", "Bangladesh,", 0);

            Bank Demo = new Bank("MyBank");
            Demo.AddAccount(a);
            Demo.AddAccount(b);
            Demo.AddAccount(c);

            String s = new String("");
            while (true)
            {
            start:
                Console.WriteLine("\n*************************************************************");
                Console.WriteLine(" \"open\"    [ Task : Open an account ]");
                Console.WriteLine(" \"account\" [ Task : Perform transactions on an account ]");
                Console.WriteLine(" \"info\"    [ Task : Displays All Accounts Information ]");
                Console.WriteLine(" \"quit\"    [ Task : Exit the application ]");
                Console.WriteLine("*************************************************************");
                Console.Write("Enter Commands To Operate : ");
                s = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (s.CompareTo("open") == 0)
                {
                    int tmp = 0;
                    while (true)
                    {
                        Console.WriteLine("\nOptions Are : \n");
                        Console.WriteLine("savings");
                        Console.WriteLine("checking");
                        Console.WriteLine("quit");
                        Console.Write("\nEnter Commands To Operate : ");
                        s = Console.ReadLine().ToLower();
                        if (s.CompareTo("savings") == 0)
                        {
                            tmp = 0;
                            goto create;
                        }
                        else if (s.CompareTo("checking") == 0)
                        {
                            tmp = 1;
                            goto create;
                        }
                        else if (s.CompareTo("quit") == 0)
                        {
                            Console.Clear();
                            goto start;
                        }
                        else
                        {
                            Wrong();
                        }

                    }
                create:
                    String t1, t2, t3, t4, t5;
                    Console.Write("Enter Name : ");
                    t1 = Console.ReadLine();
                    Console.Write("Enter Road No. : ");
                    t2 = Console.ReadLine();
                    Console.Write("Enter House No. : ");
                    t3 = Console.ReadLine();
                    Console.Write("Enter City : ");
                    t4 = Console.ReadLine();
                    Console.Write("Enter Country : ");
                    t5 = Console.ReadLine();
                    Demo.AddAccount(new Account(t1, t2, t3, t4, t5, tmp));


                }
                else if (s.CompareTo("account") == 0)
                {
                    while (true)
                    {
                        Console.WriteLine("\nOptions Are : \n");
                        Console.WriteLine("deposit");
                        Console.WriteLine("withdraw");
                        Console.WriteLine("transfer");
                        Console.WriteLine("show");
                        Console.WriteLine("quit");
                        Console.Write("\nEnter Commands To Operate : ");
                        s = Console.ReadLine().ToLower();
                        Console.WriteLine();
                        if (s.CompareTo("deposit") == 0)
                        {
                            int t1; double t2;
                            Console.WriteLine("Enter Account ID to Deposite : ");
                            t1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Amount : ");
                            t2 = Double.Parse(Console.ReadLine());
                            Demo.Transaction(2, t1, t2);


                        }
                        else if (s.CompareTo("withdraw") == 0)
                        {
                            int t1; double t2;
                            Console.WriteLine("Enter Account ID to Withdraw : ");
                            t1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Amount : ");
                            t2 = Double.Parse(Console.ReadLine());
                            Demo.Transaction(1, t1, t2);

                        }
                        else if (s.CompareTo("transfer") == 0)
                        {
                            int t1, r; double t2;
                            Console.WriteLine("Enter Sender Account ID  : ");
                            t1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Receiver Account ID  : ");
                            r = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Amount : ");
                            t2 = Double.Parse(Console.ReadLine());
                            Demo.Transaction(3, t1, r, t2);

                        }
                        else if (s.CompareTo("show") == 0)
                        {
                            Console.WriteLine("Enter Account ID to View History : ");
                            Demo.PrintAccountDetails(Int32.Parse(Console.ReadLine()));
                        }
                        else if (s.CompareTo("quit") == 0)
                        {
                            Console.Clear();
                            goto start;
                        }
                        else
                        {
                            Wrong();
                        }
                    }

                }
                else if (s.CompareTo("quit") == 0)
                {
                    return;
                }
                else if (s.CompareTo("info") == 0)
                {
                    Demo.PrintAccountDetails();
                }

                else
                {
                    Wrong();
                }

            }

        }
    }
}