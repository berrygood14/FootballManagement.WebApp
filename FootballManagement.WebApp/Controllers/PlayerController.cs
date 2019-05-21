using System.Web.Mvc;
using FootballManagement.WebApp.Models;
using System.Configuration;
using System.Collections.Generic;

namespace FootballManagement.WebApp.Controllers
{
    public class PlayerController : Controller
    {                

        public ActionResult Index()
        {

            //This is an example of how I would build a list of players from an API call / Database and send it to the view
            List<PlayerViewModel> playlist = new List<PlayerViewModel>();
            playlist.Add(new PlayerViewModel() { Id = 1, FirstName = "Test", LastName = "TestLastName", NickName = "TiTi", Positions = 0, ShirtNumber = 14, Team = 1 });

            return View(playlist);
        }
    }
}