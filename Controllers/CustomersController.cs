using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
  public class CustomersController : Controller
  {
    public IActionResult Index()
    {
      var customers = new List<Customer>
      {
        new Customer { Id = 1, Name = "Robbie" },
        new Customer { Id = 2, Name = "Christina" }
      };

      var viewModel = new CustomersViewModel
      {
        Customers = customers
      };

      return View(viewModel);
    }

    public IActionResult Details(int id)
    {
      var customers = new List<Customer>
      {
        new Customer { Id = 1, Name = "Robbie" },
        new Customer { Id = 2, Name = "Christina" }
      };

      var customer = customers[id-1];
      return View(customer);
    }
  }
}