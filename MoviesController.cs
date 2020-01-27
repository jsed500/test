using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

          
            return View();
        }
            
        public ActionResult Edit (int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortby))
                sortby = "Name";

            return Content(String.Format("pageIndex={0}&sortby={1}", pageIndex, sortby));
        }
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
       
    }
}