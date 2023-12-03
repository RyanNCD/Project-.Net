using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;

namespace SaleManagementWebMVC.Controllers
{
    public class FlowerController : Controller
    {
        private readonly FUFlowerBouquetManagementContext _context;

        public FlowerController(FUFlowerBouquetManagementContext context)
        {
            _context = context;
        }

        // GET: Flower
        public async Task<IActionResult> Index()
        {
            var fUFlowerBouquetManagementContext = _context.FlowerBouquets.Include(f => f.Category).Include(f => f.Supplier);
            return View(await fUFlowerBouquetManagementContext.ToListAsync());
        }

        // GET: Flower/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flowerBouquet = await _context.FlowerBouquets
                .Include(f => f.Category)
                .Include(f => f.Supplier)
                .FirstOrDefaultAsync(m => m.FlowerBouquetId == id);
            if (flowerBouquet == null)
            {
                return NotFound();
            }

            return View(flowerBouquet);
        }

        // GET: Flower/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierId");
            return View();
        }

        // POST: Flower/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FlowerBouquetId,CategoryId,FlowerBouquetName,Description,UnitPrice,UnitsInStock,FlowerBouquetStatus,SupplierId")] FlowerBouquet flowerBouquet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flowerBouquet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", flowerBouquet.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierId", flowerBouquet.SupplierId);
            return View(flowerBouquet);
        }

        // GET: Flower/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flowerBouquet = await _context.FlowerBouquets.FindAsync(id);
            if (flowerBouquet == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", flowerBouquet.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierId", flowerBouquet.SupplierId);
            return View(flowerBouquet);
        }

        // POST: Flower/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FlowerBouquetId,CategoryId,FlowerBouquetName,Description,UnitPrice,UnitsInStock,FlowerBouquetStatus,SupplierId")] FlowerBouquet flowerBouquet)
        {
            if (id != flowerBouquet.FlowerBouquetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flowerBouquet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlowerBouquetExists(flowerBouquet.FlowerBouquetId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", flowerBouquet.CategoryId);
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "SupplierId", "SupplierId", flowerBouquet.SupplierId);
            return View(flowerBouquet);
        }

        // GET: Flower/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flowerBouquet = await _context.FlowerBouquets
                .Include(f => f.Category)
                .Include(f => f.Supplier)
                .FirstOrDefaultAsync(m => m.FlowerBouquetId == id);
            if (flowerBouquet == null)
            {
                return NotFound();
            }

            return View(flowerBouquet);
        }

        // POST: Flower/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flowerBouquet = await _context.FlowerBouquets.FindAsync(id);
            _context.FlowerBouquets.Remove(flowerBouquet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlowerBouquetExists(int id)
        {
            return _context.FlowerBouquets.Any(e => e.FlowerBouquetId == id);
        }
    }
}
