using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Application_RSV.Data;
using Application_RSV.Models;

namespace Application_RSV.Controllers
{
    public class typeRsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public typeRsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: typeRs
        public async Task<IActionResult> Index()
        {
            return View(await _context.typeRs.ToListAsync());
        }

        // GET: typeRs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeR = await _context.typeRs
                .FirstOrDefaultAsync(m => m.idType == id);
            if (typeR == null)
            {
                return NotFound();
            }

            return View(typeR);
        }

        // GET: typeRs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: typeRs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idType,name,nomber_apprenant")] typeR typeR)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeR);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeR);
        }

        // GET: typeRs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeR = await _context.typeRs.FindAsync(id);
            if (typeR == null)
            {
                return NotFound();
            }
            return View(typeR);
        }

        // POST: typeRs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idType,name,nomber_apprenant")] typeR typeR)
        {
            if (id != typeR.idType)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeR);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!typeRExists(typeR.idType))
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
            return View(typeR);
        }

        // GET: typeRs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeR = await _context.typeRs
                .FirstOrDefaultAsync(m => m.idType == id);
            if (typeR == null)
            {
                return NotFound();
            }

            return View(typeR);
        }

        // POST: typeRs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeR = await _context.typeRs.FindAsync(id);
            _context.typeRs.Remove(typeR);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool typeRExists(int id)
        {
            return _context.typeRs.Any(e => e.idType == id);
        }
    }
}
