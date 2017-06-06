using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autopark
{
    class Factory
    {
        public static AutoPark CreateAutoPark()
        {
            AutoPark APark = new AutoPark();
            return APark;
        }
    }
}
