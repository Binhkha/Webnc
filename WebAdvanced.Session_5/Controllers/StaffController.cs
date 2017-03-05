using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAdvanced.Session_5.Models;

namespace WebAdvanced.Session_5.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(FormCollection form)
        {
            // lay thong tin tu input
            var _fhinh = Request.Files["MyFileImage"];
            // save hinh ve server -> successful
            var _pathhinh = Server.MapPath("~/Images/" + _fhinh.FileName);
            _fhinh.SaveAs(_pathhinh);
            string _path = Server.MapPath("~/Staffinfo.txt");
            string[] info = { form["txtID"], form["txtName"], form["txtDate"], form["txtSalary"], _fhinh.FileName };
            // ghi
            System.IO.File.WriteAllLines(_path, info);
            return View("Index");
        }

        public ActionResult Open()
        {
            // doc lai
            string _path = Server.MapPath("~/Staffinfo.txt");
            string[] info = System.IO.File.ReadAllLines(_path);
            Staff st = new Staff();
            st._staffID = int.Parse(info[0]);
            st._staffName = info[1];
            st._birthofDate = DateTime.Parse(info[2]);
            st._salary = decimal.Parse(info[3]);
            st._staffImage = info[4];

            // chuyen
            ViewBag.id = st._staffID;
            ViewBag.name = st._staffName;
            ViewBag.birthday = st._birthofDate.ToString("yyyy-MM-dd");
            ViewBag.salary = st._salary;
            ViewBag.staffimage = "../../Images/" + st._staffImage;
                
            return View("Index");
        }
    }
}