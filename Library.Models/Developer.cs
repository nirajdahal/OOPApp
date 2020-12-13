using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public abstract class Developer
    {
        private string MainDevLanguage { get; set; }

        public Developer(string mainDevLanguage)
        {
            this.MainDevLanguage = mainDevLanguage;
        }

        public virtual void Code()
        {
            Console.WriteLine($"My main dev langugage is {this.MainDevLanguage}");
        }
    }
}