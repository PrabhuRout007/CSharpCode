using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement
{
    public abstract class Account
    {
        private readonly int _AccountNo;
        private string _AccountHolderName;
        private float _balance;

        public int AccountNo
        {
            get { return _AccountNo; }
        }

        public string AccountHolderName
        {
            get { return _AccountHolderName; }
        }
        public float Balance
        {
            get { return _balance; }
            protected set { _balance = value; }
        }

        public Account(string AccountHolderName)
        {
            _AccountNo = 1;
            _AccountHolderName = AccountHolderName;
            _balance = 0;
        }
        
        public Account(string AccountHolderName, float intial_deposit)
        {
            _AccountNo = 1;
            _AccountHolderName = AccountHolderName;
            _balance = intial_deposit;
        }

        public virtual void Display()
        {
            Console.WriteLine("Account No: {0}, Account Holder Name: {1}, Balance: {2}",AccountNo,AccountHolderName,Balance);
        }

    }
}
