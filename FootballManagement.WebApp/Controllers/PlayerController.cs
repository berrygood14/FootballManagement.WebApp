using System.Web.Mvc;
using FootballManagement.WebApp.Models;
using System.Configuration;

namespace FootballManagement.WebApp.Controllers
{
    public class PlayerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}