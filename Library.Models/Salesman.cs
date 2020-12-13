using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public abstract class Salesman
    {
        private string _firstName;

        private string _lastName;

        private string _fullName;

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (value.Length > 5)
                {
                    this._fullName = value;
                }
                else
                {
                    throw new ArgumentException("Enter name longer than 5");
                }
            }
        }

        public Salesman(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this.FullName = this._firstName + " " + this._lastName;
        }

        public abstract void Sell();

        protected abstract void Engage();

        protected abstract void EstablishTrust();

        protected abstract void DemonstrateValue();

        protected abstract void Close();

        //public virtual override void Sell()
        //{
        //    Console.WriteLine($"Hello! I'm {this.FullName} & I will sell this item to you");
        //}
    }
}