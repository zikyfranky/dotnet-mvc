using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public List<Movie> movies = new List<Movie> {
            new Movie { Id=1, Name = "Shrek", },
            new Movie { Id=2, Name = "Jurrasic Park" }
        };

        public IActionResult Index()
        {
            var viewModel = new MoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}