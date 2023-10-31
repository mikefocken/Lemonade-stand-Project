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
        public Player name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            name = new Player();
        }

        // member methods (CAN DO)
        //   the goal is to ask the player if they want to change their lemonade receipe.
        // make changes

        abstract bool makeChangeToRecipe();
        bool yes = true;

        Console.WriteLine ($"If you would like to change your recipe for a pitcher of Lemondae, please enter yes or no");
                return();

             if/ bool playerWantsToChangeReceipe()
        {

            return true;

        }

       

           
         
        


        
    }

              //  numberOfLemons = 2;
             //  numberOfSugarCubes = 4;
            // numberOfIceCubes = 10;
            // price = 1; 


        
         // Buy supplies= the goal is for the player to buy more supplies 
    
}
