using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement
{
    public class SavingAccount : Account , IInterestRate
    {
        private readonly int Interest;

        public SavingAccount(string AccountHolderName): base(AccountHolderName)
        {
            Interest = 5;
        
        }
        public SavingAccount(string AccountHolderName, float initial_deposit) : base(AccountHolderName, initial_deposit)
        {
            Interest = 5;
        }
        public override void Display()
        {
            Console.WriteLine("Account No: {0}, Account Holder Name: {1}, Balance: {2}, Interest: {3}", AccountNo, AccountHolderName,Balance, Interest);
        }

        public void PayInterest()
        {
            Balance = Balance + Balance * Interest;
        }
    }
}
