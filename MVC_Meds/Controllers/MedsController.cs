using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Meds.Models;

namespace MVC_Meds.Controllers
{
    public class MedsController : Controller
    {
        private readonly MVC_MedsContext _context;

        public MedsController(MVC_MedsContext context)
        {
            _context = context;    
        }

        // GET: Meds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Meds.ToListAsync());
        }

        // GET: Meds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meds = await _context.Meds
                .SingleOrDefaultAsync(m => m.ID == id);
            if (meds == null)
            {
                return NotFound();
            }

            return View(meds);
        }

        // GET: Meds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,rxName,rxNumber,rxAmount,doses,dosesLeft,fillDate,refillDate,rxPhone,email,text,acctID")] Meds meds)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meds);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(meds);
        }

        // GET: Meds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meds = await _context.Meds.SingleOrDefaultAsync(m => m.ID == id);
            if (meds == null)
            {
                return NotFound();
            }
            return View(meds);
        }

        // POST: Meds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,rxName,rxNumber,rxAmount,doses,dosesLeft,fillDate,refillDate,rxPhone,email,text,acctID")] Meds meds)
        {
            if (id != meds.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meds);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedsExists(meds.ID))
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
            return View(meds);
        }

        // GET: Meds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meds = await _context.Meds
                .SingleOrDefaultAsync(m => m.ID == id);
            if (meds == null)
            {
                return NotFound();
            }

            return View(meds);
        }

        // POST: Meds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meds = await _context.Meds.SingleOrDefaultAsync(m => m.ID == id);
            _context.Meds.Remove(meds);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool MedsExists(int id)
        {
            return _context.Meds.Any(e => e.ID == id);
        }
    }
}
