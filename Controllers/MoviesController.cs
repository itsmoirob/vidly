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
  public class MoviesController : Controller
  {
    public IActionResult Random()
    {
      var movie = new Movie() { Name = "Ferris" };
      var customers = new List<Customer>
      {
        new Customer { Name = "Robbie" },
        new Customer { Name = "Christina" }
      };

      var viewModel = new RandomMovieViewModel
      {
        Movie = movie,
        Customers = customers
      };

      return View(viewModel);
    }

    public IActionResult Edit(int id)
    {
      return Content("id= " + id);
    }

    public IActionResult Index(int? pageIndex, string sortBy)
    {
      if (!pageIndex.HasValue)
        pageIndex = 1;

      if (String.IsNullOrWhiteSpace(sortBy))
        sortBy = "Name";

      return Content(String.Format("pageIndex = {0} & sortBy = {1}", pageIndex, sortBy));
    }

    [Route("movies/released/{year:regex(\\d{{4}})}/{month:range(1, 12):regex(\\d{{2}})}")]
    public IActionResult ByReleaseDate(int year, byte month)
    {
      return Content(year + " / " + month);
    }
  }
}