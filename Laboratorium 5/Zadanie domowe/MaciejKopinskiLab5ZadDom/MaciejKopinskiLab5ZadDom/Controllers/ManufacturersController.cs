using MaciejKopinskiLab5ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5ZadDom.Controllers
{
    public class ManufacturersController : Controller
    {
        /// <summary>
        /// database reference
        /// </summary>
        private readonly DataBaseContext _context;

        public ManufacturersController(DataBaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// endpoint returning list of manufacturers
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(_context.Manufacturers.ToList());
        }

        /// <summary>
        /// endpoint to show add manufacturer form
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// method to add a new manufacturer
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Manufacturer manufacturer)
        {
            _context.Manufacturers.Add(manufacturer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
