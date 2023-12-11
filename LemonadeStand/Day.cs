using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        Weather weather;                                             // member variables
        public List<Customer> customers;

        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            weather.DetermineWeather();
        }
        //public void StartDay();


        public void CreateCustomers(int numberOfCustomers)
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                customers.Add(new Customer());
            }
        }

        public int SimulatingCustomersWalkingBy(double lemonadePrice)
        {
            int customersWhoBought = 0;
            foreach (Customer customer in customers)
            {
                if (customer.WillBuyLemonade(lemonadePrice, weather.condition,weather.temperature))
                {
                    Console.WriteLine("A customer bought Lemonade.");
                    customersWhoBought++;
                }

                else
                {
                    Console.WriteLine("A customer walked away.");
                }

            }
            return customersWhoBought;
        }

    }
}
