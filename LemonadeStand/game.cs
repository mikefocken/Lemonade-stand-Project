using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class game
    {
        //member variable(has a)
        Player player;
        List<Day> days;
        int currentDay;


        //constructor 
        public game()
        {
            days=new List<Day>();

            Day day1 = new Day();
            days.Add(day1);
            Day day2 = new Day();
            days.Add(day2);

            player=new Player();
        }

        


        //member variables (Can do)


    }
    
}
