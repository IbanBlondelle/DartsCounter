using DartsCounter.Ui.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DartsCounter.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Start()
        {
            var dartsModel = new DartsModel(); // Create an instance of DartsModel
            return View("DartsCounter", dartsModel);
        }


        [HttpPost]
        public IActionResult Subtraction(DartsModel darts)
        {
            if (darts.Score < 181)
            {
                darts.StartingValue -= darts.Score;
            }
            return View("DartsCounter", darts);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
