using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestCoffee.Model;

namespace Core
{
    public class DataAccess
    {
        public static ObservableCollection<Coffee> GetCoffee()
        {
            return new ObservableCollection<Coffee>(bd_connection.connection.Coffee.ToList());
        }
        //public static Coffee GetCoffee(int Id_coffee)
        //{
        //    List<Coffee> coffees = GetCoffees();
        //    var cof = coffees.Where(p => p.Id == Id_coffee).FirstOrDefault();
        //    return cof;
        //}
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
    }
}
