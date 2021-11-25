using MaciejKopinskiLab5ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5ZadDom.Controllers
{
    public class BasketsController : Controller
    {
        /// <summary>
        /// database reference
        /// </summary>
        private readonly DataBaseContext _context;

        public BasketsController(DataBaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// endpoint returning list of baskets
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(_context.Baskets.Include(b => b.Account).Include(g => g.Guitars).ToList());
        }

        /// <summary>
        /// endpoint to show add basket form
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// method to add new basket
        /// </summary>
        /// <param name="basket"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Basket basket)
        {
            _context.Baskets.Add(basket);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
