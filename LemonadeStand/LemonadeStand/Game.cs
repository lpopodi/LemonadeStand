using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    public class Game
    {
        UserInterface ui;
        Inventory inventory;
        Player player;
        Store store;
        Recipe recipe;
        Day day;
        WeatherForecast weatherForecast;
        private int numberOfDays;

        public Game()
        {
            ui = new UserInterface();
            weatherForecast = new WeatherForecast();
            inventory = new Inventory();
            player = new Player();
            store = new Store();
            recipe = new Recipe();
            day = new Day();
            numberOfDays = 7;
        }

        public void StartGame()
        {
            ui.welcome();
            ui.ForecastInfo();
            weatherForecast.GetForecast();
            ui.ContinueToStartDay();
            for (int i = 0; i < numberOfDays; i++)
            {
                day.startDay();
                Console.WriteLine("Below is your Daily Inventory Report");
                inventory.inventoryReport();
                RestockOption(store);
           //     RecipeForLemonade();
                day.setSellingPriceForDay();
                
            }

            
        }

        public void RestockOption(Store store)
        {
            Console.WriteLine("Would you like to buy some ingredients\n\n\t[Y] or [N]\n");
            string stock = Console.ReadLine();
            if (stock.ToUpper() == "Y")
            {
                Console.Clear();
                store.showStoreMenu(player);
            }
            else
            {
                Console.WriteLine("You have chosen not to purchase anything today");
            }

        }

        public void RecipeForLemonade()
        {
            recipe.lemonadeRecipe();
            Console.ReadLine();
            recipe.showRecipeMenu();
            Console.ReadLine();
            recipe.lemonadeRecipe();
            Console.ReadLine();

        }


    }
}
