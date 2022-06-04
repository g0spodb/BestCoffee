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
using System.Drawing;
using BestCoffee.Model;

namespace WPFBestCoffee
{
    /// <summary>
    /// Логика взаимодействия для CoffeePage.xaml
    /// </summary>
    public partial class CoffeePage : Page
    {
        public static BestCoffee.Model.Coffee constProd;
        public CoffeePage(BestCoffee.Model.Coffee n)
        {
            InitializeComponent();
            var currentRecipes = MyBestCoffeeEntities.GetContext().Coffee.ToList();
            constProd = n;
            this.DataContext = constProd;
            tb_name.Text = n.Name;
            tb_recipe.Text = n.Recipe;
            tb_ingredient.Text = n.Ingredient;
            tb_complexity.Text = n.Complexity.Title;
            if(n.favorite == true)
            {
                    like.Visibility = Visibility.Visible;
                    btn_dislike.Visibility = Visibility.Visible;
            }
            if(n.favorite != true)
            {
                btn_like.Visibility = Visibility.Visible;
            }

        }
        private void BtnRecipes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RecipesPage());
        }
        private void BtnFavorite_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FavoritePage());
        }
        private void BtnHistory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HistoryPage());
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
