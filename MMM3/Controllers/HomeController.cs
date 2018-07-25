using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace MMM3.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pricing()
        {
            return View();
        }

        public ActionResult Foundation()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult HowItWorks()
        {
            return View();
        }
        public ActionResult VirtualAssistants()
        {
            return View();
        }
        public ActionResult Inbound()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Contact(string name, string email, string message)
        {
            SmtpClient client = new SmtpClient("mail.1solvesolutions.co.nz");
            //If you need to authenticate
            client.Credentials = new NetworkCredential("abesamisj@gmail.com", "Passw0rd1");

            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(email);
            mailMessage.To.Add(new MailAddress("enquiries@1solvesolutions.co.nz"));
            mailMessage.Subject = "Interest from website";
            mailMessage.Body = string.Format(body, name, email, message);
            mailMessage.IsBodyHtml = true;

            client.Send(mailMessage);

            TempData["Message"] = "Message sent. Thank you for your email. We will respond to you shortly.";

            return RedirectToAction("Index", "Home");
        }
    }
}