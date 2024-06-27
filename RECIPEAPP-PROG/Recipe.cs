using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECIPEAPP_PROG
{
    public class Recipe
    {
        public string Name { get; set; }
        public int NumberOfIngredients { get; set; }
        public List<string> Ingredients { get; set; }
        public int NumberOfSteps { get; set; }
        public List<string> Steps { get; set; }
        public List<double> Quantities { get; set; }
        public bool IsScaled { get; set; } = false;

        public Recipe(string name, int numberOfIngredients, int numberOfSteps)
        {
            Name = name;
            NumberOfIngredients = numberOfIngredients;
            Ingredients = new List<string>();
            Quantities = new List<double>();
            NumberOfSteps = numberOfSteps;
            Steps = new List<string>();
        }

        public void Scale(double factor)
        {
            for (int i = 0; i < Quantities.Count; i++)
            {
                Quantities[i] *= factor;
            }
            IsScaled = true;
        }

        public void Revert()
        {
            // Assuming quantities were initially stored in some base state
            IsScaled = false;
        }
    }
}
