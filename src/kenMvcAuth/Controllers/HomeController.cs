using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kenMvcAuth.Models.Helpers;
using Microsoft.AspNet.Mvc;

namespace kenMvcAuth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeHelper hm = new HomeHelper();
            
            ViewData["CountDown"] = hm.GetCountDown(); ;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "RSVP is comming soon";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Mailing Address.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
		
        public IActionResult OurStory()
        {
            ViewData["Message"] = "These are our stories";

            return View();
        }

        public IActionResult Accommodations()
        {
            ViewData["Message"] = "Here are the local accommodations";

            return View();
        }

        public IActionResult Registry()
        {
            ViewData["Message"] = "These are the places we are registered";

            return View();
        }

        public IActionResult Events()
        {
            ViewData["Message"] = "List of wedding events";

            return View();
        }
    }
}
