﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class SecretController : Controller
    {
        // GET: Secret
        public ActionResult Index()
        {
            return View();
        }

        // GET: Secret
        [Authorize]
        public ContentResult Secret()
        {
            return Content("Secret informations here");
        }

        public ContentResult PublicInfo()
        {
            return Content("Public informations here");
        }
    }
}