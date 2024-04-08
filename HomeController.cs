﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Events() { return View(); }

        public ActionResult Staff() { return View(); }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AdminLogin()
        {
            ViewBag.Message = "Only for Staff";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Welcome";

            return View();
        }
        public ActionResult Gallary()
        {
           
            return View();
        }
        public ActionResult FeedBack()
        {

            return View();
        }
        public ActionResult nav()
        {

            return View();
        }
    }
}