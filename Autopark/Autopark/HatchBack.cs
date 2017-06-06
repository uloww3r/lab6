using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    class HatchBack : PassengerCar
    {
       
        public HatchBack(int p, string m) : base(p,m) { }

        private int _clirence;
        private int _volumeOfTrunk;

        public int Clirence
        {
            get { return _clirence; }
            set { _clirence = value; }
        }

        public int VolumeOfTrunk
        {
            get { return _volumeOfTrunk; }
            set { _volumeOfTrunk = value; }
        }
    }
}
