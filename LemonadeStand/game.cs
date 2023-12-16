using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        //member variable(has a)
        Player player;
        List<Day> days;
        int currentDay;
        Store store;

        //constructor 
        public Game()
        {
            days=new List<Day>();
            store=new Store();
            player=new Player();

            for (int i=0; i<8; i++)
            {
                Day newDay = new Day();
                days.Add(newDay);
            }
        }

        public void StartGame()
        {
            foreach (Day day in days)
            {
                // Display weather forecast for the day
                Console.WriteLine($"Weather Forecast for Day {day.DayNumber}:");
                DisplayWeatherForecast(day.DailyWeather);

                // Display weekly weather forecast
                Console.WriteLine("\nWeekly Weather Forecast:");
                DisplayWeeklyWeatherForecast(day.WeeklyForecast);

                // Display player's current inventory
                Console.WriteLine("\nPlayer's Current Inventory:");
                DisplayPlayerInventory(player);

                // Other actions for the day...

                // Simulate customers walking by
                int cupsSold = day.SimulatingCustomersWalkingBy(player.LemonadePrice);

                // Display totals for the day
                Console.WriteLine($"\nDay {day.DayNumber} Totals:");
                Console.WriteLine($"Cups Sold: {cupsSold}");
                Console.WriteLine("Inventory Used:");
                DisplayInventoryUsed(day.InventoryUsed);
                Console.WriteLine($"Money Earned: ${cupsSold * player.LemonadePrice}");

                // Pause for user input or wait for a specific time before proceeding to the next day
                Console.WriteLine("\nPress Enter to continue to the next day...");
                Console.ReadLine();
            }
        }


       



    }

}
