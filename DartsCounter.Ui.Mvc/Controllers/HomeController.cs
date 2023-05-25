using DartsCounter.Ui.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DartsCounter.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly DartsModel dartsModel;

        public HomeController(DartsModel CurrentUser)
        {
            dartsModel = CurrentUser;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Start()
        {
            return View("DartsCounter", dartsModel);
        }


        [HttpPost]
        public IActionResult Subtraction([FromForm] int Points)
        {
            if (dartsModel.Score > 0 && Points < 181 && Points <= dartsModel.Score)
            {
                dartsModel.Score -= Points;
            }
            return View("DartsCounter", dartsModel);
        }

        [HttpPost]
        public IActionResult ResetGame()
        {
            dartsModel.Score = 501;
            return RedirectToAction("Start");
        }

        public ActionResult Returnhome()
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
