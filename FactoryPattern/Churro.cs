using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Churro : ICostcoFoodCourt
    {
        public void Order()
        {

            Console.WriteLine("I would like one churro dipped in cinnamon and sugar"); 
        }
    }
}
