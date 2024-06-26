using POE.PROG6221.POE.PROG6221;
using System;
using System.Collections.Generic;

namespace POE.PROG6221
{
    public class MakeMenu
    {
        public List<AddRecipe> Menu { get; set; } = new List<AddRecipe>();

        // Method to display and choose recipes to add to the menu
        public void ChooseRecipesForMenu(List<AddRecipe> recipes)
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes added. Please add a recipe.");
                Start.StartMessage(recipes); // Return to the start menu
                return;
            }

            Console.WriteLine("Available Recipes:");
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].RecipeName}");
            }

            Console.Write("Enter the number of recipes you want to add to the menu: ");
            int numMenuRecipes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numMenuRecipes; i++)
            {
                Console.Write("Enter the number of the recipe to add to the menu: ");
                int recipeChoice = Convert.ToInt32(Console.ReadLine()) - 1;

                if (recipeChoice >= 0 && recipeChoice < recipes.Count)
                {
                    Menu.Add(recipes[recipeChoice]);
                    Console.WriteLine($"{recipes[recipeChoice].RecipeName} has been added to the menu.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid recipe number.");
                    i--; // Decrement the counter to allow for a valid choice
                }
            }

            Console.WriteLine("\nCurrent Menu:");
            foreach (var recipe in Menu)
            {
                Console.WriteLine(recipe.RecipeName);
            }

            Start.StartMessage(recipes); // Return to the start menu
        }
    }
}

