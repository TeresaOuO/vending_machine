using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06131756_周子彤
{
    class TenDollar:Coin
    {
        public TenDollar()
        {
            StaticNumber.tencoinnumber += 1;
        }

        public override double value()
        {
            return 10 * StaticNumber.tencoinnumber;
        }
    }
}
