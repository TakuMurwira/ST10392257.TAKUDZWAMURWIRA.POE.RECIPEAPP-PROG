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
using System.Windows;
using System.Windows.Controls;

namespace RECIPEAPP_PROG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Dictionary<string, Recipe> Recipes = new Dictionary<string, Recipe>();
        public MainWindow()
        {
            InitializeComponent();
            addRecipeBtn.Click += AddRecipeBtn_Click;
            displayRecipeBtn.Click += DisplayRecipeBtn_Click;
            listRecipeBtn.Click += ListRecipeBtn_Click;
            scaleBtn.Click += ScaleBtn_Click;
            restValuesBtn.Click += RestValuesBtn_Click;
            clearRecipeBtn.Click += ClearRecipeBtn_Click;
            endSessionBtn.Click += EndSessionBtn_Click;
        }

        private void AddRecipeBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenPageWindow(new AddRecipePage());
        }

        private void DisplayRecipeBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenPageWindow(new DisplayRecipePage());
        }

        private void ListRecipeBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenPageWindow(new ListRecipePage());
        }

        private void ScaleBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenPageWindow(new ScaleRecipePage());
        }

        private void RestValuesBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenPageWindow(new RevertQuantitiesPage());
        }

        private void ClearRecipeBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenPageWindow(new ClearRecipePage());
        }

        private void EndSessionBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenPageWindow(Page page)
        {
            PageWindow pageWindow = new PageWindow(page);
        }
            
    }
}
