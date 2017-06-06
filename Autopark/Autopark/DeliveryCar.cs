using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public abstract class DeliveryCar : AbstractCar
    {
        private int _carryingCapacity;
        private int _enginePower;

        public DeliveryCar(int p, string m) : base(p, m) { }

        public int CarryingCapacity
        {
            get { return _carryingCapacity; }
            set { _carryingCapacity = value; }
        }

        public int EnginePower
        {
            get { return _enginePower; }
            set { _enginePower = value; }
        }

        public override void TypeOfLoading()
        {
            Console.WriteLine("Кошерный способ");
        }
    }
}
