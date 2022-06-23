using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("Employees")]
        public ActionResult GetEmployee()
        {
            return View();
        }
        [Route("EmployeeDetails")]
        public ActionResult EmployeDetails()
        {
            return View();
        }


    }
}