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

    public IActionResult Edit(int id)
    {
      return Content("id= " + id);
    }


    [Route("movies/released/{year:regex(\\d{{4}})}/{month:range(1, 12):regex(\\d{{2}})}")]
    public IActionResult ByReleaseDate(int year, byte month)
    {
      return Content(year + " / " + month);
    }
    public IActionResult Index()
    {
      return View();
    }
  }
}