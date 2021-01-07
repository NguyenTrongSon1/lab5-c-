using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class SavingTest
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                SavingAccount objSavings = new SavingAccount();

                if (objSavings.AcceptDetails())
                {
                    objSavings.Display();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
