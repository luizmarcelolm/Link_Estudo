using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Link_Estudo.Data;
using Link_Estudo.Models;

namespace Link_Estudo.Controllers
{
    public class EstudoesController : Controller
    {
        private readonly Contexto _context;

        public EstudoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Estudoes
        public async Task<IActionResult> Index()
        {
              return _context.Estudo != null ? 
                          View(await _context.Estudo.ToListAsync()) :
                          Problem("Entity set 'Contexto.Estudo'  is null.");
        }

        // GET: Estudoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Estudo == null)
            {
                return NotFound();
            }

            var estudo = await _context.Estudo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estudo == null)
            {
                return NotFound();
            }

            return View(estudo);
        }

        // GET: Estudoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estudoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Link,Assunto,Descricao")] Estudo estudo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estudo);
        }

        // GET: Estudoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Estudo == null)
            {
                return NotFound();
            }

            var estudo = await _context.Estudo.FindAsync(id);
            if (estudo == null)
            {
                return NotFound();
            }
            return View(estudo);
        }

        // POST: Estudoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Link,Assunto,Descricao")] Estudo estudo)
        {
            if (id != estudo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estudo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudoExists(estudo.Id))
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
            return View(estudo);
        }

        // GET: Estudoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Estudo == null)
            {
                return NotFound();
            }

            var estudo = await _context.Estudo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estudo == null)
            {
                return NotFound();
            }

            return View(estudo);
        }

        // POST: Estudoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Estudo == null)
            {
                return Problem("Entity set 'Contexto.Estudo'  is null.");
            }
            var estudo = await _context.Estudo.FindAsync(id);
            if (estudo != null)
            {
                _context.Estudo.Remove(estudo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudoExists(int id)
        {
          return (_context.Estudo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
