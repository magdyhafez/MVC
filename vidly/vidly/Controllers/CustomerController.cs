using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            //return "This is home Controller";
            return RedirectToAction("GetAllCustomers");
        }

        public string GetAllCustomers()
        {
            return @"<ul>
            <li>Ali Raza</li>
            <li>Mark Upston</li>
            <li>Allan Bommer</li>
            <li>Greg Jerry</li>
            </ul>";
        }

        [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
    }
}