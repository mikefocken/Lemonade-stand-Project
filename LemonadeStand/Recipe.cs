using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            bool condition = true;
            while (condition)
            {
                DisplayRecipe();
                Console.WriteLine("Select what you would like to change:\n0 for Lemons\n1 for Sugar Cubes\n2 for IceCubes\n3 for Price");
                string response= Console.ReadLine();
                if (reponse == ""
                {

                }
            }

        }

    }
}