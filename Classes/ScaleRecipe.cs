using System;
using System.Collections.Generic;

namespace POE.PROG6221.Classes
{
    // Class that scales the ingredients quantities
    internal class ScaleRecipe
    {
        // Method that scales the ingredients quantities
        public static void ScaleQuantities(AddRecipe recipe)
        {
            // Store the original quantities before scaling
            int[] originalQuantities = new int[recipe.NumIngredients];
            Array.Copy(recipe.IngredientQuantities, originalQuantities, recipe.NumIngredients);

            Console.WriteLine("Choose a scaling factor:");
            Console.WriteLine("1. 0.5");
            Console.WriteLine("2. 2");
            Console.WriteLine("3. 3");

            // Prompt the user to choose a scaling factor
            int choice = Convert.ToInt32(Console.ReadLine());
            double scaleFactor;

            // Determine the scaling factor based on the user's choice
            switch (choice)
            {
                case 1:
                    scaleFactor = 0.5;
                    break;
                case 2:
                    scaleFactor = 2;
                    break;
                case 3:
                    scaleFactor = 3;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Quantities will not be scaled.");
                    return;
            }

            // Scale each ingredient quantity
            for (int i = 0; i < recipe.NumIngredients; i++)
            {
                recipe.IngredientQuantities[i] = (int)(recipe.IngredientQuantities[i] * scaleFactor);
            }

            Console.WriteLine($"Quantities scaled by a factor of {scaleFactor}");

            // Display the recipe with scaled quantities
            DisplayRecipe.Display(new List<AddRecipe> { recipe });

            // Ask the user if they want to keep the scaled quantities or revert them back
            Console.WriteLine("Do you want to keep the scaled quantities? (Y/N)");
            string userInput = Console.ReadLine();
            if (userInput.ToUpper() != "Y")
            {
                // Revert back to the original quantities
                for (int i = 0; i < recipe.NumIngredients; i++)
                {
                    recipe.IngredientQuantities[i] = originalQuantities[i];
                }
                Console.WriteLine("Quantities reverted back to their original values.");
                // Display the recipe with reverted quantities
                DisplayRecipe.Display(new List<AddRecipe> { recipe });
            }
        }
    }
}


