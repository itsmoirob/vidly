using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
  public class MoviesController : Controller
  {
    public IActionResult Random()
    {
      var movie = new Movie() { Name = "Ferris" };

      return View(movie);
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

    public IActionResult ByReleaseDate(int year, byte month)
    {
      return Content(year + " / " + month);
    }
  }
}