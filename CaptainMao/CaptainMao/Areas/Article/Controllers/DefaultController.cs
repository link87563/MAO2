﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaptainMao.Areas.Article.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Article/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}