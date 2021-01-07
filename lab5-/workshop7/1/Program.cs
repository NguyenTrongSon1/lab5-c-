using System;

namespace company
{
    class Expenditure
    {
        protected string[] expenditureType = { "Maintenance", "Salary Paid", "Miscellaneous" };
        protected double[] expenditureAmount = new double[3];
        protected double TotalExpenses = 0;
        internal virtual void AcceptDetails()
        {
            Console.WriteLine("Enter the expenditure for the following heads:  ");
            for(int i =0; i < expenditureType.Length; i++)
            {
                Console.Write(expenditureType[i] + " : ");
                expenditureAmount[i] = Convert.ToDouble(Console.ReadLine());
                TotalExpenses += expenditureAmount[i];

            }
        }
        internal virtual void DisplayDetails()
        {
            Console.WriteLine("\n\n Expenditure Account");
            Console.WriteLine("\nExpenditure Head\t\t Amount ($)");
            Console.WriteLine("------------------------------------------");
            for(int i = 0; i < expenditureType.Length; i++)
            {
                Console.WriteLine(expenditureType[i] + "\t\t\t" + expenditureAmount[i]);
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Total expenditure\t\t" + TotalExpenses);
        }
    }
    class Revenue : Expenditure
    {
        private double _totalIncome;
        private double _balance;
        internal override void AcceptDetails()
        {
            Console.WriteLine("\n");
            base.AcceptDetails();
            Console.Write("\nEnter the revenue earned annually : ");
            _totalIncome = Convert.ToDouble(Console.ReadLine());
        }
        internal override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("\nTotal income\t\t\t" + _totalIncome);
            _balance = _totalIncome = TotalExpenses;
            if(_balance < 0)
            {
                Console.WriteLine("\nNet loss: " + _balance + "\n");
            }
            else
            {
                Console.WriteLine("\nNet Profit: " + _balance + "\n");
            }
        }
    }
    class RevenuaTest
    {
        static void Main(string[] args)
        {
            Revenue objrevenua = new Revenue();
            Expenditure objExp = new Expenditure();
            objExp.AcceptDetails();
            objExp.DisplayDetails();
            objrevenua.AcceptDetails();
            objrevenua.DisplayDetails();


        }
    }
}
