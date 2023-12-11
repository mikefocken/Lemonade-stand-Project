using System;
using System.Collections.Generic;
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
        
        public void Startgame()
        {
            foreach( Day day in days)
            {

            }

        }

                              ///member method (Can do)
            
                       

    }

}
