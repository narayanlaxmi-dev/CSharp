using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FeedBackLabExam.Data;
using FeedBackLabExam.Models;

namespace FeedBackLabExam.Controllers
{
    public class FeedbacksController : Controller
    {
        private readonly AppDbContext _context;

        public FeedbacksController(AppDbContext context)
        {
            _context = context;
        }

        // get all list displayed
        public async Task<IActionResult> Index()
        {
            return View(await _context.Feedback.ToListAsync());
        }


        // get by id
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound("Not Found By This Id");
            var feedback = await _context.Feedback
                .FirstOrDefaultAsync(m => m.FeedbackId == id); // first or default async
                                                               // to handle first=value present default not found behaviour handle
            if (feedback == null)
                return NotFound("Feedback not found");
            return View(feedback);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // CSRF prevent 
        public async Task<IActionResult> Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedback);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feedback);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound("Not Found By Id to Edit the Data");
            var feedback = await _context.Feedback.FindAsync(id);
            if (feedback == null)
                return NotFound("For this Id Feedback Not Present");

            return View(feedback);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Feedback feedback)
        {
            if (id != feedback.FeedbackId)
                return NotFound("This feedBack Id not present in DataBase");

            if (ModelState.IsValid)
            {
                _context.Update(feedback);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feedback);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound("ID Not Found To Deleted");
            var feedback = await _context.Feedback
                .FirstOrDefaultAsync(m => m.FeedbackId == id); 
            if (feedback == null)
                return NotFound("For this Id Feedback Not Present");
            return View(feedback);
        }

        [HttpPost, ActionName("Delete")] // change name to redirect Delete
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var feedback = await _context.Feedback.FindAsync(id);
            if (feedback != null)            
                _context.Feedback.Remove(feedback);
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
