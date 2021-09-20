using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WibbleCore.Models;
using WibbleCore.ViewModels;

namespace WibbleCore.Controllers
{
    public class MoviesController : Controller
    {

        MoviesViewModel viewModel = new MoviesViewModel();
        public IActionResult Index()
        {
            return View("List", viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = viewModel.Get(id);

            if (movie == null)
                return NotFound();
            
            return View(movie);
        }
    }
}
