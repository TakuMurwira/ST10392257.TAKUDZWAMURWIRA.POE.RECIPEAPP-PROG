
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
    /// Interaction logic for RevertQuantitiesPage.xaml
    /// </summary>
    public partial class RevertQuantitiesPage : Page
    {
        public RevertQuantitiesPage()
        {
            InitializeComponent();
            foreach (var recipe in MainWindow.Recipes.Values)
            {
                if (recipe.IsScaled)
                {
                    RecipeSelector.Items.Add(recipe.Name);
                }
            }
        }

        private void RevertButton_Click(object sender, RoutedEventArgs e)
        {
            if (RecipeSelector.SelectedIndex >= 0)
            {
                string selectedRecipeName = RecipeSelector.SelectedItem.ToString();

                if (MainWindow.Recipes.TryGetValue(selectedRecipeName, out Recipe recipe))
                {
                    var result = MessageBox.Show($"Are you sure you want to revert {selectedRecipeName}?", "Confirmation", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        recipe.Revert();
                        MessageBox.Show($"Recipe {selectedRecipeName} has been reverted.");
                        this.NavigationService.Navigate(new MainWindow());
                    }
                }
            }
        }
    }
}
