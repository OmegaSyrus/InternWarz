using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InternWarz.Models;
using InternWarz.Models.Battles;
using InternWarz.Data;

namespace InternWarz.Controllers
{
    public class BattlesController : Controller
    {
        private readonly InternWarzContext _context;

        public BattlesController(InternWarzContext context)
        {
            _context = context;    
        }

        // GET: Battles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Battle.ToListAsync());
        }

        // GET: Battles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battle = await _context.Battle.SingleOrDefaultAsync(m => m.ID == id);
            if (battle == null)
            {
                return NotFound();
            }

            return View(battle);
        }

        // GET: Battles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Battles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Type")] Battle battle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(battle);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(battle);
        }

        // GET: Battles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battle = await _context.Battle.SingleOrDefaultAsync(m => m.ID == id);
            if (battle == null)
            {
                return NotFound();
            }
            return View(battle);
        }

        // POST: Battles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Type")] Battle battle)
        {
            if (id != battle.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(battle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BattleExists(battle.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(battle);
        }

        // GET: Battles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var battle = await _context.Battle.SingleOrDefaultAsync(m => m.ID == id);
            if (battle == null)
            {
                return NotFound();
            }

            return View(battle);
        }

        // POST: Battles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var battle = await _context.Battle.SingleOrDefaultAsync(m => m.ID == id);
            _context.Battle.Remove(battle);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool BattleExists(int id)
        {
            return _context.Battle.Any(e => e.ID == id);
        }
    }
}
