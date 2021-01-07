using System;
using System.Collections.Generic;
using System.Text;

namespace companyy
{
    class productTest
    {
        static void Main(string[] args)
        {
            product objProduct = new product();

            Console.Write("Enter the Customer Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter the invoice number : ");
            int value = Convert.ToInt32(Console.ReadLine());

            objProduct.SetDetails(value, name);

            objProduct.SetDetails();

            objProduct.Display();

        }
    }
}
