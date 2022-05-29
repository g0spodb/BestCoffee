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
using WPFBestCoffee.Model;

namespace WPFBestCoffee
{
    /// <summary>
    /// Логика взаимодействия для FavoritePage.xaml
    /// </summary>
    public partial class FavoritePage : Page
    {
        public FavoritePage()
        {
            InitializeComponent();
            var currentRecipes = MyBestCoffeeEntities.GetContext().Coffee.Where(a =>a.favorite == true).ToList();
            LViewRecipes.ItemsSource = currentRecipes;
        }
        private void BtnRecipes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RecipesPage());
        }
        private void BtnHistory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HistoryPage());  
        }

        private void LViewRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
