using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Hotdog : ICostcoFoodCourt
    {
        public void Order()
        {
            Console.WriteLine("I would like to order one hotdog with mustard only, no ketchup");
        }
    }
}
