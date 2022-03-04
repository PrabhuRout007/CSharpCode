using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement
{
    public class SavingAccount : Account , IInterestRate
    {
        private readonly int Interest;
        private  int _bal;

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
            Console.WriteLine("\nAccount No: {0} \nAccount Holder Name: {1} \nBalance: {2} \nInterestRate(%): {3} Interest Amount: {4}", AccountNo, AccountHolderName,Balance, Interest);
        }

        public void PayInterest()
        {
            Balance = Balance + Balance * Interest;
            

        }
    }
}
