using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcFriendsSite.Data;
using MvcFriendsSite.Models;

namespace MvcFriendsSite.Controllers
{
    public class SocialModelsController : Controller
    {
        private readonly MvcFriendsSiteContext _context;

        public SocialModelsController(MvcFriendsSiteContext context)
        {
            _context = context;
        }


        // GET: SocialModels
        public async Task<IActionResult> Index(string searchString)
        {

            var friends = from m in _context.SocialModel
                          select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                friends = friends.Where(s => s.userName.Contains(searchString));
            }

            return View(await friends.ToListAsync());

        }

        // GET: SocialModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialModel = await _context.SocialModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialModel == null)
            {
                return NotFound();
            }

            return View(socialModel);
        }

        // GET: SocialModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SocialModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,userName,email,profilePicUrl,friendsEmail")] SocialModel socialModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(socialModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(socialModel);
        }

        // GET: SocialModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialModel = await _context.SocialModel.FindAsync(id);
            if (socialModel == null)
            {
                return NotFound();
            }
            return View(socialModel);
        }

        // POST: SocialModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,userName,email,profilePicUrl,friendsEmail")] SocialModel socialModel)
        {
            if (id != socialModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(socialModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SocialModelExists(socialModel.Id))
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
            return View(socialModel);
        }

        // GET: SocialModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var socialModel = await _context.SocialModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (socialModel == null)
            {
                return NotFound();
            }

            return View(socialModel);
        }

        // POST: SocialModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var socialModel = await _context.SocialModel.FindAsync(id);
            _context.SocialModel.Remove(socialModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SocialModelExists(int id)
        {
            return _context.SocialModel.Any(e => e.Id == id);
        }
    }
}
