

namespace POE.PROG6221
{
    using global::POE.PROG6221.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace POE.PROG6221
    {
        public class Start
        {
            public static void StartMessage(List<AddRecipe> recipes)
            {
                Console.WriteLine("\nWelcome to the Recipe App!");
                Console.WriteLine("1. Add a new recipe");
                Console.WriteLine("2. Display all recipes");
                Console.WriteLine("3. Display a specific recipe");
                Console.WriteLine("4. Scale a recipe");
                Console.WriteLine("5. Clear all recipes");
                Console.WriteLine("6. Create a menu");
                Console.WriteLine("7. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddRecipe.StartAddRecipe(recipes);
                        break;
                    case 2:
                        DisplayRecipe.Display(recipes);
                        break;
                    case 3:
                        DisplayRecipe.DisplaySpecificRecipe(recipes);
                        break;
                    case 4:
                        Console.Write("Enter the name of the recipe you want to scale: ");
                        string recipeName = Console.ReadLine();
                        var recipe = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeName, StringComparison.OrdinalIgnoreCase));
                        if (recipe != null)
                        {
                            ScaleRecipe.ScaleQuantities(recipe);
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found. Returning to main menu.");
                            StartMessage(recipes);
                        }
                        break;
                    case 5:
                        ClearRecipe.ClearRecipes(recipes);
                        break;
                    case 6:
                        MakeMenu makeMenu = new MakeMenu();
                        makeMenu.ChooseRecipesForMenu(recipes);
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        StartMessage(recipes);
                        break;
                }
            }
        }
    }
}

