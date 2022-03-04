using System;
using System.Collections.Generic;
using System.Text;

namespace Pratice
{
    struct Intro
    {
        public void intro()
        {
            Console.WriteLine("Welcome to Bank:\n");
            Console.WriteLine("We will be happy to help You...:\n");

        }

        public void showDetails()
        {
            intro();
        }

        public void Load()
        {
            Console.Write("Loading...");
            for (int i = 1; i < 3; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
