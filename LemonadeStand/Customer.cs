using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LemonadeStand
{
    internal class Customer
    { 
        double willingnessToPay;                         //member variable(has a)

        public Customer()
        {
            Random rand = new Random();                  //constructor
            willingnessToPay=rand.Next(18, 120)/100.0;
        }

        public bool WillBuyLemonade (double price)
        {
            return willingnessToPay >= price;
        }


       



    }
}
