using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using PracticingPagination.Context;
using PracticingPagination.Models;

namespace PracticingPagination.Controllers
{
    public class MainController : Controller
    {

        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
    }
}