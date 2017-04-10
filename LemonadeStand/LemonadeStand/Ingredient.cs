using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ingredient
    {
        public int daysExpire;
        public int tier1Quantity, tier2Quantity, tier3Quantity;
        public decimal tier1Price, tier2Price, tier3Price;

        public int DaysExpire
        {
            get
            {
                return daysExpire;
            }

            set
            {
                daysExpire = value;
            }
        }

        public void subtractDay()
        {
            daysExpire -= 1;
        }

    }
}
