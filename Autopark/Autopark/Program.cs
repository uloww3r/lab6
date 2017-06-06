using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int autosAmount;
            int car;
            AutoPark APark = new AutoPark();


            autosAmount = rand.Next(20) + 1;

            Console.WriteLine("В автопарке находятся: ");
            for (int i = 1; i <= autosAmount; i++)
            {
                car = rand.Next(9) + 1;
                switch (car)
                {
                    case 1:
                        HatchBack hb = new HatchBack(rand.Next(50000) + 300000, "ХэтчБэк ");
                        APark.AddCars(hb);
                        Console.WriteLine("Тип автомобиля = " + hb.Mark + " по цене: " + hb.Price);
                        break;
                    case 2:
                        MiniVan m = new MiniVan(rand.Next(50000) + 400000, "Минивэн");
                        APark.AddCars(m);
                        Console.WriteLine("Тип автомобиля = " + m.Mark + " по цене: " + m.Price);
                        break;
                    case 3:
                        Truck t = new Truck(rand.Next(50000) + 450000, "Грузовик");
                        APark.AddCars(t);
                        Console.WriteLine("Тип автомобиля = " + t.Mark + " по цене: " + t.Price);
                        break;
                    case 4:
                        Van v = new Van(rand.Next(50000) + 380000, "Фургон");
                        APark.AddCars(v);
                        Console.WriteLine("Тип автомобиля = " + v.Mark + " по цене: " + v.Price);
                        break;
                }
            }


            int Price = APark.CountPrice();
            Console.WriteLine("Текущая стоимость автопарка = " + Price);
            Console.ReadKey();
        }
    }
}
