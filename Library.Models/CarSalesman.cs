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
            this.DemonstrateValue();
            this.Engage();
            this.EstablishTrust();
            Console.WriteLine($"Hello! I'm {this.FullName}, a CarSalesman & I will sell this car");
        }

        protected override void DemonstrateValue()
        {
            Console.WriteLine("Ensure Quality");
        }

        protected override void Engage()
        {
            Console.WriteLine("Marketing is going on");
        }

        protected override void EstablishTrust()
        {
            Console.WriteLine("Make product very awesome");
        }
    }
}