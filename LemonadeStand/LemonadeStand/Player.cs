using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Inventory inventory;
        public CashBox cashbox;

        public Player()
        {
            inventory = new Inventory();
            cashbox = new CashBox();
        }

        public string GetName()
        {
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();

            Console.WriteLine("Welcome {0}.", playerName);
            return playerName;
            Console.ReadLine();
        }

    }
}
