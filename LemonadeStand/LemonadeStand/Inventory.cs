using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Ice> iceList;
        public List<Lemons> lemonsList;
        public List<Cups> paperCupList;
        public List<Sugar> sugarList;
        public Inventory()
        {
            paperCupList = new List<Cups> { };
            lemonsList = new List<Lemons> { };
            sugarList = new List<Sugar> { };
            iceList = new List<Ice> { };
        }


        public void inventoryReport()
        {
            Console.WriteLine("\nPaper cups on hand are\t\t[" + (paperCupList.Count) + "]" + " \nLemons on hand are\t\t[" + (lemonsList.Count) + "]" + "\nCups of Sugar on hand are\t[" + (sugarList.Count) + "]" + "\nIce cubes on hand are\t\t[" + (iceList.Count) + "]");
            Console.ReadLine();
        }
    }
}
