using MaciejKopinskiLab5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5.Controllers
{
    public class MoviesController : Controller
    {
        private readonly DataBaseContext _context;

        public MoviesController(DataBaseContext context)
        {
            this._context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



        public IActionResult Index()
        {
            return View(_context.Movies.ToList());
        }
    }
}
