using Library.Helpers;
using Library.Models;
using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarSalesman nirajTheCarDude = new CarSalesman("Niraj", "Dahal");
            Console.WriteLine(nirajTheCarDude.FullName);
            nirajTheCarDude.Sell();

            RetailSalesMan himansuTheRetailMan = new RetailSalesMan("Himansu", "Poudel");
            Console.WriteLine(himansuTheRetailMan.FullName);
            himansuTheRetailMan.Sell();
            himansuTheRetailMan.Develop();

            WebDeveloper dahalTheWebDeveloper = new WebDeveloper("C#");
            dahalTheWebDeveloper.Code();
            dahalTheWebDeveloper.Code("Javascript", "Typescript");
            dahalTheWebDeveloper.Develop();

            DatabaseDeveloper ryanTheDatabaseDeveloper = new DatabaseDeveloper("SQL");
            ryanTheDatabaseDeveloper.Code();
            ryanTheDatabaseDeveloper.Code("Java");

            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");
            Console.WriteLine("*******************************");
            Console.WriteLine("");
            Console.WriteLine("");

            List<Salesman> salesmen = new List<Salesman>()
            {
                new CarSalesman("Rajib", "Bhandari"),
                new CarSalesman("Sahadev", "Bhandari"),
                new RetailSalesMan("Puran", "Dahal"),
                new RetailSalesMan("Pujan", "Boss")
        };

            foreach (var salesman in salesmen)
            {
                SalesHelper.HowISell(salesman);
            }
        }
    }
}