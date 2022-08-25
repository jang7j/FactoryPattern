using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Pizza : ICostcoFoodCourt
    {
        public void Order()
        {
            Console.WriteLine("I would like a simple cheese pizza just for me");
        }
    }
}
