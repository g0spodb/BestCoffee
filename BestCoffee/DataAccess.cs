using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Core
{
    public class DataAccess
    {
        public static List<coffee> GetCoffees()
        {
            List<coffee> coffees = new List<coffee>(bdconnection.connection.patient);
        }
        public static coffee GetCoffee(int id_pat)
        {
            List<coffee> coffees = GetCoffees();
            var cof = coffees.Where(p => p.id_pat == id_pat).FirstOrDefault();
            return cof;
        }
    }
}
