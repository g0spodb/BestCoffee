using Microsoft.AspNetCore.Mvc;

namespace APIBestCoffee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BestCoffeeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
