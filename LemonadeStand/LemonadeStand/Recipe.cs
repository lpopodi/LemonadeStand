using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public int numOfCups;

        public int numOfLemons;

        public int numOfSugar;

        public int numOfIce;

        public int maxNumOfCups;

        public int maxNumOfPitchers;

        public int cupsPerPitcher;

        public bool changeRecipe;


        public Recipe()

        {
            numOfLemons = 4;
            numOfSugar = 4;
            numOfIce = 4;
            numOfCups = 1; 
            maxNumOfCups = 0;
            maxNumOfPitchers = 0;
            cupsPerPitcher = 12;
            changeRecipe = true;
        }
        public int GetNumberOfLemons()
        {
            return numOfLemons;
        }

        public int GetNumberOfSugar()
        {
            return numOfSugar;
        }

        public int GetNumberOfIce()
        {
            return numOfIce;
        }

        public int GetMaxNumberOfCups()
        {
            return maxNumOfCups;
        }

        public int GetMaxNumberOfPitchers()
        {
            return maxNumOfPitchers;
        }

        public int GetCupsPerPitcher()
        {
            return cupsPerPitcher;
        }

        public void lemonadeRecipe()
        {
            string changeRecipe = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is your Lemonade Recipe");
            Console.WriteLine( "\nLemons in recipe\t\t[" + (numOfLemons) + "]" + "\nCups of Sugar in recipe\t[" + (numOfSugar) + "]" + "\nIce cubes in recipe\t\t[" + (numOfIce) + "]");
            Console.WriteLine("Would you like to alter the default Lemonade Recipe?");
            Console.ReadLine();
            if (changeRecipe.ToUpper() == "Y")
            {
                showRecipeMenu();
            }
            else
            {
                Console.WriteLine("You have chosen the default Lemonade Recipe");
                Console.ReadLine();
            }
        }

        public void showRecipeMenu()
        {
            do
            {
                string recipeChoice = Console.ReadLine().ToUpper();
                if (recipeChoice == "L")
                {
                    changeLemonCount();
                }
                else if (recipeChoice == "S")
                {
                    changeSugarCount();
                }
                else if (recipeChoice == "I")
                {
                    changeIceCount();
                }
                else if (recipeChoice == "E")
                {
                    Console.WriteLine("Your Lemonade recipe has been updated");
                    Console.WriteLine("Enter to continue");
                    Console.ReadLine();
                    changeRecipe = false;
                }
                else
                {
                    Console.WriteLine("Plase choose on of the options");
                    Console.ReadLine();
                    showRecipeMenu();
                }
            } while (changeRecipe == true);
        }

        public void changeLemonCount()
        {
            Console.Clear();
            Console.WriteLine("Enter New Lemon count for Recipe");
            int usersChoice = Convert.ToInt32(Console.ReadLine());
            numOfLemons = usersChoice;
        }

        public void changeSugarCount()
        {
            Console.Clear();
            Console.WriteLine("Enter New Lemon count for Recipe");
            int usersChoice = Convert.ToInt32(Console.ReadLine());
            numOfSugar = usersChoice;
        }

        public void changeIceCount()
        {
            Console.Clear();
            Console.WriteLine("Enter New Lemon count for Recipe");
            int usersChoice = Convert.ToInt32(Console.ReadLine());
            numOfIce = usersChoice;
        }





    }


}
