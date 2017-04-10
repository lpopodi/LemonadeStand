using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {


        Player player = new Player();
        public UserInterface()
        {

        }

        public void welcome()
        {
            Console.WriteLine("Welcome to Lemonade Stand\n");
            player.GetName();
            Console.WriteLine("\n-RULES-");
            Console.WriteLine("__________");
            Console.WriteLine("\nYou will have one week,to turn a profit on sellind Lemonade");
            Console.WriteLine("\nAt the beginning of each day, you will see the weather for the day");
            Console.WriteLine("\nYou will then have the chance to buy supplies at the store, change your recipe, make and sell lemonade.");
            Console.WriteLine("You will need to keep enough supplies on had to make sure you'll have enough for all your potential customers ");
            Console.WriteLine("Be cautious on how much you are buying as you could end up with a lot of waste ");
            Console.WriteLine("\nYou have $20 in your Cash Box\n");
            Console.WriteLine("Press enter to continue");
            Console.WriteLine("===================================================");
            Console.ReadKey();
        }

        public void ForecastInfo()
        {
            Console.WriteLine("Press enter to see the forecast outlook for the week .. as the forecasters say now");
            Console.ReadLine();
        }

        public void ContinueToStartDay()
        {
            Console.WriteLine("Now that you've seen the forecast, let's start your day and see if those forecasters were right");
            Console.ReadLine();
        }


        public void StoreMenuInstruct()
        {
            Console.WriteLine("Welcome to the store here you can buy all the ingredients that you will need");
            Console.WriteLine("What would you like to over purchase \n\n[C] Paper Cups\n[L] Lemons\n[S] Sugar\n[I] Ice\n[E] exit");
            Console.Write("\nPlease enter one of the store choices");
        }

        public void CupPurchaseInfo()
        {
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t50  Solo Cups for $1.00\n[2]\t100  Solo Cups for $1.75\n[3]\t250 Solo Cups for $2.75\n\n");
            Console.Write("Your choice ");
        }

        public void LemonPurchaseInfo()
        {
            Console.WriteLine("Select a quantity for your order.\n\n[1]\t10  Lemons for $0.75\n[2]\t25  Lemons for $1.75\n[3]\t75 Lemons for $3.00\n\n");
            Console.Write("Your choice ");
        }

        public void SugarPurchaseInfo()
        {
            Console.WriteLine("\nSelect a quantity for your order.\n\n[1]\t10 Cups of Sugar for $.75\n[2]\t30 Cups of Sugar for $2.00\n[3]\t75 Cups or Sugar for $4.50");
            Console.Write("Your choice ");
        }

        public void IcePurchaseInfo()
        {
            Console.WriteLine("\nSelect a quantity for your order.\n\n[1]\t100 Ice Cubes for $1.00\n[2]\t250 Ice Cubes for $2.25\n[3]\t500 Ice Cubes for $3.50");
            Console.Write("Your choice ");
        }

    }
}
