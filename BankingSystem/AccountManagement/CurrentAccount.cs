using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement
{
    public class CurrentAccount : Account
    {

        private readonly int _overdraft; 
        public CurrentAccount(string AccountHolderName) : base(AccountHolderName)                                                                            
        {
            _overdraft = 1000;

        }

        public override void Display()
        {
            Console.WriteLine("Account No: {0}, Account Holder Name: {1}, Balance: {2}, Overdraft: {3}", AccountNo, AccountHolderName, Balance, _overdraft);
        }
    }
}
