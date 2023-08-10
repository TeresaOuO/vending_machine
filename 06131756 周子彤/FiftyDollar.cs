using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06131756_周子彤
{
    class FiftyDollar:Coin
    {
        public FiftyDollar()
        {
            StaticNumber.fiftycoinnumber += 1;
        }

        public override double value()
        {
            return 50 * StaticNumber.fiftycoinnumber;
        }
    }
}
