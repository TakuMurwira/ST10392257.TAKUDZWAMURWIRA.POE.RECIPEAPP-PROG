using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RECIPEAPP_PROG
{
    /// <summary>
    /// Interaction logic for EnterRecipePage.xaml
    /// </summary>
    public partial class EnterRecipePage : Page
    {
        private List<Ingredient> ingredients = new List<Ingredient>();
        private List<string> steps = new List<string>();
        private int ingredientCount = 0;
        private int stepCount = 0;
        private int totalIngredients;
        private int totalSteps;

        public EnterRecipePage(string recipeName, int totalIngredients, int totalSteps)
        {
            InitializeComponent();
            this.totalIngredients = totalIngredients;
            this.totalSteps = totalSteps;

            // Optionally, you can set the recipe name in a label or text block
            // recipeNameLabel.Content = $"Enter Details for {recipeName}";
        }

        // Rest of your code remains the same
        // AddIngredientBtn_Click, AddStepBtn_Click, etc.
    }

    public class Ingredient
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public string FoodGroup { get; set; }
        public decimal Calories { get; set; }
    }

}
