using System.Web.Mvc;
using FootballManagement.WebApp.Models;
using FootballManagement.Logic;
using System.Configuration;
using AutoMapper;

namespace FootballManagement.WebApp.Controllers
{
    public class PlayerController : Controller
    {
       
        Player playerlist = new Player(ConfigurationManager.ConnectionStrings["footballmanagementdb"].ConnectionString);

        IConfigurationProvider config = new MapperConfiguration(cfg => cfg.CreateMap<Player, PlayerViewModel>());
        Mapper mapper = new Mapper(config);
        // GET: Player
        public ActionResult Index()
        {
            return View();
        }
    }
}