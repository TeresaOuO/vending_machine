using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06131756_周子彤
{
    class SellMachine
    {
        private double total_amount;
        public SellMachine()
        {
            total_amount = 0;
        }
        public void Sell(Coin obj)
        {
            if (obj == null)
            {
                total_amount += 0;
            }
            else
            {
                total_amount = total_amount + obj.value();
            }
        }
        public string Display()
        {
            return "總投幣金額: " + Convert.ToString(total_amount) + " 元";
        }
    }
}
