using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        // member variables (HAS A)
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public double price;

        // constructor (SPAWNER)
        public Recipe()
        {
            numberOfLemons = 2;
            numberOfSugarCubes = 4;
            numberOfIceCubes = 10;
            price = 1;
        }
        //Member Methods (CAN DO)
        public void DisplayRecipe()
        {
            Console.WriteLine($"Your recipe currently consists of:\n{numberOfLemons} lemons per pitcher\n{numberOfSugarCubes} sugar cubes per pitcher\n{numberOfIceCubes} ice cubes per pitcher");
        }
        public void ChangeRecipe()
        {
            string yesNO ="yes";
            while (yesNO== "yes")
            {
                DisplayRecipe();
                Console.WriteLine("Select what you would like to change:\n0 for Lemons\n1 for Sugar Cubes\n2 for IceCubes");
                string response= Console.ReadLine();

                if (int.TryParse(response, out int selection) && selection >= 0 && selection <= 2)
                {    
                    Console.WriteLine("How many would you like your recipe to use?");
                    string stringNum = Console.ReadLine();

                    if (response  == "0")
                    {
                        numberOfLemons=int.Parse(stringNum);
                    }
                    else if (response == "1")
                    {
                        numberOfSugarCubes =int.Parse(stringNum);
                    }
                    else if (response == "2")
                    {
                        numberOfIceCubes =int.Parse(stringNum);
                    }
                    Console.WriteLine("Would you like to change something else?");
                    yesNO= Console.ReadLine().ToLower();
                }

            }

        }

        public void ChangePricePerCup()
        {
            string yesNO = "yes";
            while (yesNO== "yes")
            {
                DisplayRecipe();
                Console.WriteLine("What would you like the price for a cup of lemonade to be? Please use a numerical value like example (e.g. .45 or 1.35)");
                string response = Console.ReadLine();

                if (double.TryParse(response, out double newPrice))
                {
                    price= newPrice;
                    Console.WriteLine($"Price updated to {price} per cup of lemonade.");
                }
                else 
                {
                    Console.WriteLine("Invalid input.Please use a numerical value like example (e.g. .45 or 1.35)");
                }
                Console.WriteLine("Would you like to change the price again? enter 'yes' or 'No' ");
                yesNO =Console.ReadLine().ToLower();

            } 

        }


    }
}