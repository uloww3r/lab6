using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    public abstract class AbstractCar
    {
        private string _mark;
        private string _colour;
        private string _equipment;
        private int _price;

        public AbstractCar(int p, string m)
        {
            this.Price = p;
            this.Mark = m;
        }

        public abstract void TypeOfLoading();

        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public string Equipment
        {
            get { return _equipment; }
            set { _equipment = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
