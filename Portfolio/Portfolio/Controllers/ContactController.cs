using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        PortfolioContactInfoEntities db = new PortfolioContactInfoEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact newcontact)
        {
            if (ModelState.IsValid)
            {
                this.db.Contacts.Add(newcontact);
                this.db.SaveChanges();

                return RedirectToAction("Greet", "Contact");
            }

            //this.viewbag.genreid = new selectlist(this.db.genres, "genreid", "name", album.genreid);
            //this.viewbag.artistid = new selectlist(this.db.artists, "artistid", "name", album.artistid);

            return RedirectToAction("Index", "Contact");
        }

        public ActionResult Greet()
        {
            return View();
        }

        //public String ImagePath
        //{
        //    ViewBag.Name = "Content/img/dragonCombat.jpg";
        //    get
        //    {
        //        return "~/Content/img/dragonCombat.jpg";
        //    }

        //}


    }
}
