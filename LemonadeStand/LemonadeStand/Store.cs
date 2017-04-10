using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{


    public class Store
    {
        UserInterface ui;
        private bool restock = true;
        public decimal singleIceCube = .0075M, singleLemon = .075M, singleCupOfSugar = .075M, singlePaperCup = .0075M;
        public decimal ice100Unit = 1.00M, ice250Unit = 2.25M, ice500Unit = 3.50M;
        public decimal lemons10Unit = .75M, lemons25Unit = 1.75M, lemons75Unit = 3.00M;
        public decimal cups50Unit = 1.00M, cups100Unit = 1.75M, cups250Unit = 2.75M;
        public decimal sugar10Unit = .75M, sugar30Unit = 2.00M, sugar75Unit = 4.50M;

        public Store()
        {
            ui = new UserInterface();
        }


        public void showStoreMenu(Player player)
        {
            do
            {
                ui.StoreMenuInstruct();
                string storeChoice = Console.ReadLine().ToUpper();
                if (storeChoice == "C")
                {
                    buyMoreCups(player);
                }
                else if (storeChoice == "L")
                {
                    buyMoreLemons(player);
                }
                else if (storeChoice == "S")
                {
                    buyMoreSugar(player);
                }
                else if (storeChoice == "I")
                {
                    buyMoreIce(player);
                }
                else if (storeChoice == "E")
                {
                    Console.WriteLine("Thank you for purchasing your stock from us today, Good Luck on Lemonade sales!");
                    Console.WriteLine("Enter to continue");
                    Console.ReadLine();
                    restock = false;
                }
                else
                {
                    Console.WriteLine("Plase choose on of the options");
                    Console.ReadLine();
                    showStoreMenu(player);
                } 
            } while (restock == true);
        }

            public void buyMoreCups(Player player)
            {
            Console.Clear();
            Console.WriteLine("You have $" + (player.cashbox.cashboxBalance) + " in your cashbox.\n\n");
            ui.CupPurchaseInfo();
            string usersChoice = Console.ReadLine();
            switch (usersChoice)
            {
                case "1":
                    for (int i = 0; i < 50; i++)
                    {
                        player.inventory.paperCupList.Add(new Cups());
                    }
                    player.cashbox.cashboxBalance -= cups50Unit;
                    break;
                case "2":
                    for (int i = 0; i < 100; i++)
                    {
                        player.inventory.paperCupList.Add(new Cups());
                    }
                    player.cashbox.cashboxBalance -= cups100Unit;
                    break;
                case "3":
                    for (int i = 0; i < 250; i++)
                    {
                        player.inventory.paperCupList.Add(new Cups());
                    }
                    player.cashbox.cashboxBalance -= cups250Unit;

                    break;
                case "E":
                    Console.WriteLine("You have chosen not to purchase after all, hope you have enough supplies!");
                    break;
            }
            player.inventory.inventoryReport();
            Console.WriteLine("\nThis is your new cashbox balance " + (player.cashbox.cashboxBalance));
            showStoreMenu(player);
        }

        public void buyMoreLemons(Player player)
        {
            Console.Clear();
            Console.WriteLine("You have $" + (player.cashbox.cashboxBalance) + " in your cashbox.\n\n");
            ui.LemonPurchaseInfo();
            string usersChoice = Console.ReadLine();
            switch (usersChoice)
            {
                case "1":
                    for (int i = 0; i < 10; i++)
                    {
                        player.inventory.lemonsList.Add(new Lemons());
                    }
                    player.cashbox.cashboxBalance -= lemons10Unit;
                    break;
                case "2":
                    for (int i = 0; i < 25; i++)
                    {
                        player.inventory.lemonsList.Add(new Lemons());
                    }
                    player.cashbox.cashboxBalance -= lemons25Unit;
                    break;
                case "3":
                    for (int i = 0; i < 75; i++)
                    {
                        player.inventory.lemonsList.Add(new Lemons());
                    }
                    player.cashbox.cashboxBalance -= lemons75Unit;

                    break;
                case "E":
                    Console.WriteLine("You have chosen not to purchase after all, hope you have enough supplies!");
                    break;
            }
            player.inventory.inventoryReport();
            Console.WriteLine("\nThis is your new cashbox balance " + (player.cashbox.cashboxBalance));
            showStoreMenu(player);
        }

        public void buyMoreSugar(Player player)
        {
            Console.Clear();
            ui.SugarPurchaseInfo();
            string usersChoice = Console.ReadLine();
            if (usersChoice == "1")
            {
                for (int i = 0; i < 10; i++)
                {
                    player.inventory.sugarList.Add(new Sugar());
                }
                player.cashbox.cashboxBalance -= sugar10Unit;
            }
            else if (usersChoice == "2")
            {
                for (int i = 0; i < 30; i++)
                {
                    player.inventory.sugarList.Add(new Sugar());
                }
                player.cashbox.cashboxBalance -= sugar30Unit;
            }
            else if (usersChoice == "3")
            {
                for (int i = 0; i < 75; i++)
                {
                    player.inventory.sugarList.Add(new Sugar());
                }
                player.cashbox.cashboxBalance -= sugar75Unit;
            }
            player.inventory.inventoryReport();
            Console.WriteLine("\n\nThis is your new balance " + (player.cashbox.cashboxBalance));
            showStoreMenu(player);
        }

        public void buyMoreIce(Player player)
        {
            Console.Clear();
            ui.IcePurchaseInfo();
            string usersChoice = Console.ReadLine();
            if (usersChoice == "1")
            {
                for (int i = 0; i < 100; i++)
                {
                    player.inventory.iceList.Add(new Ice());
                }
                player.cashbox.cashboxBalance -= ice100Unit;
            }
            else if (usersChoice == "2")
            {
                for (int i = 0; i < 250; i++)
                {
                    player.inventory.iceList.Add(new Ice());
                }
                player.cashbox.cashboxBalance -= ice250Unit;
            }
            else if (usersChoice == "3")
            {
                for (int i = 0; i < 500; i++)
                {
                    player.inventory.iceList.Add(new Ice());
                }
                player.cashbox.cashboxBalance -= ice500Unit;
            }
            player.inventory.inventoryReport();
            Console.WriteLine("\n\nThis is your new balance " + (player.cashbox.cashboxBalance));
            showStoreMenu(player);
        }

        


    }

}
