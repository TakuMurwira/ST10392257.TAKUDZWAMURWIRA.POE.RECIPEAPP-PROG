using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddRecipePage.xaml
    /// </summary>
    public partial class AddRecipePage : Page
    {
        private Recipe _currentRecipe;

        public AddRecipePage()
        {
            InitializeComponent();
            
        }

        private void UpButton_Click1(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(NumericTextBox1.Text);
            NumericTextBox1.Text = (++value).ToString();
        }

        private void DownButton_Click1(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(NumericTextBox1.Text);
            if (value > 0)
                NumericTextBox1.Text = (--value).ToString();
        }

        private void NumericTextBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextNumeric(e.Text);
        }

        private void UpButton_Click2(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(NumericTextBox2.Text);
            NumericTextBox2.Text = (++value).ToString();
        }

        private void DownButton_Click2(object sender, RoutedEventArgs e)
        {
            int value = int.Parse(NumericTextBox2.Text);
            if (value > 0)
                NumericTextBox2.Text = (--value).ToString();
        }

        private void NumericTextBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextNumeric(e.Text);
        }

        private bool IsTextNumeric(string str)
        {
            Regex regex = new Regex("[^0-9]+"); //regex that matches disallowed text
            return !regex.IsMatch(str);
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            string recipeName = RecipeNameTextBox.Text;
            int numIngredients = int.Parse(NumericTextBox1.Text);
            int numSteps = int.Parse(NumericTextBox2.Text);

            _currentRecipe = new Recipe(recipeName, numIngredients, numSteps);

            // Dummy data to simulate adding steps and ingredients
            for (int i = 1; i <= numIngredients; i++)
            {
                _currentRecipe.Ingredients.Add($"Ingredient {i}");
                _currentRecipe.Quantities.Add(i);
            }
            for (int i = 1; i <= numSteps; i++)
            {
                _currentRecipe.Steps.Add($"Step {i}");
            }

            MainWindow.Recipes[_currentRecipe.Name] = _currentRecipe;

            MessageBox.Show("All steps and ingredients have been added. Returning to the main window.");

            // Navigate back to the main window
            this.NavigationService.Navigate(new MainWindow());
        }
    }
}
