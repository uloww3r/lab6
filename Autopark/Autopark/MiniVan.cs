using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    class MiniVan : PassengerCar
    {
        public MiniVan(int p, string m) : base(p,m) { }

        private string _specialAbilities;

        public string SpecialAbilities
        {
            get { return _specialAbilities; }
            set { _specialAbilities = value; }
        }
    }
}
