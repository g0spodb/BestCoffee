﻿using Microsoft.AspNetCore.Mvc;
using Core;
using System.Collections.Generic;
using BestCoffee.Model;

namespace APIBestCoffee.Controllers
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
