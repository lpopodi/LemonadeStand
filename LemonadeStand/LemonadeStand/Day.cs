using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    

    public class Day
    {

        Weather weather = new Weather();
        Customer customer = new Customer();
        Random random = new Random();
        public decimal SetPrice = 0.25M;
        public decimal maxPrice;
        public bool willBuy;
        public bool wantToBuy;
        public bool willApproach;
        public int potentialCustomer;
        public int approachingCustomers;
        public int customerBuyYes;
        public int customerBuyNo;
        public List<int> dailyCustomers = new List<int>();
        public List<int> customerApproaching = new List<int>();
        public List<int> customerPurchased = new List<int>();
        public List<int> customerRefused = new List<int>();


        public void startDay()
        {
            Console.Clear();
            weather.SetWeather();
            printWeather();
            Console.ReadLine();
        }

        public void printWeather()
        {
            Console.WriteLine("Today will be a high of " + weather.temperature + " degrees");
            Console.WriteLine("Forecast is " + weather.condition);
        }

        public void setSellingPriceForDay()
        {
            Console.Clear();
            printWeather();
            Console.WriteLine("Your price for each cup of lemonade is $[0.25]: Would you like to change it [Y] or [N]");
            string changeprice = Console.ReadLine().ToUpper();
            if (changeprice.ToUpper() == "Y")
            {
                Console.Write("\nEnter the price you want to charge per cup for today.\n");
                decimal newPriceForToday = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("\nTodays price is ( $ " + (newPriceForToday) + " )");
                SetPrice = newPriceForToday;
                sellLemonade();
            }
            else
            {
                sellLemonade();
            }
        }

        public void GetNumberOfPotentialCustomersByTemp()
        {
            dailyCustomers.Clear();
            if (weather.temperature >= 100)
            {
                potentialCustomer = random.Next(115, 140);
            }
            else if (weather.temperature > 90 && weather.temperature <= 99)
            {
                potentialCustomer = random.Next(100, 115);
            }
            else if (weather.temperature > 80 && weather.temperature <= 90)
            {
                potentialCustomer = random.Next(85, 100);
            }
            else if (weather.temperature > 70 && weather.temperature <= 80)
            {
                potentialCustomer = random.Next(75, 85);
            }
            else if (weather.temperature > 60 && weather.temperature <= 70)
            {
                potentialCustomer = random.Next(75, 85);
            }
            else if (weather.temperature <= 60)
            {
                potentialCustomer = random.Next(20, 30);
            }
            else
            { Console.WriteLine("There was some error calculating potential customers"); Console.ReadLine(); }

            for (int customers = 1; customers <= potentialCustomer; customers++)
            {
                dailyCustomers.Add(1);
            }
            Console.WriteLine("Daily Customers: " + dailyCustomers.Count);
        }

        public int DetermineWillBuyByConditions()
        {
            customerApproaching.Clear();
            foreach (int buyingCust in dailyCustomers)
            {
                int weatherBuy = random.Next(0, 100);
                if (weather.condition == "Sunny")
                {
                    if (weatherBuy < 90)
                    {
                        willApproach = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (weather.condition == "Hazy")
                {
                    if (weatherBuy < 70)
                    {
                        willApproach = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (weather.condition == "Cloudy")
                {
                    if (weatherBuy < 50)
                    {
                        willApproach = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (weather.condition == "Overcast")
                {
                    if (weatherBuy < 30)
                    {
                        willApproach = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }

                if (weather.condition == "Rainy")
                {
                    if (weatherBuy < 15)
                    {

                        willApproach = true;
                        customerApproaching.Add(1);
                    }
                    else
                    {
                        willApproach = false;
                    }
                }
            }

            approachingCustomers = customerApproaching.Count;
            Console.WriteLine("Approaching Customers: " + customerApproaching.Count);
            return approachingCustomers;
        }

        public int DeterminePurchasingCustomers()
        {
            customerPurchased.Clear();
            customerRefused.Clear();
            foreach (int buyingCust in customerApproaching)
            {
                int priceIsRight = random.Next(0, 100);
                if (priceIsRight < 80)
                {
                    willBuy = true;
                    customerPurchased.Add(1);
                }
                else
                {
                    willBuy = false;
                    customerRefused.Add(1);
                }
            }

            customerBuyYes = customerPurchased.Count;
            Console.WriteLine("Customers Purchased: " + customerPurchased.Count);
            return customerBuyYes;

            //customerBuyNo = customerRefused.Count;
            //Console.WriteLine("Customers Refused: " + customerRefused.Count);
            //return customerBuyNo;
        }




        public void sellLemonade()
        {
            GetNumberOfPotentialCustomersByTemp();
            Console.ReadLine();
            DetermineWillBuyByConditions();
            Console.ReadLine();
            DetermineWillingPayPrice();
            DeterminePurchasingCustomers();
            Console.ReadLine();
            DayEndReport();
            Console.ReadLine();
        }

        public void DayEndReport()
        {
            Console.WriteLine("DAY END REPORT");
            Console.WriteLine("Today's High was: " + weather.temperature);
            Console.WriteLine("Today's Weather conditions were: " + weather.condition);
            Console.WriteLine("Total Potential Customers for the day were: " + dailyCustomers.Count);
            Console.WriteLine("Total Customers that approached the stand were: " + customerApproaching.Count);
            Console.WriteLine("Customers Purchased: " + customerPurchased.Count);
         }

        public decimal DetermineWillingPayPrice()
        {
            if (weather.condition == "Sunny" && weather.temperature > 100)
            { maxPrice = 1.50M; }
            else if (weather.condition == "Sunny" && weather.temperature > 85 && weather.temperature <= 100)
            { maxPrice = 1.25M; }
            else if (weather.condition == "Sunny" && weather.temperature > 70 && weather.temperature <= 85)
            { maxPrice = 1.00M; }
            else if (weather.condition == "Sunny" && weather.temperature > 60 && weather.temperature <= 70)
            { maxPrice = .75M; }
            else if (weather.condition == "Sunny" && weather.temperature <= 60)
            { maxPrice = .50M; }
            else if (weather.condition == "Hazy" && weather.temperature > 100)
            { maxPrice = 1.25M; }
            else if (weather.condition == "Hazy" && weather.temperature > 85 && weather.temperature <= 100)
            { maxPrice = 1.00M; }
            else if (weather.condition == "Hazy" && weather.temperature > 70 && weather.temperature <= 85)
            { maxPrice = .75M; }
            else if (weather.condition == "Hazy" && weather.temperature > 60 && weather.temperature <= 70)
            { maxPrice = .50M; }
            else if (weather.condition == "Hazy" && weather.temperature <= 60)
            { maxPrice = .25M; }
            else if (weather.condition == "Cloudy" && weather.temperature > 100)
            { maxPrice = 1.00M; }
            else if (weather.condition == "Cloudy" && weather.temperature > 85 && weather.temperature <= 100)
            { maxPrice = .85M; }
            else if (weather.condition == "Cloudy" && weather.temperature > 65 && weather.temperature <= 85)
            { maxPrice = .60M; }
            else if (weather.condition == "Cloudy" && weather.temperature <= 65)
            { maxPrice = .25M; }
            else if (weather.condition == "Overcast" && weather.temperature > 100)
            { maxPrice = .90M; }
            else if (weather.condition == "Overcast" && weather.temperature > 85 && weather.temperature <= 100)
            { maxPrice = .80M; }
            else if (weather.condition == "Overcast" && weather.temperature > 65 && weather.temperature <= 85)
            { maxPrice = .60M; }
            else if (weather.condition == "Overcast" && weather.temperature <= 65)
            { maxPrice = .25M; }
            else if (weather.condition == "Rainy" && weather.temperature > 90)
            { maxPrice = .50M; }
            else if (weather.condition == "Rainy" && weather.temperature > 70 && weather.temperature <= 90)
            { maxPrice = .35M; }
            else if (weather.condition == "Rainy" && weather.temperature <= 70)
            { maxPrice = .15M; }
            else { maxPrice = 10; }
            Console.WriteLine("Customer max willing price" + maxPrice);
            Console.ReadLine();
            return maxPrice;
        }


    }
}
