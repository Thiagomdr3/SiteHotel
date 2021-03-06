using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiteHotel.Models.Hotel.Entities;
using SiteHotel.Repository;

namespace SiteHotel.Controllers
{
    public class ImagensController : Controller
    {
        private readonly Context _context;

        public ImagensController(Context context)
        {
            _context = context;
        }

        // GET: Imagens
        public async Task<IActionResult> Index()
        {
            var context = _context.Imagens.Include(i => i.Apartamento);
            return View(await context.ToListAsync());
        }

        // GET: Imagens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagens = await _context.Imagens
                .Include(i => i.Apartamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imagens == null)
            {
                return NotFound();
            }

            return View(imagens);
        }

        // GET: Imagens/Create
        public IActionResult Create()
        {
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamento, "Id", "Id");
            return View();
        }

        // POST: Imagens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Imagem,NomeImagens,ApartamentoId")] Imagens imagens)
        {
            if (ModelState.IsValid)
            {
                _context.Add(imagens);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamento, "Id", "Id", imagens.ApartamentoId);
            return View(imagens);
        }

        // GET: Imagens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagens = await _context.Imagens.FindAsync(id);
            if (imagens == null)
            {
                return NotFound();
            }
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamento, "Id", "Id", imagens.ApartamentoId);
            return View(imagens);
        }

        // POST: Imagens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Imagem,NomeImagens,ApartamentoId")] Imagens imagens)
        {
            if (id != imagens.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imagens);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagensExists(imagens.Id))
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
            ViewData["ApartamentoId"] = new SelectList(_context.Apartamento, "Id", "Id", imagens.ApartamentoId);
            return View(imagens);
        }

        // GET: Imagens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagens = await _context.Imagens
                .Include(i => i.Apartamento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imagens == null)
            {
                return NotFound();
            }

            return View(imagens);
        }

        // POST: Imagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var imagens = await _context.Imagens.FindAsync(id);
            _context.Imagens.Remove(imagens);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImagensExists(int id)
        {
            return _context.Imagens.Any(e => e.Id == id);
        }
    }
}
