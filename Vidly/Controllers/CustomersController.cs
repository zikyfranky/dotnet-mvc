using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> customers = new List<Customer> {
            new Customer { Id=1, Name = "John Smith" },
            new Customer { Id=2, Name = "Mary Jack" }
        };

        public IActionResult Index()
        {
            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{id}")]
        public IActionResult Details(int id)
        {
            var customer = customers.Find(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
    }
}