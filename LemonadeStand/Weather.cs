using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {

        //member variable(has a)
         List<string> weatherConditions;
        string predictForecast;
        Random random;
        public int Temperature { get; private set; }
        public string Condition { get; private set; }




        //constructor

        public Weather()
        {
            weatherConditions =  new List<string> { "Sunny", "Cloudy", "Rainy" };
            random = new Random();

        }
        // Member methods(Can do)

        public void DetermineWeather()
        {
            //Give a value to conditions and temperature member variables
            //Use Random to assign a random number to temperature and random item from list to condition
            //temperature = random number between 60-100
            //condition = random item from list
            Temperature = random.Next(60, 100);
            int randomIndex = random.Next(weatherConditions.Count);
            Condition = weatherConditions[randomIndex];

            //return (Day);
        }

    }
    internal class WeatherForecastGenerator
    {
        public Weather GenerateRandomWeather()
        {
            return new Weather();
        }

        public Weather[] GenerateWeeklyWeatherForecast()
        {
            Weather[] weeklyForecast = new Weather[7];

            for (int i = 0; i < 7; i++)
            {
                weeklyForecast[i] = GenerateRandomWeather();
            }

            return weeklyForecast;
        }

        public void DisplayWeatherForecast(Weather weather)
        {
            Console.WriteLine($"Today's Weather: Temperature {weather.Temperature}°C, {weather.Condition}");
        }

        public void DisplayWeeklyWeatherForecast(Weather[] forecast)
        {
            foreach (var entry in forecast)
            {
                Console.WriteLine($"Day: Temperature {entry.Temperature}°C, {entry.Condition}");
            }
        }
    }

}

  
    





    

    





