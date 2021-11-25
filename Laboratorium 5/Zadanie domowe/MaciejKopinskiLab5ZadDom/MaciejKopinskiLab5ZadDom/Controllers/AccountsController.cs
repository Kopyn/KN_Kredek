using MaciejKopinskiLab5ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejKopinskiLab5ZadDom.Controllers
{
    public class AccountsController : Controller
    {
        //reference to database
        private readonly DataBaseContext _context;

        public AccountsController(DataBaseContext context)
        {
            _context = context;
        }

        //endpoint to return list of accounts
        public IActionResult Index()
        {
            return View(_context.Accounts.ToList());
        }

        //endpoint to view create account form
        public IActionResult Create()
        {
            return View();
        }

        //endpoint to add new account
        [HttpPost]
        public IActionResult Create(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //endpoint to view edit account form
        public IActionResult Edit(int id)
        {
            var account = _context.Accounts.FirstOrDefault(a => a.Id.Equals(id));

            if(account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        //method to edit an account
        [HttpPost]
        public IActionResult Edit(Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Accounts.Update(account);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        //endpoint to view deletion form
        public IActionResult Delete(int id)
        {
            var account = _context.Accounts.Include(b => b.Baskets).FirstOrDefault(a => a.Id.Equals(id));

            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        //method to delete an account
        [HttpPost]
        public IActionResult Delete(Account account)
        {
            _context.Accounts.Remove(account);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
