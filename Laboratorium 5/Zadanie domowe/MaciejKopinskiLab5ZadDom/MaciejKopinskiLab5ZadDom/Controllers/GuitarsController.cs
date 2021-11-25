using MaciejKopinskiLab5ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5ZadDom.Controllers
{
    public class GuitarsController : Controller
    {
        /// <summary>
        /// database reference
        /// </summary>
        private readonly DataBaseContext _context;

        public GuitarsController(DataBaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// endpoint to show list of guitars
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(_context.Guitars.Include(g => g.Manufacturer).ToList());
        }

        /// <summary>
        /// endpoint to show create guitar form
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// endpoint to add new guitar
        /// </summary>
        /// <param name="guitar"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Guitar guitar)
        {
            _context.Guitars.Add(guitar);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// endpoint to show basket list
        /// </summary>
        /// <param name="guitarId"></param>
        /// <returns></returns>
        public IActionResult AddToBasket(int guitarId)
        {
            var guitar = _context.Guitars.FirstOrDefault(g => g.Id.Equals(guitarId));

            ViewBag.GuitarId = guitarId;
            return View(_context.Baskets.ToList());
        }

        /// <summary>
        /// method to add guitar to basket
        /// </summary>
        /// <param name="bId"></param>
        /// <param name="gId"></param>
        /// <returns></returns>
        public IActionResult ChooseBasket(int bId, int gId)
        {
            var basket = _context.Baskets.Include(b => b.Guitars).FirstOrDefault(b => b.Id.Equals(bId));
            var guitar = _context.Guitars.Include(g => g.Basket).FirstOrDefault(g => g.Id.Equals(gId));
            basket.Guitars.Add(guitar);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
