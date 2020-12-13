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

        public virtual void Code(string firstExtraDevLanguage)
        {
            Console.WriteLine($"My extra language is {firstExtraDevLanguage}");
        }

        public virtual void Code(string firstExtraDevLanguage, string secondExtraDevLanguage)
        {
            Console.WriteLine($"My main dev langugage are : {firstExtraDevLanguage} & {secondExtraDevLanguage}");
        }
    }
}