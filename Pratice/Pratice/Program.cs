using System;
using System.Collections.Generic;
using System.Text;

namespace Pratice
{
    class Program: acounts
    {
        static void Main()
        {
   
            Intro d = new Intro();
            acounts a = new acounts();
            d.Load();
            d.intro();
            int option;

            do
            {
                Console.WriteLine("1.press 1 for creating a new account.");
                Console.WriteLine("2.press 2 for deposit to account.");
                Console.WriteLine("3.press 3 for withdraw from account.");
                Console.WriteLine("4.press 4 for checkbalance.");
                Console.WriteLine("5.press 5 for exit.");
                Console.WriteLine("select an option please.");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        Console.Clear();
                        d.Load();
                        a.createaccount();
                        break;
                    case 2:
                        Console.Clear();
                        d.Load();
                        a.account_Deposit();
                        break;
                    case 3:
                        Console.Clear();
                        d.Load();
                        a.account_Withdraw();
                        break;
                    case 4:
                        Console.Clear();
                        d.Load();
                        a.Account_Display();
                        break;
                    case 5:
                        return;
                }
            } while (option != 6);
            }
    }
}
