using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using BestCoffee.Model;
namespace Core
{
    public class DataAccess
    {
        private static string connect = ConfigurationManager.ConnectionStrings["Model"].ConnectionString;
        private static IDbConnection connection = new SqlConnection(connect);
        public static ObservableCollection<Coffee> GetCoffee()
        {
            return new ObservableCollection<Coffee>(bd_connection.connection.Coffee.ToList());
        }
        public static ObservableCollection<Coffee> GetCoffees()
        {
            var listCoffee = new ObservableCollection<Coffee>();

            foreach (var i in GetCoffee())
            {
                var gh = new Coffee();
                gh.Id = i.Id;
                gh.Name = i.Name;
                gh.Id_Class = i.Id_Class;
                gh.Recipe = i.Recipe;
                gh.Ingredient = i.Ingredient;
                gh.Id_Complexity = i.Id_Complexity;
                gh.img = i.img;
                gh.favorite = i.favorite;
                listCoffee.Add(gh);
            }
            return listCoffee;
        }
        //public static List<Coffee> GetAllCoffee()
        //{
        //    return connection.Query<Coffee>("select * from [dbo].[Coffee]").AsList();
        //}
    }
}
