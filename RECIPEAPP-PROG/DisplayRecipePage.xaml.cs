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
    /// Interaction logic for DisplayRecipePage.xaml
    /// </summary>
    public partial class DisplayRecipePage : Page
    {
        public DisplayRecipePage()
        {
            InitializeComponent();
            foreach (var recipe in MainWindow.Recipes.Values)
            {
                RecipeSelector.Items.Add(recipe.Name);
            }
        }

        private void RecipeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RecipeSelector.SelectedIndex > 0)
            {
                string selectedRecipeName = RecipeSelector.SelectedItem.ToString();
                if (MainWindow.Recipes.TryGetValue(selectedRecipeName, out Recipe recipe))
                {
                    RecipeDetailsTextBlock.Text = $"Name: {recipe.Name}\n\n" +
                        $"Number of Ingredients: {recipe.NumberOfIngredients}\n" +
                        $"Ingredients: {string.Join(", ", recipe.Ingredients)}\n\n" +
                        $"Number of Steps: {recipe.NumberOfSteps}\n" +
                        $"Steps:\n{string.Join("\n", recipe.Steps)}";
                }
            }
        }
    }
}
