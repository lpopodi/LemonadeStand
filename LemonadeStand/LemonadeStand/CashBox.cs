using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class CashBox
    {
        public decimal cashboxBalance = 20.00M;
        public void showCashBoxBalance()
        {
            Console.WriteLine(cashboxBalance);
        }
    }
}
