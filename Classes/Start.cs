using System;


namespace POE.PROG6221.Classes
{
    //Class that contains the welcome method
    internal class Start
    {
        //Attributes
        public static int choice;
        //Method that displays welcome and asks user if the want to Exit , View Recipe , Add Recipe
        public static void StartMessage()
        {
            // Displays messaging in the command line and asks user for input
            Console.WriteLine("Welcome, Would you like to :");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. View Recipe");
            Console.WriteLine("3. Scale the Recipe");
            Console.WriteLine("4. Clear arrays data");
            Console.WriteLine("5. Exit");

            // Read user input
            string userChoice = Console.ReadLine();

            // Parse user input to an integer
            if (int.TryParse(userChoice, out int parsedChoice))
            {
                // Set the choice attribute based on the parsed user input
                choice = parsedChoice;

                // Call the appropriate method based on the user's choice
                switch (choice)
                {
                    case 1:
                        //Method that starts the Add recipe proccess
                        AddRecipe.StartAddRecipe();
                        break;
                    case 2:
                        //Method that starts the displaying of the recipe
                        DisplayRecipe.Display();

                        StartMessage();
                        break;
                    case 3:
                        //lets user scale the quantities 
                        ScaleRecipe.ScaleQuantities(AddRecipe.NumIngredients);
                        StartMessage();
                        break;
                    case 4:
                        //Clears the arrays data
                        ClearRecipe.ClearArrays();
                        StartMessage();
                        break;
                    case 5:
                        //Exits the program
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                // Inform the user of invalid input
                Console.WriteLine("Invalid input. Please enter a number to choose.");
            }
        }
        // Method to handle exiting the program
        private static void Exit()
        {
            // Add code to handle program exit here
            Console.WriteLine("Exiting the program...");
            Environment.Exit(0);
        }
    }
}
