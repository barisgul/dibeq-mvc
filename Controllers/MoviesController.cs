using dibeq_mvc.Models;
using dibeq_mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace dibeq_mvc.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek"
            };

            var customers = new List<Customer>()
            {
                new Customer{Name="Customer1"}, 
                new Customer{Name="Customer2"}, 
                new Customer{Name="Customer3"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel); 
        }

        [Route("movies/released/{year}/{month:regex}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }      
        public ActionResult Edit(int id)
        {
            return Content("id="+id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }
    }
}