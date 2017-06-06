using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    class Van : DeliveryCar
    {
        public Van(int p, string m) : base(p,m) { }

        private string _typeOfVan;

        public string TypeOfVan
        {
            get { return _typeOfVan; }
            set { _typeOfVan = value; }
        }
    }
}
