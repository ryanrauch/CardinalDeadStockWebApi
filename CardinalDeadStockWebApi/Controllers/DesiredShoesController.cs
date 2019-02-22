using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CardinalDeadStockWebApi.Data;
using CardinalDeadStockWebApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace CardinalDeadStockWebApi.Controllers
{
    public class DesiredShoesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IAuthorizationService _authorizationService;

        public DesiredShoesController(
            ApplicationDbContext context,
            IAuthorizationService authorizationService)
        {
            _context = context;
            _authorizationService = authorizationService;
        }

        // GET: DesiredShoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.DesiredShoes.ToListAsync());
        }

        // GET: DesiredShoes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desiredShoe = await _context.DesiredShoes
                .FirstOrDefaultAsync(m => m.DesiredShoeId == id);
            if (desiredShoe == null)
            {
                return NotFound();
            }

            var ares = await _authorizationService.AuthorizeAsync(User, desiredShoe, Authorization.DesiredShoeOperations.Read);
            if(ares.Succeeded)
            {
                return View(desiredShoe);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: DesiredShoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DesiredShoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DesiredShoeId,Description,URL,ReleaseDate,ShoeType")] DesiredShoe desiredShoe)
        {
            if (ModelState.IsValid)
            {
                desiredShoe.DesiredShoeId = Guid.NewGuid();
                _context.Add(desiredShoe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(desiredShoe);
        }

        // GET: DesiredShoes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desiredShoe = await _context.DesiredShoes.FindAsync(id);
            if (desiredShoe == null)
            {
                return NotFound();
            }
            return View(desiredShoe);
        }

        // POST: DesiredShoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("DesiredShoeId,Description,URL,ReleaseDate,ShoeType")] DesiredShoe desiredShoe)
        {
            if (id != desiredShoe.DesiredShoeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(desiredShoe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DesiredShoeExists(desiredShoe.DesiredShoeId))
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
            return View(desiredShoe);
        }

        // GET: DesiredShoes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desiredShoe = await _context.DesiredShoes
                .FirstOrDefaultAsync(m => m.DesiredShoeId == id);
            if (desiredShoe == null)
            {
                return NotFound();
            }

            return View(desiredShoe);
        }

        // POST: DesiredShoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var desiredShoe = await _context.DesiredShoes.FindAsync(id);
            _context.DesiredShoes.Remove(desiredShoe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesiredShoeExists(Guid id)
        {
            return _context.DesiredShoes.Any(e => e.DesiredShoeId == id);
        }
    }
}
