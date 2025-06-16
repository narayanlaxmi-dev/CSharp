using EFDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp9.Data;
using WebApp9.Models;

namespace WebApp9.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDBContext _context;

        public UserController(AppDBContext context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            var users = await _context.User
                .Include(u => u.Profile)
                .ToListAsync();

            var model = users.Select(u => new UserProfileViewModel
            {
                Id = u.UserId,
                UserEmail = u.UserEmail,
                Password = u.Password,
                UserFullName = u.Profile?.UserFullName,
                Age = u.Profile?.Age,
                Bio = u.Profile?.Bio
            }).ToList();

            return View(model);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserProfileViewModel u)
        {
            var user = new User
            {
                UserEmail = u.UserEmail,
                Password = u.Password,
                Profile = new UserProfile
                {
                    UserFullName = u.UserFullName,
                    Age = u.Age,
                    Bio = u.Bio
                }
            };

            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var user = await _context.User.Include(u => u.Profile)
                                          .FirstOrDefaultAsync(u => u.UserId == id);

            if (user == null) return NotFound();

            var viewModel = new UserProfileViewModel
            {
                Id = user.UserId,
                UserEmail = user.UserEmail,
                Password = user.Password,
                UserFullName = user.Profile?.UserFullName,
                Age = user.Profile?.Age,
                Bio = user.Profile?.Bio
            };

            return View(viewModel);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UserProfileViewModel model)
        {
            var user = await _context.User.Include(u => u.Profile)
                                          .FirstOrDefaultAsync(u => u.UserId == id);

            if (user == null) return NotFound();

            user.UserEmail = model.UserEmail;
            user.Password = model.Password;

            if (user.Profile != null)
            {
                user.Profile.UserFullName = model.UserFullName;
                user.Profile.Age = model.Age;
                user.Profile.Bio = model.Bio;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _context.User.Include(u => u.Profile)
                                          .FirstOrDefaultAsync(u => u.UserId == id);

            if (user == null) return NotFound();

            var viewModel = new UserProfileViewModel
            {
                Id = user.UserId,
                UserEmail = user.UserEmail,
                Password = user.Password,
                UserFullName = user.Profile?.UserFullName,
                Age = user.Profile?.Age,
                Bio = user.Profile?.Bio
            };

            return View(viewModel);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.Include(u => u.Profile)
                                          .FirstOrDefaultAsync(u => u.UserId == id);
            if (user != null)
            {
                _context.User.Remove(user);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
