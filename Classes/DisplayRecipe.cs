using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE.PROG6221.Classes
{
    //Class that displays the recipe
    internal class DisplayRecipe
    {
        // Method to display recipe details
        public static void Display()
        {
            Console.WriteLine("\nRecipe Details:");
            Console.WriteLine($"Name: {AddRecipe.RecipeName}");

            // Display ingredients
            Console.WriteLine("\nIngredients:");
            for (int i = 0; i < AddRecipe.NumIngredients; i++)
            {
                Console.WriteLine($"{AddRecipe.IngredientNames[i]} - {AddRecipe.IngredientQuantities[i]} {AddRecipe.IngredientUnits[i]}");
            }

            // Display steps
            Console.WriteLine("\nSteps:");
            for (int i = 0; i < AddRecipe.NumSteps; i++)
            {
                Console.WriteLine($"{i + 1}. {AddRecipe.DescriptionStep[i]}");
            }

           
        }
    }
}

