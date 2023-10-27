using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {

        //member variable(has a)
        string condition;
        int temperature;
        List<string> weatherConditions;
        string predictForecast;
        Random random;


        //constructor

        public Weather()
        {
            weatherConditions =  new List<string> { "Sunny", "Cloudy", "Rainy", "overcast"};
          
            random = new Random();
        }

        // Member methods(Can do)
       
        public void DetermineWeather()
        {
            //Give a value to conditions and temperature member variables
            //Use Random to assign a random number to temperature and random item from list to condition

            //temperature = random number between 60-100
            //condition = random item from list
            temperature = random.Next ( 60, 100);
            int randomIndex = random.Next(weatherConditions.Count);
            condition=weatherConditions[randomIndex];
           
        }

           



        


    }

 }   
