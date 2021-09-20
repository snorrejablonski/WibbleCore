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
        public IActionResult Index()
        {
            var viewModel = new MoviesViewModel();

            return View("List", viewModel);
        }

        public ActionResult Details(int id, MoviesViewModel viewModel)
        {
            var movie = viewModel.Get(id);
            
            return View(movie);
        }
    }
}
