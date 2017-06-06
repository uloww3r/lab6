using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{   
     public class AutoPark
    {
        private int autosAmount = 0;
        private int countPrice = 0;
        PriceCalculator calculator = new PriceCalculator();
    

        protected List<AbstractCar> list_of_cars = new List<AbstractCar>();

        public int CountPrice()
        {
            for (int i = 0; i < list_of_cars.Count; i++)
            {
                countPrice = countPrice + calculator.GetPrice(list_of_cars[i]);
            }
            return countPrice;
        }
        

        public void AddCars(AbstractCar _car)
        {
            list_of_cars.Add(_car);
            autosAmount += 1;
        }
    }
}
