using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Demo01WebApp.Models;
using Microsoft.AspNetCore.Http;

namespace Demo01WebApp.Controllers
{
    public class CheckingController : Controller
    {
        private readonly Bank _context;

        public CheckingController(Bank context)
        {
            _context = context;
        }

        // GET: Checking
        public async Task<IActionResult> Index()
        {
            return View(await _context.Checking.ToListAsync());
        }
        public async Task<IActionResult> MyChecking()
        {
            try
            {


                var id = sessionGetId();

                var check = await _context.Checking.Where(c => c.CustomerID == id).ToListAsync();


                if (check.Count == 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(check);
                }
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }

        }

        // GET: Checking/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checking = await _context.Checking
                .FirstOrDefaultAsync(m => m.AccountID == id);
            if (checking == null)
            {
                return NotFound();
            }

            return View(checking);
        }

        // GET: Checking/Create
        public IActionResult CreateChecking()
        {
            return View();
        }

        // POST: Checking/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateChecking([Bind("CustomerID,AccountType,Balance")] Checking checking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(checking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(checking);
        }

        // GET: Checking/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checking = await _context.Checking.FindAsync(id);
            if (checking == null)
            {
                return NotFound();
            }
            return View(checking);
        }

        // POST: Checking/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountID,CustomerID,AccountType,Balance")] Checking checking)
        {
            if (id != checking.AccountID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(checking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CheckingExists(checking.AccountID))
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
            return View(checking);
        }

        // GET: Checking/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var checking = await _context.Checking
                .FirstOrDefaultAsync(m => m.AccountID == id);
            if (checking == null)
            {
                return NotFound();
            }

            return View(checking);
        }

        // POST: Checking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var checking = await _context.Checking.FindAsync(id);
            _context.Checking.Remove(checking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CheckingExists(int id)
        {
            return _context.Checking.Any(e => e.AccountID == id);
        }

        public IActionResult DepositChecking(int id)
        {


            ViewData["AccountID"] = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DepositChecking(int id, int amount)
        {



            try
            {
                Checking checking = new Checking();
                checking = await _context.Checking.FirstOrDefaultAsync(c => c.AccountID == id);


                var newBalance = (checking.Balance + amount);
                checking.Balance = newBalance;

                Transaction transaction = new Transaction();
                transaction.AccountID = id;
                transaction.AccountType = "checking";
                transaction.Amount = amount;
                transaction.Date = DateTime.Now;
                transaction.Type = "deposit";

                _context.Update(checking);
                await _context.SaveChangesAsync();


                _context.Update(transaction);
                await _context.SaveChangesAsync();

            }
            catch
            {
                ViewData["ErrorMessage"] = "There was a problem with your deposit please try again";
                return View();
            }
            return RedirectToAction(nameof(MyChecking));

        }
        public int? sessionGetId()
        {
            var val = HttpContext.Session.GetInt32("Id");
            return val;
        }
    }
}
