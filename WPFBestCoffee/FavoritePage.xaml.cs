using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public static ObservableCollection<Model.Coffee> coffee { get; set; }
        public static int actualPage;
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
            var n = (sender as ListView).SelectedItem as Model.Coffee;
            NavigationService.Navigate(new CoffeePage(n));
        }
        private void tb_search_TextChanged(object sender, RoutedEventArgs e)
        {

            actualPage = 0;
            Filter();
        }
        public void Filter()
        {
            var filterProd = (IEnumerable<Model.Coffee>)bd_connection.connection.Coffee.ToList();
            if (tb_search.Text != "")
            {
                filterProd = filterProd.Where(z => (z.Name.StartsWith(tb_search.Text)));
            }
            LViewRecipes.ItemsSource = filterProd;
        }
    }
}
