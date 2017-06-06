using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public abstract class PassengerCar : AbstractCar
    {
        private string _driveUnit;
        private int _capacity;
        private string _comfort;
        private int _doorsAmount;

        public PassengerCar(int p, string m) : base(p,m) { }

        public string DriveUnit
        {
            get { return _driveUnit; }
            set { _driveUnit = value; }
        }

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public string Comfort
        {
            get { return _comfort; }
            set { _comfort = value; }
        }

        public int DoorsAmount
        {
            get { return _doorsAmount; }
            set { _doorsAmount = value; }
        }

        public override void TypeOfLoading()
        {
            Console.WriteLine("Кошерный способ");
        }
    }
}
