using System;
using System.Collections.Generic;
using System.Text;

namespace AccountDetails
{
    public class CreateAccount
    {
        private int _AccountNo;
        private string _Name;
        private int _balance;
        public CreateAccount(string Name)
        {
            _Name = Name;
            _AccountNo = _Name.Length*21020136;
            _balance = 0;
     
        }

        public string AccountHolderName
        {

            get { return _Name; }
        }
        public void Display()
        {
            Console.WriteLine("Account Created Successfully \n Name: {0}, Account No: {1}, Balance: {2}", _Name, _AccountNo, _balance);
        }

    }
}
