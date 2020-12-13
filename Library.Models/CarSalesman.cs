using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class CarSalesman : Salesman
    {
        public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Sell()
        {
            Console.WriteLine($"Hello! I'm {this.FullName} & I will sell this car");
        }
    }
}