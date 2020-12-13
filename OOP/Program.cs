using Library.Models;
using System;

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
            dahalTheWebDeveloper.Develop();

            DatabaseDeveloper ryanTheDatabaseDeveloper = new DatabaseDeveloper("SQL");
            ryanTheDatabaseDeveloper.Code();
        }
    }
}