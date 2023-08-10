using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06131756_周子彤
{
    class HundredNotes:Coin
    {
        public HundredNotes()
        {
            StaticNumber.hundrednotesnumber += 1;
        }

        public override double value()
        {
            return 100 * StaticNumber.hundrednotesnumber;
        }
    }
}
