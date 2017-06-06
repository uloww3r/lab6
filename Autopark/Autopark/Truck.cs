using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    class Truck : DeliveryCar
    {
        private int _length;
        private int _maxHeight;

        public Truck(int p, string m) : base(p,m) { }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public int MaxHeight
        {
            get { return _maxHeight; }
            set { _maxHeight = value; }
        }
    }
}
