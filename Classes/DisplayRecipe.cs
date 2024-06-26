using POE.PROG6221.POE.PROG6221;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POE.PROG6221.Classes
{
    // Class that displays all the recipes
    internal class DisplayRecipe
    {
        // Method to display recipe details
        public static void Display(List<AddRecipe> recipes)
        {
            // Sort the recipes by name
            var sortedRecipes = recipes.OrderBy(r => r.RecipeName).ToList();

            Console.WriteLine("\nRecipes in Alphabetical Order:");

            // Display each recipe
            foreach (var recipe in sortedRecipes)
            {
                Console.WriteLine($"\nRecipe Name: {recipe.RecipeName}");
                Console.WriteLine("Ingredients:");
                for (int i = 0; i < recipe.NumIngredients; i++)
                {
                    Console.WriteLine($"{recipe.IngredientNames[i]} - {recipe.IngredientQuantities[i]} {recipe.IngredientUnits[i]} ({recipe.IngredientCalories[i]} calories, {recipe.IngredientFoodGroups[i]})");
                }
                Console.WriteLine("Steps:");
                for (int i = 0; i < recipe.NumSteps; i++)
                {
                    Console.WriteLine($"{i + 1}. {recipe.DescriptionStep[i]}");
                }
                Console.WriteLine($"Total Calories: {recipe.TotalCalories}");
            }
        }

        // Method to display a specific recipe
        public static void DisplaySpecificRecipe(List<AddRecipe> recipes)
        {
            // Sort the recipes by name
            var sortedRecipes = recipes.OrderBy(r => r.RecipeName).ToList();

            Console.WriteLine("\nRecipes in Alphabetical Order:");

            // Display recipe names
            for (int i = 0; i < sortedRecipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sortedRecipes[i].RecipeName}");
            }

            Console.Write("\nEnter the number of the recipe you want to view: ");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (choice >= 0 && choice < sortedRecipes.Count)
            {
                var recipe = sortedRecipes[choice];
                Console.WriteLine($"\nRecipe Name: {recipe.RecipeName}");
                Console.WriteLine("Ingredients:");
                for (int i = 0; i < recipe.NumIngredients; i++)
                {
                    Console.WriteLine($"{recipe.IngredientNames[i]} - {recipe.IngredientQuantities[i]} {recipe.IngredientUnits[i]} ({recipe.IngredientCalories[i]} calories, {recipe.IngredientFoodGroups[i]})");
                }
                Console.WriteLine("Steps:");
                for (int i = 0; i < recipe.NumSteps; i++)
                {
                    Console.WriteLine($"{i + 1}. {recipe.DescriptionStep[i]}");
                }
                Console.WriteLine($"Total Calories: {recipe.TotalCalories}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Returning to the main menu.");
            }

            // Takes user back to main menu
            Start.StartMessage(recipes);
        }
    }
}



