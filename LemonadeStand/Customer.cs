using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LemonadeStand
{
    internal class Customer
    { 
        double willingnessToPay;
        int probabilityToPurchase;
        Random rand;
        //member variable(has a)

        public Customer()
        {
            rand = new Random();                  //constructor
            willingnessToPay=rand.Next(18, 120)/100.0;
            probabilityToPurchase=0;
        }

        public bool WillBuyLemonade (double price, string weatherCondition, int weatherTemp)
        {
            //goal is to call conditional weather and price methods AND determine if customer will buy
            ChancesOfPurchaseWeather(weatherCondition, weatherTemp);
            ChancesOfPurchasePrice(price);

            if (probabilityToPurchase < 25)
            {
                return false;
            }
            else if (probabilityToPurchase < 75)
            {
                int index = rand.Next(2);
                bool[] trueFalse = new bool[] { true, false };
                return trueFalse[index];
            }
            else
            {
                return true;
            }
        }
        public void ChancesOfPurchaseWeather(string weatherCondition, int weatherTemp)
        {
            // Goals: to increase or decrease the chances of customer buying lemonade based on the weather condition and temperature.
            if (weatherCondition=="Sunny")
            {
                probabilityToPurchase += 55;
            }

            if (weatherCondition== "Cloudy")
            {
                probabilityToPurchase += 30;

            }
            if (weatherCondition== "Rainy")
            {
                probabilityToPurchase += 15;
            }
            if (weatherTemp >79 && weatherTemp <100)
            {
                probabilityToPurchase += 55;
            }            
            if (weatherTemp  < 79 &&  weatherTemp >69)
            {
                probabilityToPurchase += 30;
            }
            if (weatherTemp <70 && weatherTemp > 59)
            {
                probabilityToPurchase += 15;
            }

        }
        public void ChancesOfPurchasePrice(double price)
        {
            // goal to increase or decrease the chance of customer buying lemonade based on the price.
            if (price>willingnessToPay)     
            {
                probabilityToPurchase=0;
            }
            else
            {
                probabilityToPurchase+= 15;
            }
        }
    }
}


// this is how to make notes in C# code
// chances of purchase algorithm
// willingnessToPay - true or false returned
// probabilityOfPaying - integer (representing percentage)
// should be affected by both price and weather

// needs slightly more added - probabilityOfPaying needs to be compared, then bool returned
// three methods one handling the price, one handling the weather, third handling the bool return
// price method - zero out the probabilityOfPaying if above willingNessToPay, if below add a percentage to probabilityOfPaying
// weather method - if sunny add percentage, if cloudy add percentage, if rainy add percentage
// based on temp add percentage

