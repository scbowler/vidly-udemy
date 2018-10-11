using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Bob 1"},
                new Customer { Name = "Will 5"}
            };

            var viewModal = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModal);
        }
    }
}
