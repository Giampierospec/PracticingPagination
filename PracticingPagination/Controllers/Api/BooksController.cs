using Newtonsoft.Json;
using PracticingPagination.Context;
using PracticingPagination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticingPagination.Controllers.Api
{
    public class BooksController : Controller
    {
        private BooksDbContext _db = new BooksDbContext();
        [HttpGet]
        // GET: Books
        public ActionResult Index()
        {
            List<Book> Books = _db.Books.ToList();
            var serializedObject = JsonConvert.SerializeObject(Books);
            return Json(serializedObject, JsonRequestBehavior.AllowGet);
        }
    }
}