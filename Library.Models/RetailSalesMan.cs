using Library.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class RetailSalesMan : Salesman, ISelfDevelop
    {
        public RetailSalesMan(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void Develop()
        {
            Console.WriteLine("I develop myself by wathing Retail Sales Video");
        }

        public override void Sell()
        {
            Console.WriteLine($"Hello! I'm {this.FullName}, a Retail Salesman & I will sell this pen");
        }
    }
}