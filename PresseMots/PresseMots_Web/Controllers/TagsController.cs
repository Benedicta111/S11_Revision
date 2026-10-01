using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PresseMots.Models;
using PresseMots.Models.Data;

namespace PresseMots.Controllers
{
    public class TagsController : Controller
    {
        private readonly PresseMotsDbContext _context;

        public TagsController(PresseMotsDbContext context)
        {
            _context = context;
        }

        // GET: Tags
        public async Task<IActionResult> Index()
        {
              return View(/*...*/);
        }

        // GET: Tags/Create
        public IActionResult Create()
        {
            var tag = _context.Tags.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value=t.Id.ToString(),
                

            });

            



            return View(tag);
        }

        // POST: Tags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Tag tag)
        {
            if (ModelState.IsValid)
            {
                _context.Tags.Add(tag);
                _context.SaveChanges();
                TempData["Success"] = $"Tag {tag.Name} added";
                return this.RedirectToAction("Index");

            }
            var tags = _context.Tags.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString(),


            });
            return View(tags);
        }

        // GET: Tags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var tag = _context.Tags.Find(id);

            var tags = _context.Tags.Select(t => new SelectListItem
            {
                Text = t.Name,
                Value = t.Id.ToString(),


            });

            return View(tags);
        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tag = _context.Tags.Find(id);
            if (tag == null)
            {
                return NotFound();
            }
            _context.Tags.Remove(tag);
            _context.SaveChanges();
            TempData["Success"] = $"Tag {tag.Name} terminated";
            return RedirectToAction("Index");


            return RedirectToAction(nameof(Index));
        }
    }
}
