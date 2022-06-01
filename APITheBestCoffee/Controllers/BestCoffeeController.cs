using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestCoffee;
using BestCoffee.Model;
using Core;

namespace APITheBestCoffee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BestCoffeeController : Controller
    {
        
        [HttpGet]
        public IEnumerable<Coffee> GetCoffees()
        {
            return DataAccess.GetCoffees();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
