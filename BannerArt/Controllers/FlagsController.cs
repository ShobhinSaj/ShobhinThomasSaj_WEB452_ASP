using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BannerArt.Data;
using BannerArt.Models;

namespace BannerArt.Controllers
{
    public class FlagsController : Controller
    {
        private readonly BannerArtContext _context;

        public FlagsController(BannerArtContext context)
        {
            _context = context;
        }

        // GET: Flags
        public async Task<IActionResult> Index()
        {
            return View(await _context.Flag.ToListAsync());
        }

        // GET: Flags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flag = await _context.Flag
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flag == null)
            {
                return NotFound();
            }

            return View(flag);
        }

        // GET: Flags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Flags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FlagName,DesignerName,Material,Size,ReleaseDate,Price,CustomerReview")] Flag flag)
        {
            if (ModelState.IsValid)
            {
                double customerReview = flag.CustomerReview;                //Get rating based on customer review
                if (customerReview <= 1.5)
                {
                    flag.Rating = "Below Average";
                }
                else if (customerReview >= 1.5 && customerReview <= 3)
                {
                    flag.Rating = " Average";
                }
                else
                {
                    flag.Rating = "Excellent";
                }
                _context.Add(flag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flag);
        }

        // GET: Flags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flag = await _context.Flag.FindAsync(id);
            if (flag == null)
            {
                return NotFound();
            }
            return View(flag);
        }

        // POST: Flags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FlagName,DesignerName,Material,Size,ReleaseDate,Price,CustomerReview")] Flag flag)
        {
            if (id != flag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                double customerReview = flag.CustomerReview;            //Get rating based on customer review
                if (customerReview <= 1.5)
                {
                    flag.Rating = "Below Average";
                }
                else if (customerReview >= 1.5 && customerReview <= 3.9)
                {
                    flag.Rating = " Average";
                }
                else
                {
                    flag.Rating = "Excellent";
                }
                try
                {
                    _context.Update(flag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlagExists(flag.Id))
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
            return View(flag);
        }

        // GET: Flags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flag = await _context.Flag
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flag == null)
            {
                return NotFound();
            }

            return View(flag);
        }

        // POST: Flags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flag = await _context.Flag.FindAsync(id);
            _context.Flag.Remove(flag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlagExists(int id)
        {
            return _context.Flag.Any(e => e.Id == id);
        }
    }
}
