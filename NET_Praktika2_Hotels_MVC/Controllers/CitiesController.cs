using NET_Praktika2_Hotels_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NET_Praktika2_Hotels_MVC.Controllers
{
    public class CitiesController : Controller
    {
        // GET: Cities
        public ActionResult Index()
        {
            ViewBag.Cities = CitiesCollection.listCities;
            return View();
        }
    }
}