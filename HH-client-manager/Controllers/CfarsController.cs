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
    public class CfarsController : Controller
    {
        private readonly ClientManager1Context _context;

        public CfarsController(ClientManager1Context context)
        {
            _context = context;
        }

        // GET: Cfars
        public async Task<IActionResult> Index()
        {
            var clientManager1Context = _context.Cfar.Include(c => c.Client);
            return View(await clientManager1Context.ToListAsync());
        }

        // GET: Cfars
        public async Task<IActionResult> ClientInfo(int? id) {
            if (id == null) {
                return NotFound();
            }

            var Cfar = from m in _context.Cfar
                          select m;

            Cfar = Cfar.Where(s => s.ClientId == Convert.ToInt32(id));
            
            return View(await Cfar.ToListAsync());
        }

        // GET: Cfars
        public async Task<IActionResult> ClientCompare(int? id) {
            if (id == null) {
                return NotFound();
            }

            var Cfar2 = from m in _context.Cfar
                       select m;

            Cfar2 = Cfar2.Where(s => s.ClientId == Convert.ToInt32(id));

            var max = 0;
            foreach (var ass in Cfar2) {
                if (ass.CfarId > max) {
                    max = ass.CfarId;
                }
            }
            Cfar Cfar3 = await _context.Cfar
                .Include(c => c.Client)
                .FirstOrDefaultAsync(m => m.CfarId == max);
            
            var Cfar = _context.Cfar.Include(c => c.Client);
            
            double ts = 0;
            double d = 0;
            double a = 0;
            double ei = 0;

            foreach (var ass in Cfar) 
            {
                a += ass.Anxiety;
                ts += ass.TraumaticStress;
                d += ass.Depression;
                ei += ass.EmotionalityIndex;
            }
            a = a / Cfar.Count();
            ts = ts / Cfar.Count();
            d = d / Cfar.Count();
            ei = ei / Cfar.Count();

            ViewBag.Anxiety = a;
            ViewBag.Trauma = ts;
            ViewBag.Depression = d;
            ViewBag.Emotional = ei;

            return View(Cfar3);
        }

        // GET: Cfars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cfar = await _context.Cfar
                .Include(c => c.Client)
                .FirstOrDefaultAsync(m => m.ClientId == id);
            if (cfar == null)
            {
                return NotFound();
            }

            return View(cfar);
        }

        // GET: Cfars/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId");
            return View();
        }

        // POST: Cfars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CfarId,ClientId,Anxiety,TraumaticStress,Depression,EmotionalityIndex")] Cfar cfar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cfar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", cfar.ClientId);
            return View(cfar);
        }

        // GET: Cfars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cfar = await _context.Cfar.FindAsync(id);
            if (cfar == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", cfar.ClientId);
            return View(cfar);
        }

        // POST: Cfars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CfarId,ClientId,Anxiety,TraumaticStress,Depression,EmotionalityIndex")] Cfar cfar)
        {
            if (id != cfar.CfarId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cfar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CfarExists(cfar.CfarId))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", cfar.ClientId);
            return View(cfar);
        }

        // GET: Cfars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cfar = await _context.Cfar
                .Include(c => c.Client)
                .FirstOrDefaultAsync(m => m.CfarId == id);
            if (cfar == null)
            {
                return NotFound();
            }

            return View(cfar);
        }

        // POST: Cfars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cfar = await _context.Cfar.FindAsync(id);
            _context.Cfar.Remove(cfar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CfarExists(int id)
        {
            return _context.Cfar.Any(e => e.CfarId == id);
        }
    }
}
