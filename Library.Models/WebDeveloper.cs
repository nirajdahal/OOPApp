using Library.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class WebDeveloper : Developer, ISelfDevelop
    {
        public WebDeveloper(string mainDevLanguage) : base(mainDevLanguage)
        {
        }

        public void Develop()
        {
            Console.WriteLine("I develop myself by wathing Programming Video");
        }
    }
}