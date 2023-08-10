using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06131756_周子彤
{
    class OneDollar:Coin
    {
        public OneDollar()
        {
            StaticNumber.onecoinnumber += 1;
        }

        public override double value()
        {
            return 1 * StaticNumber.onecoinnumber;
        }
    }
}
