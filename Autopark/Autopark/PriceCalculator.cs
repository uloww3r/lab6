using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    class PriceCalculator
    {
        public int GetPrice(AbstractCar Car)
        {
            int Price;
            Price = Car.Price;
            return Price;
        }
    }
}
