using System;
using System.Collections.Generic;
using System.Text;

namespace Pratice
{
    public class acounts
    {
        private int acno;

        public int useracno
        {
            get { return acno; }
            set { acno = value; }
        }

        private string name;
        private int deposit;

        public void Create_Account()
        {
            Console.WriteLine("\nEnter Account Number");
            useracno = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter Account Holder Name");
            name = Console.ReadLine();
            Console.WriteLine("Account Created Successfully.....\n");
            
        }

        public void createaccount()
        {
            Create_Account();
        }

        public void Show_Account()
        {
            Console.WriteLine("Your Account Number is{0}: \n",useracno);
            Console.WriteLine("Enter Account Number\n");
            Console.WriteLine("Enter Account Number\n");

        }
        private void Modify_Account()
        {
            Console.WriteLine("Account No {0}", acno);
            Console.WriteLine("Modify Account Number");

            name = Console.ReadLine();

            Console.WriteLine("Account No {0}", acno);
            deposit = int.Parse(Console.ReadLine());


        }
        public void modify_account()
        {
            Modify_Account();
        }

        public void account_Deposit()
        {
            int x;

            Console.WriteLine("Enter Amount to Deposit:\n");
            x = int.Parse(Console.ReadLine());

            deposit = deposit + x;
        }
        public void account_Withdraw()
        {
            int x;

            Console.WriteLine("Enter Amount to Withdraw:\n");
            x = int.Parse(Console.ReadLine());

            deposit = deposit - x;
        }

        public void Account_Display()
        {
            Console.WriteLine("Account No: {0},\n Account Holder Name: {1}\n Balance: {2}\n",acno,name,deposit);
        }

        public int ReturnAcNo()
        {
            return acno;
        }

        public int ReturnAmount()
            {
                return deposit;
            }

        }
}
