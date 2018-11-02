using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HHclientmanager.Models;

namespace HH_client_manager.Controllers
{
    public class PclsController : Controller
    {
        private readonly ClientManager1Context _context;

        public PclsController(ClientManager1Context context)
        {
            _context = context;
        }

        // GET: Pcls
        public async Task<IActionResult> Index()
        {
            var clientManager1Context = _context.Pcl.Include(p => p.Client);
            return View(await clientManager1Context.ToListAsync());
        }

        // GET: Pcls
        public async Task<IActionResult> ClientInfo(int? id) {
            if (id == null) {
                return NotFound();
            }

            var Pcl = from m in _context.Pcl
                       select m;

            Pcl = Pcl.Where(s => s.ClientId == Convert.ToInt32(id));

            return View(await Pcl.ToListAsync());
        }

        // GET: Pcls
        public async Task<IActionResult> ClientCompare(int? id) {
            if (id == null) {
                return NotFound();
            }

            var Pcl2 = from m in _context.Pcl
                        select m;

            Pcl2 = Pcl2.Where(m => m.ClientId == Convert.ToInt32(id));
            if (Pcl2.Count() == 0) {
                return NotFound();
            }
            var max = 0;
            foreach (var ass in Pcl2) {
                if (ass.PclId > max) {
                    max = ass.PclId;
                }
            }
            Pcl Pcl3 = await _context.Pcl
                .Include(c => c.Client)
                .FirstOrDefaultAsync(m => m.PclId == max);

            var Pcl = _context.Pcl.Include(c => c.Client);

            double s = 0;

            foreach (var ass in Pcl) {
                s += ass.SeverityScore;
            }
            s = s / Pcl.Count();

            ViewBag.SeverityScore = s;

            return View(Pcl3);
        }

        // GET: Pcls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pcl = await _context.Pcl
                .Include(p => p.Client)
                .FirstOrDefaultAsync(m => m.PclId == id);
            if (pcl == null)
            {
                return NotFound();
            }

            return View(pcl);
        }

        // GET: Pcls/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId");
            return View();
        }

        // POST: Pcls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PclId,ClientId,SeverityScore")] Pcl pcl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pcl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", pcl.ClientId);
            return View(pcl);
        }

        // GET: Pcls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pcl = await _context.Pcl.FindAsync(id);
            if (pcl == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", pcl.ClientId);
            return View(pcl);
        }

        // POST: Pcls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PclId,ClientId,SeverityScore")] Pcl pcl)
        {
            if (id != pcl.PclId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pcl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PclExists(pcl.PclId))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", pcl.ClientId);
            return View(pcl);
        }

        // GET: Pcls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pcl = await _context.Pcl
                .Include(p => p.Client)
                .FirstOrDefaultAsync(m => m.PclId == id);
            if (pcl == null)
            {
                return NotFound();
            }

            return View(pcl);
        }

        // POST: Pcls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pcl = await _context.Pcl.FindAsync(id);
            _context.Pcl.Remove(pcl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PclExists(int id)
        {
            return _context.Pcl.Any(e => e.PclId == id);
        }
    }
}
