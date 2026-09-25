using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using zCoach.Entities.ThaiNH.Models;
using zCoach.Repositories.ThaiNH.DbContext;
using zCoach.Services.ThaiNH;

namespace zCoach.MVCWebApp.ThaiNH.Controllers
{
    public class CoachThaiNhController : Controller
    {
        //private readonly PRN222Context _context;
        private readonly ICoachThaiNhService _transactionCoachService;
        private readonly ISpecializationThaiNhService _specializationThaiNhService;

        public CoachThaiNhController(ICoachThaiNhService transactionCoachService, ISpecializationThaiNhService specializationThaiNhService)
        => (_transactionCoachService, _specializationThaiNhService) = (transactionCoachService, specializationThaiNhService);


        public async Task<IActionResult> Index()
        {
            var items = await _transactionCoachService.GetAllAsync();
            return View(items);
        }
        /*
        // GET: CoachThaiNh/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coachThaiNh = await _context.CoachThaiNhs
                .Include(c => c.SpecializationThaiNh)
                .FirstOrDefaultAsync(m => m.CoachThaiNhid == id);
            if (coachThaiNh == null)
            {
                return NotFound();
            }

            return View(coachThaiNh);
        }
        
        // GET: CoachThaiNh/Create
        public IActionResult Create()
        {
            ViewData["SpecializationThaiNhid"] = new SelectList(_context.SpecializationThaiNhs, "SpecializationThaiNhid", "SpecializationName");
            return View();
        }

        // POST: CoachThaiNh/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CoachThaiNhid,FullName,Email,Phone,DateOfBirth,Gender,Address,ImageUrl,Experience,Certification,Salary,HireDate,Status,PublishDate,UpdateAt,SpecializationThaiNhid,IsActive")] CoachThaiNh coachThaiNh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coachThaiNh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SpecializationThaiNhid"] = new SelectList(_context.SpecializationThaiNhs, "SpecializationThaiNhid", "SpecializationName", coachThaiNh.SpecializationThaiNhid);
            return View(coachThaiNh);
        }

        // GET: CoachThaiNh/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coachThaiNh = await _context.CoachThaiNhs.FindAsync(id);
            if (coachThaiNh == null)
            {
                return NotFound();
            }
            ViewData["SpecializationThaiNhid"] = new SelectList(_context.SpecializationThaiNhs, "SpecializationThaiNhid", "SpecializationName", coachThaiNh.SpecializationThaiNhid);
            return View(coachThaiNh);
        }

        // POST: CoachThaiNh/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CoachThaiNhid,FullName,Email,Phone,DateOfBirth,Gender,Address,ImageUrl,Experience,Certification,Salary,HireDate,Status,PublishDate,UpdateAt,SpecializationThaiNhid,IsActive")] CoachThaiNh coachThaiNh)
        {
            if (id != coachThaiNh.CoachThaiNhid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coachThaiNh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoachThaiNhExists(coachThaiNh.CoachThaiNhid))
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
            ViewData["SpecializationThaiNhid"] = new SelectList(_context.SpecializationThaiNhs, "SpecializationThaiNhid", "SpecializationName", coachThaiNh.SpecializationThaiNhid);
            return View(coachThaiNh);
        }

        // GET: CoachThaiNh/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coachThaiNh = await _context.CoachThaiNhs
                .Include(c => c.SpecializationThaiNh)
                .FirstOrDefaultAsync(m => m.CoachThaiNhid == id);
            if (coachThaiNh == null)
            {
                return NotFound();
            }

            return View(coachThaiNh);
        }

        // POST: CoachThaiNh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coachThaiNh = await _context.CoachThaiNhs.FindAsync(id);
            if (coachThaiNh != null)
            {
                _context.CoachThaiNhs.Remove(coachThaiNh);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoachThaiNhExists(int id)
        {
            return _context.CoachThaiNhs.Any(e => e.CoachThaiNhid == id);
        }
        */
    }
}
