using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo01WebApp.Models;

namespace Demo01WebApp.Controllers
{
    public class BusinessController : Controller
    {
        private readonly Bank _context;

        public BusinessController(Bank context)
        {
            _context = context;
        }

        // GET: Business
        public async Task<IActionResult> Index()
        {
            return View(await _context.Business.ToListAsync());
        }



        // GET: Business/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Business
                .FirstOrDefaultAsync(m => m.AccountID == id);
            if (business == null)
            {
                return NotFound();
            }

            return View(business);
        }

        // GET: Business/Create
        public IActionResult CreateBusiness()
        {
            return View();
        }

        // POST: Business/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBusiness([Bind("CustomerID,AccountType,Balance")] Business business)
        {
            if (ModelState.IsValid)
            {
                _context.Add(business);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(business);
        }

        // GET: Business/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Business.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }
            return View(business);
        }

        // POST: Business/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountID,CustomerID,AccountType,Balance")] Business business)
        {
            if (id != business.AccountID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(business);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinessExists(business.AccountID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(business);
        }

        // GET: Business/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Business
                .FirstOrDefaultAsync(m => m.AccountID == id);
            if (business == null)
            {
                return NotFound();
            }

            return View(business);
        }

        // POST: Business/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var business = await _context.Business.FindAsync(id);
            _context.Business.Remove(business);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusinessExists(int id)
        {
            return _context.Business.Any(e => e.AccountID == id);
        }
    }
}
