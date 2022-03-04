using System;
using System.Collections.Generic;
using System.Text;

namespace AccountDetails
{
    public class Deposit : CreateAccount
    {
        public Deposit(string Name) : base(Name)
        {
            if (Name == AccountHolderName)
            {
                Console.WriteLine("Account Found...");
            }
            else {
                Console.WriteLine("Account Not Found... Please Create an Account....");
            }
        }
    }
}
