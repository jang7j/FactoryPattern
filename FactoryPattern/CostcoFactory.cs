using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class CostcoFactory //1.Make factory static
    {
        public static ICostcoFoodCourt GetLunch(decimal money) //2. public static interfaceName methodName (para)
        {
            switch (money)
            {
                case 1.00m:
                    return new Churro(); //3. Switch & case, return new Class name
                case 1.50m:
                    return new Hotdog();                
               default:
                    return new Pizza();
            }
        }
    }
}