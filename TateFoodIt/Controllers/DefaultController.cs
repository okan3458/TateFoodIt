﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TateFoodIt.Entities;
using TateFoodIt.Context;

namespace TateFoodIt.Controllers
{
    public class DefaultController : Controller
    {
        TasteContext context = new TasteContext();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbarInfo()
        {
            ViewBag.phone = context.Adresses.Select(x => x.Phone).FirstOrDefault();
            ViewBag.email = context.Adresses.Select(y => y.Email).FirstOrDefault();
            ViewBag.description = context.Adresses.Select(z => z.Description).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            ViewBag.title = context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = context.Abouts.Select(x => x.Description).FirstOrDefault();
            ViewBag.image = context.Abouts.Select(x => x.ImageUrl).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialMenu()
        {
            var values=context.Products.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            
            return PartialView();
        }
        public PartialViewResult PartialChef()
        {

            return PartialView();
        }

    }
}