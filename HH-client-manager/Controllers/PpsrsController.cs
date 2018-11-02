﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HHclientmanager.Models;

namespace HH_client_manager.Controllers
{
    public class PpsrsController : Controller
    {
        private readonly ClientManager1Context _context;

        public PpsrsController(ClientManager1Context context)
        {
            _context = context;
        }

        // GET: Ppsrs
        public async Task<IActionResult> Index()
        {
            var clientManager1Context = _context.Ppsr.Include(p => p.Client);
            return View(await clientManager1Context.ToListAsync());
        }

        // GET: Ppsrs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ppsr = await _context.Ppsr
                .Include(p => p.Client)
                .FirstOrDefaultAsync(m => m.PpsrId == id);
            if (ppsr == null)
            {
                return NotFound();
            }

            return View(ppsr);
        }

        // GET: Cfars
        public async Task<IActionResult> ClientInfo(int? id) {
            if (id == null) {
                return NotFound();
            }

            var Ppsr = from m in _context.Ppsr
                      select m;

            Ppsr = Ppsr.Where(s => s.ClientId == Convert.ToInt32(id));

            return View(await Ppsr.ToListAsync());
        }

        // GET: Ppsrs/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId");
            return View();
        }

        // POST: Ppsrs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PpsrId,ClientId,A,B,C,D,E,F,G")] Ppsr ppsr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ppsr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", ppsr.ClientId);
            return View(ppsr);
        }

        // GET: Ppsrs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ppsr = await _context.Ppsr.FindAsync(id);
            if (ppsr == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", ppsr.ClientId);
            return View(ppsr);
        }

        // POST: Ppsrs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PpsrId,ClientId,A,B,C,D,E,F,G")] Ppsr ppsr)
        {
            if (id != ppsr.PpsrId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ppsr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PpsrExists(ppsr.PpsrId))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "ClientId", "ClientId", ppsr.ClientId);
            return View(ppsr);
        }

        // GET: Ppsrs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ppsr = await _context.Ppsr
                .Include(p => p.Client)
                .FirstOrDefaultAsync(m => m.PpsrId == id);
            if (ppsr == null)
            {
                return NotFound();
            }

            return View(ppsr);
        }

        // POST: Ppsrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ppsr = await _context.Ppsr.FindAsync(id);
            _context.Ppsr.Remove(ppsr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PpsrExists(int id)
        {
            return _context.Ppsr.Any(e => e.PpsrId == id);
        }
    }
}
