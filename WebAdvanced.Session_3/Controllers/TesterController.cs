using System.Web.Mvc;
using WebAdvanced.Session_3.Models;

namespace WebAdvanced.Session_3.Controllers
{
    public class TesterController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Index()
        {
            Tester acc = new Tester();

            return View(acc);
        }


        [HttpPost]
        public ActionResult Index(Tester acc)
        {
            if (ModelState.IsValid)
            {
                return View("Success");
            }
            else
            {
                string errorMs = "";
                foreach (ModelState modelstate in ModelState.Values)
                {
                    foreach (var errorM in modelstate.Errors)
                    {
                        errorMs += errorM.ErrorMessage + "<br />";
                    }
                }
                ViewBag.ErrorMessage = errorMs;
            }

            return View(acc);
        }
    }
}