using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BYsoft.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;
        public HomeController(IRepository repo) 
        {
            this.repo = repo;
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}