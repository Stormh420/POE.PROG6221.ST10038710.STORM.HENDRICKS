using System;
using System.Collections.Generic;


namespace POE.PROG6221.Classes
{
    // Class that clears out the recipes
    internal class ClearRecipe
    {
        // Method that clears out the recipe list
        public static void ClearRecipes(List<AddRecipe> recipes)
        {
            recipes.Clear();
            Console.WriteLine("All recipes cleared.");
        }
    }
}

