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
            ViewBag.Title = "Call centre, Outbound, Inbound, Telesales, Telemarketing and Virtual Assistants | 1solvesolutions.co.nz";
            ViewBag.Description = "Cost-effective call centre and virtual assistants company provider that outsource resources from the Philippines. We offer inbound & outbound call centre & virtual assistants services. Ideal for start-up, small-medium sized enterprises and individuals like sole proprietorship, tradies and builders";
            return View();
        }

        public ActionResult Pricing()
        {
            ViewBag.Title = "Cost-effective Pricing | 1solvesolutions.co.nz";
            ViewBag.Description = "Our pricing are so cost-effective that it is ideal for start-up, small-medium sized enterprises and even to individuals like sole proprietorship, tradies and builders";
            return View();
        }

        public ActionResult Foundation()
        {
            ViewBag.Title = "High quality process for experienced call centre operations | 1solvesolutions.co.nz";
            ViewBag.Description = "We have experiences in insurance telemarketing, cable subscriptions selling, pharmaceutical sales and virtual assistants services for tradies, start-up and small companies";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Title = "High quality call centre services, telemarketing, telesales, and virtual assistants | 1solvesolutions.co.nz";
            ViewBag.Description = "1SolveSolutions aims to provide services to builders, traders, restaurant owners, business associates, insurance brokers, local businesses and professional associations. Giving them an option for a more cost-effective and professional business solution";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "High quality standard call centre solutions, telesales, telemarketing, and virtual assistants services | 1solvesolutions.co.nz";
            ViewBag.Description = "1 SOLVE SOLUTIONS will offer call centre and virtual assistant solutions to small-medium enterprises that are looking to reduce cost, improve efficiency and minimize overhead expenses by shifting operations via outsourcing";
            return View();
        }
        public ActionResult HowItWorks()
        {
            ViewBag.Title = "High quality standard call centre solutions, telesales, telemarketing, and virtual assistants services | 1solvesolutions.co.nz";
            ViewBag.Description = "Our experienced agents will generate interest for your products or services, while creating opportunity by providing information and factors customer's feedbacks. We will also be able to schedule appointments and produce leads by calling your client list. On the other hand our experience sales agents can study your products and services and directly sell it over the phone";
            return View();
        }
        public ActionResult VirtualAssistants()
        {
            ViewBag.Title = "High quality standard call centre solutions, telesales, telemarketing, and virtual assistants services | 1solvesolutions.co.nz";
            ViewBag.Description = "Our highly skilled virtual assistants will be your built-in accountability partner running your business. They are not only trained to do all those clerical and administrative work but they are also there to make sure your business goals are met";

            return View();
        }
        public ActionResult Inbound()
        {
            ViewBag.Title = "High quality standard call centre solutions, telesales, telemarketing, and virtual assistants services | 1solvesolutions.co.nz";
            ViewBag.Description = "Our highly skilled agents will enhance your customer's experience when answering their calls. Not only they will show technical expertise in your products or services but highest phone courtesy and extra-ordinary customer service will be given to everybody.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Title = "High quality standard call centre solutions, telesales, telemarketing, and virtual assistants services | 1solvesolutions.co.nz";
            ViewBag.Description = "Ready to start your next project with us? That's great! Give us a call or send us an email and we will get back to you as soon as possible!";

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