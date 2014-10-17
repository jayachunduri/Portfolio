using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class WorkController : Controller
    {
        //
        // GET: /Work/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult BattleShip()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DragonCombat()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Hangman()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GuessThatNumber()
        {
            return View();
        }

    }
}
