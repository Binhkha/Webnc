using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvance.Session_2.Models;

namespace WebAdvance.Session_2.Controllers
{
    public class FormController : Controller
    {
        public ActionResult Form()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestRespone response)
        {
            return View("Thanks", response);

        }
    }
}