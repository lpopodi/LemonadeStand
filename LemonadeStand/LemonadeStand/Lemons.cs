using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemons : Ingredient
    {
        protected bool spoiled = false;

        public Lemons() : base()
        {
            this.daysExpire = 12; // 12 days to expire
        }
    }
}
