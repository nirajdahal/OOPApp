using Library.Models;
using System;

namespace Library.Helpers
{
    public static class SalesHelper
    {
        public static void HowISell(Salesman salesman)
        {
            salesman.Sell();
        }
    }
}