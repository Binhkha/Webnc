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
            if (response.willAttend == null)
            {
                ViewBag.messageresult = "You need to fulfill table".ToUpper();
                //@Html.ActionLink("Go Back to Complete it", "RsvpForm")
                return View("RsvpForm");
            }
            else if ((bool)response.willAttend)
            {
                if (response.Name == null || response.Phone == null || response.Email == null)
                {
                    ViewBag.messageresult = "Please input your full info".ToUpper();
                    //@Html.ActionLink("Go Back To Input", "RsvpForm")
                    return View("RsvpForm");
                }
                else
                {
                    ViewBag.messageresult = "Welcome " + response.Name.ToUpper();
                    return View("Thanks");
                }
            }
            else
            {
                ViewBag.messageresult = "Sorry Buddy!!!".ToUpper();
            }
            return View("RsvpForm");
        }
    }
}