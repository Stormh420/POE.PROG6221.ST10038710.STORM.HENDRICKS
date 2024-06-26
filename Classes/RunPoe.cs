using POE.PROG6221.POE.PROG6221;
using System;
using System.Collections.Generic;

namespace POE.PROG6221
{
    internal class RunPoe
    {
        static void Main()
        {
            List<AddRecipe> recipes = new List<AddRecipe>();
            Start.StartMessage(recipes);
        }
    }
}

