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
    /// Interaction logic for ClearRecipePage.xaml
    /// </summary>
    public partial class ClearRecipePage : Page
    {
        public ClearRecipePage()
        {
            InitializeComponent();
            foreach (var recipe in MainWindow.Recipes.Values)
            {
                RecipeSelector.Items.Add(recipe.Name);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            if (RecipeSelector.SelectedIndex >= 0)
            {
                string selectedRecipeName = RecipeSelector.SelectedItem.ToString();

                var result = MessageBox.Show($"Are you sure you want to delete {selectedRecipeName}?", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    MainWindow.Recipes.Remove(selectedRecipeName);
                    MessageBox.Show($"Recipe {selectedRecipeName} has been deleted.");
                    this.NavigationService.Navigate(new MainWindow());
                }
            }
        }
    }
}
