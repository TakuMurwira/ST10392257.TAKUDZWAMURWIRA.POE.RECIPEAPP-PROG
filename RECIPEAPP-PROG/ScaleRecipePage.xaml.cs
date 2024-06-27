
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
    /// Interaction logic for ScaleRecipePage.xaml
    /// </summary>
    public partial class ScaleRecipePage : Page
    {
        public ScaleRecipePage()
        {
            InitializeComponent();
            foreach (var recipe in MainWindow.Recipes.Values)
            {
                RecipeSelector.Items.Add(recipe.Name);
            }
        }

        private void ScaleButton_Click(object sender, RoutedEventArgs e)
        {
            if (RecipeSelector.SelectedIndex >= 0 && ScaleFactorSelector.SelectedIndex >= 0)
            {
                string selectedRecipeName = RecipeSelector.SelectedItem.ToString();
                double scaleFactor = double.Parse(((ComboBoxItem)ScaleFactorSelector.SelectedItem).Content.ToString());

                if (MainWindow.Recipes.TryGetValue(selectedRecipeName, out Recipe recipe))
                {
                    recipe.Scale(scaleFactor);
                    MessageBox.Show($"Recipe {selectedRecipeName} has been scaled by {scaleFactor}. Please check the display page for updated values.");
                    this.NavigationService.Navigate(new MainWindow());
                }
            }
        }
    }
}
