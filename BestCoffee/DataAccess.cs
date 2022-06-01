using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestCoffee.Model;

namespace Core
{
    public class DataAccess
    {
        public static List<Coffee> GetCoffees()
        {
            List<Coffee> coffees = new List<Coffee>(bd_connection.connection.Coffee);
            List<Coffee> coffeess1 = new List<Coffee>();
            return coffees;
        }
        //public static Coffee GetCoffee(int Id_coffee)
        //{
        //    List<Coffee> coffees = GetCoffees();
        //    var cof = coffees.Where(p => p.Id == Id_coffee).FirstOrDefault();
        //    return cof;
        //}
    }
}
