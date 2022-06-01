using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using BestCoffee.Model;

namespace WPFBestCoffee
{
    /// <summary>
    /// Логика взаимодействия для AddRecipePage.xaml
    /// </summary>
    public partial class AddRecipePage : Page
    {
        public static ObservableCollection<BestCoffee.Model.Coffee> coffee { get; set; }
        public static ObservableCollection<BestCoffee.Model.Class> classs { get; set; }
        public AddRecipePage()
        {
            InitializeComponent();
            cb_class.ItemsSource = bd_connection.connection.Class.ToList();
            cb_class.DisplayMemberPath = "Title";
            cb_complexity.ItemsSource = bd_connection.connection.Complexity.ToList();
            cb_complexity.DisplayMemberPath = "Title";
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

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            BestCoffee.Model.Coffee new_coffee = new BestCoffee.Model.Coffee();
            new_coffee.Name = tb_name.Text;
            if (cb_class.SelectedIndex == 0)
            {
                new_coffee.Id_Class = 1;
            }
            else if (cb_class.SelectedIndex == 1)
            {
                new_coffee.Id_Class = 2;
            }
            else if (cb_class.SelectedIndex == 2)
            {
                new_coffee.Id_Class = 3;
            }
            else if (cb_class.SelectedIndex == 3)
            {
                new_coffee.Id_Class = 4;
            }
            else if (cb_class.SelectedIndex == 4)
            {
                new_coffee.Id_Class = 5;
            }
            if (cb_complexity.SelectedIndex == 0)
            {
                new_coffee.Id_Complexity = 1;
            }
            else if (cb_complexity.SelectedIndex == 1)
            {
                new_coffee.Id_Complexity = 2;
            }
            else if (cb_complexity.SelectedIndex == 2)
            {
                new_coffee.Id_Complexity = 3;
            }
            if(rb_favorite.IsChecked == true)
            {
                new_coffee.favorite = true;
            }
            else
            {
                new_coffee.favorite = false;
            }
            new_coffee.img = tb_img.Text;
            new_coffee.Recipe = tb_recipe.Text;
            new_coffee.Ingredient = tb_ingredients.Text;
            bd_connection.connection.Coffee.Add(new_coffee);
            bd_connection.connection.SaveChanges();
            coffee = new ObservableCollection<BestCoffee.Model.Coffee>(bd_connection.connection.Coffee.ToList());
            NavigationService.Navigate(new RecipesPage());
        }
    }
}
