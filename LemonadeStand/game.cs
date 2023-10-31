using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
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
            Day day3 = new Day();
            days.Add(day3);
            Day day4 = new Day();
            days.Add(day4);
            Day day5 = new Day();
            days.Add(day5);
            Day day6 = new Day();
            days.Add(day6);
            Day day7 = new Day();
            days.Add(day7);

            player=new Player();

            for (int i = 0; i < 8;i++)
            {
                Console.WriteLine($"Hello here is todays forecast (new Day) Value of i {i}");
            }


            



        }
        
        
                              ///member method (Can do)
            
                       

    }

}
