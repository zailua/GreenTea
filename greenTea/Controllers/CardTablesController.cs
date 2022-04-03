﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using greenTea.Data;
using greenTea.Models;

namespace greenTea.Controllers
{
    public class CardTablesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CardTablesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CardTables
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CardTables.Include(c => c.Categoria);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: CardTables-2
        public async Task<IActionResult> Index2()
        {
            var applicationDbContext = _context.CardTables.Include(c => c.Categoria);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CardTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardTable = await _context.CardTables
                .Include(c => c.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cardTable == null)
            {
                return NotFound();
            }

            return View(cardTable);
        }

        // GET: CardTables/Create
        public IActionResult Create()
        {
            ViewData["CategoriaID"] = new SelectList(_context.Categorias, "Id", "Nome");
            return View();
        }

        // POST: CardTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Img,Nome,CategoriaID")] CardTable cardTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cardTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaID"] = new SelectList(_context.Categorias, "Id", "Nome", cardTable.CategoriaID);
            return View(cardTable);
        }

        // GET: CardTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardTable = await _context.CardTables.FindAsync(id);
            if (cardTable == null)
            {
                return NotFound();
            }
            ViewData["CategoriaID"] = new SelectList(_context.Categorias, "Id", "Nome", cardTable.CategoriaID);
            return View(cardTable);
        }

        // POST: CardTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Img,Nome,CategoriaID")] CardTable cardTable)
        {
            if (id != cardTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cardTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardTableExists(cardTable.Id))
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
            ViewData["CategoriaID"] = new SelectList(_context.Categorias, "Id", "Nome", cardTable.CategoriaID);
            return View(cardTable);
        }

        // GET: CardTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardTable = await _context.CardTables
                .Include(c => c.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cardTable == null)
            {
                return NotFound();
            }

            return View(cardTable);
        }

        // POST: CardTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cardTable = await _context.CardTables.FindAsync(id);
            _context.CardTables.Remove(cardTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardTableExists(int id)
        {
            return _context.CardTables.Any(e => e.Id == id);
        }

    }
}
