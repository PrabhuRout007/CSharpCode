using System;
using AccountManagement;
namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SavingAccount sa = new SavingAccount("Prabhu", 500);
           sa.Display();

            CurrentAccount ca = new CurrentAccount("Mahesh");
            ca.Display(); */

            Account[] ac = new Account[4];

            ac[0] = new SavingAccount("Prabhu Saving Account", 5000);
            ac[1] = new CurrentAccount("Prabhu Current Account");
            ac[2] = new SavingAccount(" Shubham Saving Account", 6000);
            ac[3] = new CurrentAccount(" Shubham Current Account");

            for (int i = 0; i < ac.Length; i++)
            {
                Console.WriteLine("{0} index: is {1} ", i, ac[i]);
            
            }

            Console.WriteLine("----------------------");

            foreach (Account a in ac)
            {
                Console.WriteLine(a);
            }




            // SavingAccount sa = new CurrentAccount();  >>> Not possible because no realtion (Inheritance) between Saving and Current Account.


        }
        //public static void Display(Account[] arr)
        //{
        //    foreach (Account ac in arr)
        //    {
        //        if (ac is SavingAccount)
        //        {
        //            SavingAccount sa = ac as SavingAccount;
        //            sa.PayInterest();
        //            sa.Display();
        //        }
        //        else if (ac is CurrentAccount)
        //        {
        //            CurrentAccount ca = ac as CurrentAccount;
        //            ca.Display();
                    
        //        }
            }
            
        }
    //}
//}
