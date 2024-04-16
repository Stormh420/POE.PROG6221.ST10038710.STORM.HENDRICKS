using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE.PROG6221.Classes
{
    //Class that clears out array
    internal class ClearRecipe
    {
        //Method that clears out the array
        public static void ClearArrays()
        {
            // Clear ingredient arrays
            AddRecipe.RecipeName = null;
            AddRecipe.NumIngredients = 0;
            AddRecipe.IngredientNames = null;
            AddRecipe.IngredientQuantities = null;
            AddRecipe.IngredientUnits = null;

            // Clear step arrays
            AddRecipe.NumSteps = 0;
            AddRecipe.DescriptionStep = null;

            Console.WriteLine("Arrays cleared.");
        }
    }
}
