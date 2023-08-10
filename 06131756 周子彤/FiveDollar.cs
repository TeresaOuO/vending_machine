using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06131756_周子彤
{
    class FiveDollar:Coin
    {
        public FiveDollar()
        {
            StaticNumber.fivecoinnumber += 1;
        }

        public override double value()
        {
            return 5 * StaticNumber.fivecoinnumber;

        }
    }
}
