using POE.PROG6221.POE.PROG6221;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POE.PROG6221
{
    public class AddRecipe
    {
        // Attributes for AddRecipe class
        public string RecipeName { get; set; } // Recipe name
        public int NumIngredients { get; set; } // Number of ingredients
        public string[] IngredientNames { get; set; } // Array to store ingredient names
        public int[] IngredientQuantities { get; set; } // Array to store ingredient quantities
        public string[] IngredientUnits { get; set; } // Array to store ingredient units
        public int[] IngredientCalories { get; set; } // Array to store ingredient calories
        public string[] IngredientFoodGroups { get; set; } // Array to store ingredient food groups
        public int NumSteps { get; set; } // Number of steps
        public string[] DescriptionStep { get; set; } // Array to store step description
        public int TotalCalories { get; set; } // Total calories of the recipe

        // Main food groups
        private static readonly string[] FoodGroups = new string[]
        {
            "Fruits",
            "Vegetables",
            "Grains",
            "Protein Foods",
            "Dairy"
        };

        // Method that starts the process of adding recipes
        public static void StartAddRecipe(List<AddRecipe> recipes)
        {
            // Prompt user to enter how many recipes they want to add
            Console.Write("Enter the number of recipes you want to add: ");
            int numRecipes = Convert.ToInt32(Console.ReadLine());

            for (int r = 0; r < numRecipes; r++)
            {
                Console.WriteLine($"\nAdding Recipe {r + 1}:");
                AddRecipe recipe = new AddRecipe();

                // Prompt the user for the recipe name
                Console.Write("Recipe Name: ");
                recipe.RecipeName = Console.ReadLine();

                // Prompt the user for the number of ingredients
                Console.Write("Number of Ingredients: ");
                recipe.NumIngredients = Convert.ToInt32(Console.ReadLine());

                // Initialize arrays to store ingredient details
                recipe.IngredientNames = new string[recipe.NumIngredients];
                recipe.IngredientQuantities = new int[recipe.NumIngredients];
                recipe.IngredientUnits = new string[recipe.NumIngredients];
                recipe.IngredientCalories = new int[recipe.NumIngredients];
                recipe.IngredientFoodGroups = new string[recipe.NumIngredients];

                // Loop to input details for each ingredient
                for (int i = 0; i < recipe.NumIngredients; i++)
                {
                    Console.WriteLine($"\nEnter details for Ingredient {i + 1}:");
                    Console.Write("Name: ");
                    recipe.IngredientNames[i] = Console.ReadLine();

                    Console.Write("Quantity: ");
                    recipe.IngredientQuantities[i] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Unit: ");
                    recipe.IngredientUnits[i] = Console.ReadLine();

                    Console.Write("Calories: ");
                    recipe.IngredientCalories[i] = Convert.ToInt32(Console.ReadLine());

                    // Loop until a valid food group is selected
                    bool validChoice = false;
                    while (!validChoice)
                    {
                        // Display food group options
                        Console.WriteLine("Food Group Options:");
                        for (int j = 0; j < FoodGroups.Length; j++)
                        {
                            Console.WriteLine($"{j + 1}. {FoodGroups[j]}");
                        }

                        Console.Write("Select Food Group (enter the number): ");
                        int foodGroupChoice = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (foodGroupChoice >= 0 && foodGroupChoice < FoodGroups.Length)
                        {
                            recipe.IngredientFoodGroups[i] = FoodGroups[foodGroupChoice];
                            validChoice = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please select a valid food group.");
                        }
                    }
                }

                // Calculate total calories
                recipe.TotalCalories = recipe.IngredientCalories.Sum();

                // Notify if total calories exceed 300
                if (recipe.TotalCalories > 300)
                {
                    Console.WriteLine("Warning: The total calories of this recipe exceed 300!");
                }

                // Prompt the user for the number of steps
                Console.Write("Number of Steps: ");
                recipe.NumSteps = Convert.ToInt32(Console.ReadLine());

                // Initialize array to store step details
                recipe.DescriptionStep = new string[recipe.NumSteps];

                // Loop to input steps
                for (int i = 0; i < recipe.NumSteps; i++)
                {
                    Console.WriteLine($"\nStep {i + 1}:");
                    recipe.DescriptionStep[i] = Console.ReadLine();
                }

                // Store the recipe in the list
                recipes.Add(recipe);
            }

            // Takes user back to main menu
            Start.StartMessage(recipes);
        }
    }
}







