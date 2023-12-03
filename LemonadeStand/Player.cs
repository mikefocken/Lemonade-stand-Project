using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public String name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            name = "Mike";
        }

        // member methods (CAN DO)
        public bool MakeChangeToRecipe()
        {
            bool changeRecipe = true;
            Console.WriteLine($"If your would like to change your receipe for a pitcher of Lemonade, please enter a yes or no.");
            string yesNo = Console.ReadLine();
            while (yesNo !="yes" || yesNo !="no")
            {
                Console.WriteLine($"{yesNo} was not a valid selection, please enter a yes or no.");
                yesNo = Console.ReadLine().ToLower();
            }
            if (yesNo == "yes")
            {
                changeRecipe = true;
            }
            return changeRecipe;

        }


    }

}      
         
        


        
    

              //  numberOfLemons = 2;
             //  numberOfSugarCubes = 4;
            // numberOfIceCubes = 10;
            // price = 1; 


        
         // Buy supplies= the goal is for the player to buy more supplies 
    

