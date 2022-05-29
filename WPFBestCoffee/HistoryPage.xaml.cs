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
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public static int actualPage;
        public HistoryPage()
        {
            InitializeComponent();
            var currentRecipes = MyBestCoffeeEntities.GetContext().Coffee.ToList();
            LViewRecipes.ItemsSource = currentRecipes;
        }
        private void BtnRecipes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RecipesPage());
        }
        private void BtnFavorite_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FavoritePage());
        }

        private void LViewRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void tb_search_TextChanged(object sender, RoutedEventArgs e)
        {

            actualPage = 0;
            Filter();
        }
        public void Filter()
        {
            var filterProd = MyBestCoffeeEntities.GetContext().Coffee.ToList();
            if (tb_search.Text != "")
            {
                filterProd = filterProd.Where(z => (z.Name.StartsWith(tb_search.Text)));
            }
            LViewRecipes.ItemsSource = filterProd;
        }
    }
    
}
