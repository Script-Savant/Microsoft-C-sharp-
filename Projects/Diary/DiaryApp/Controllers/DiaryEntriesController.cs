using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db) 
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<DiaryEntry> entries = _db.DiaryEntries.ToList();
            entries.Reverse();

            return View(entries);
        } 

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if  (obj != null && (obj.Title.Length < 3 || obj.Title.Length > 100))
            {
                ModelState.AddModelError("Title", "Title should be between 3 and 100 characters");
            }
            else if (obj != null && (obj.Content.Length < 10 || obj.Content.Length > 400))
            {
                ModelState.AddModelError("Content", "Content should be between 10 and 400 characters");
            }
            else if (!ModelState.IsValid) 
            {
                ModelState.AddModelError("Created", "Error");
            }

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
            
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) 
            {
                return NotFound();
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null) 
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            if (obj != null && (obj.Title.Length < 3 || obj.Title.Length > 100))
            {
                ModelState.AddModelError("Title", "Title should be between 3 and 100 characters");
            }
            else if (obj != null && (obj.Content.Length < 10 || obj.Content.Length > 400))
            {
                ModelState.AddModelError("Content", "Content should be between 10 and 400 characters");
            }
            else if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Created", "Error");
            }

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);

        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
            try
            {
                _db.DiaryEntries.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(obj);
            }

        }

    }
}
