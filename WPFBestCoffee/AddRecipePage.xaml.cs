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

namespace WPFBestCoffee
{
    /// <summary>
    /// Логика взаимодействия для AddRecipePage.xaml
    /// </summary>
    public partial class AddRecipePage : Page
    {
        public AddRecipePage()
        {
            InitializeComponent();
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
    }
}
