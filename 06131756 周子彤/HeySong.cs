using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06131756_周子彤
{
    class HeySong : SoftDrink
    {
        public override double value()
        {
            return 18 * StaticNumber.heysongnumber;
        }
    }
}
