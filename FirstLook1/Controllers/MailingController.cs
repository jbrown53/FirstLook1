using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLook1.Models;

namespace FirstLook1.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            Mailing justin = new Mailing();
            justin.firstName = "Justin";
            justin.lastName = "Brown";
            justin.email = "Justin@email.com";

            Mailing john = new Mailing();
            john.firstName = "John";
            john.lastName = "Henry";
            john.email = "steel.driving@man.com";

            Mailing jeff = new Mailing();
            jeff.firstName = "Jeff";
            jeff.lastName = "Ngyuen";
            jeff.email = "jeff@email.net";

            List<Mailing> MailingList = new List<Mailing>();
            MailingList.Add(justin);
            MailingList.Add(john);
            MailingList.Add(jeff);

            return View(MailingList);
        }
    }
}