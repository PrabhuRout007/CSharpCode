using System;
using AccountDetails;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

            Console.WriteLine("Welcome to the  Bank:");
            Console.WriteLine("Press 1 for Create Account:");
            Console.WriteLine("Press 2 for Deposit:");
            Console.WriteLine("Press 3 for Withdraw:");
            Console.WriteLine("Press 4 for CheckBalance:");
            Console.WriteLine("Press 5 to EXIT:");

            int choice = Convert.ToInt32(Console.ReadLine());
                 
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your Name:");
                        string name = Console.ReadLine();
                        CreateAccount a = new CreateAccount(name);
                        a.Display();
                        break;

                    case 2:
                        Console.WriteLine("Enter you Name to Deposit");
                        string Name = Console.ReadLine();
                        if (Name == AccountHolderName)
                        {
                            Console.WriteLine("Account Found... Please Create an Account....");
                        }
                        else
                        {
                            Console.WriteLine("Account Not Found... Please Create an Account....");
                        }
                        break;



                }
            } 
        }
    }
}


