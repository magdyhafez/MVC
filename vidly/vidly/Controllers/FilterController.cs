using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vidly.Controllers
{
    public class FilterController : Controller
    {
        // GET: Filter
        [OutputCache(Duration = 15)]

        public string Index()
        {
            return "This is ASP.Net MVC Filters Tutorial";
        }

        [OutputCache(Duration = 20)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
    }
}