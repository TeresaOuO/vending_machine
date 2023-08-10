using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06131756_周子彤
{
    class Pocari:SoftDrink
    {
        public override double value()
        {
            return 20 * StaticNumber.pocarinumber;
        }
    }
}
