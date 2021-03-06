﻿using System;

namespace companyy
{
    class Invoice
    {
        private int _invoiceNumber;

        private string _customerName;

        private DateTime _invoiceDate;

        public virtual void SetDetails()
        {
            _invoiceDate = DateTime.Now;

        }

        public void SetDetails(int number, string name)
        {
            _invoiceNumber = number;
            _customerName = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nINVOICE DETAILS : ");
            Console.WriteLine("\nInvoice No : \t " + _invoiceNumber);
            Console.WriteLine("\nInvoice Date : \t " + _invoiceDate.ToShortDateString());
            Console.WriteLine("\nInvoice Name : \t " + _customerName);
        }
    }
}

