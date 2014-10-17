using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        //PortfolioContactInfoEntities1 db = new PortfolioContactInfoEntities1();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(Contact newcontact)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        this.db.Contacts.Add(newcontact);
        //        this.db.SaveChanges();

        //        return RedirectToAction("Greet", "Contact");
        //    }

        //    //this.viewbag.genreid = new selectlist(this.db.genres, "genreid", "name", album.genreid);
        //    //this.viewbag.artistid = new selectlist(this.db.artists, "artistid", "name", album.artistid);

        //    return RedirectToAction("Index", "Contact");
        //}

        //Function to send post contact form to email
        [HttpPost]
        public ActionResult Index(ContactForm contactForm)
        {
            //Sending an email
            //Step1: include name sapace

            //Step2: create new message
            //1st parameter: who it's from
            //2nd param: who it's to
            MailMessage message = new MailMessage("theRobots@seedpaths.com", "jaya.chunduri@gmail.com");

            message.Subject = "Contact Request from " + contactForm.FirstName;

            //Step4: Consturct the body with a string builder
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("You have a new contact request.");
            sb.AppendLine("First Name: " + contactForm.FirstName);
            sb.AppendLine("Last Name: " + contactForm.LastName);
            sb.AppendLine("Email: " + contactForm.Email);
            sb.AppendLine("Phone: " + contactForm.Phone);
            sb.AppendLine("Message: " + contactForm.Comment);
            sb.AppendLine("I Love You,");
            sb.AppendLine("Robots");

            //Step5: Add the body to the message
            message.Body = sb.ToString();

            //step6: Declare the SMTP(Simple Mail Transfer Protocol) client
            SmtpClient smtpClient = new SmtpClient("mail.dustinkraft.com", 587);

            smtpClient.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");

            //step7: send the message
            smtpClient.Send(message);

            //done
            //kick the user to the thankyou page
            return PartialView("Greet");
        }

        //public ActionResult Greet()
        //{
        //    return PartialView();
        //}

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
