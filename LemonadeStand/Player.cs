using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
        public string name;
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
        public void MakeChangeToRecipe()
        {
            recipe.DisplayRecipe();
            Console.WriteLine($"If your would like to change your receipe for a pitcher of Lemonade, please enter a yes or no.");
            string yesNo = Console.ReadLine();
            while (yesNo !="yes" || yesNo !="no")
            {
                Console.WriteLine($"{yesNo} was not a valid selection, please enter a yes or no.");
                yesNo = Console.ReadLine().ToLower();
            }
            if (yesNo == "yes")
            {
                recipe.ChangeRecipe();
            }
      
        }

        public void MakeChangePricePerCup()
        {
            recipe.DisplayRecipe();
            Console.WriteLine($"If you would like to change the price you are charging for a cup a lemonade please enter 'yes' or 'no'");
            string yesNo = Console.ReadLine().ToLower();

            while ( yesNo !="yes" || yesNo !="no")
            {
                Console.WriteLine($"{yesNo} was not a valid selection, please enter a yes or no.");
                yesNo = Console.ReadLine().ToLower();

            }
            if (yesNo == "yes")
            {
                recipe.ChangePricePerCup();
            }

        }

    }

}      
         
        


        
    



      
    

