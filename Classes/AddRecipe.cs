using POE.PROG6221.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE.PROG6221
{
    //class the handles the adding a recipe 
    public class AddRecipe
    {
        // Attributes for AddRecipe class
        public static string RecipeName { get; set; } // Recipe name
        public static int NumIngredients { get; set; } // Number of ingredients
        public static string[] IngredientNames { get; set; } // Array to store ingredient names
        public static int[] IngredientQuantities { get; set; } // Array to store ingredient quantities
        public static string[] IngredientUnits { get; set; } // Array to store ingredient units

        public static int NumSteps { get; set; }//Number of steps
        public static string[] DescriptionStep { get; set; }//Array to store step description

        // Method that starts the process of adding a recipe
        public static void StartAddRecipe()
        {
            Console.WriteLine("Enter details for the recipe:");

            // Prompt the user for the recipe name
            Console.Write("Recipe Name: ");
            RecipeName = Console.ReadLine();

            // Prompt the user for the number of ingredients
            Console.Write("Number of Ingredients: ");
            NumIngredients = Convert.ToInt32(Console.ReadLine());

            // Initialize arrays to store ingredient details
            IngredientNames = new string[NumIngredients];
            IngredientQuantities = new int[NumIngredients];
            IngredientUnits = new string[NumIngredients];

            // Loop to input details for each ingredient
            for (int i = 0; i < NumIngredients; i++)
            {
                Console.WriteLine($"\nEnter details for Ingredient {i + 1}:");
                Console.Write("Name: ");
                IngredientNames[i] = Console.ReadLine();

                Console.Write("Quantity: ");
                IngredientQuantities[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Unit: ");
                IngredientUnits[i] = Console.ReadLine();
            }

            // Prompt the user for the number of steps
            Console.Write("Number of Steps: "); // Fixed prompt message
            NumSteps = Convert.ToInt32(Console.ReadLine());

            // Initialize array to store step details
            DescriptionStep = new string[NumSteps];

            // Loop to input steps
            for (int i = 0; i < NumSteps; i++)
            {
                Console.WriteLine($"\n Step {i + 1}:");
                DescriptionStep[i] = Console.ReadLine();
            }

            //Call start method so user can choose to view the recipe
            Start.StartMessage();


        }
    }
}
