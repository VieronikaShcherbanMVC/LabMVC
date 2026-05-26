using Microsoft.AspNetCore.Mvc;
using HomeworkManager.Models;
using HomeworkManager.Data;
using Microsoft.EntityFrameworkCore;

namespace HomeworkManager.Controllers
{
    public class TasksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TasksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string status)
        {
            var tasksQuery = _context.HomeworkTasks.AsQueryable();

            if (!string.IsNullOrEmpty(status))
            {
                tasksQuery = tasksQuery.Where(t => t.Status == status);
            }

            var tasks = await tasksQuery.ToListAsync();

            ViewBag.SelectedStatus = status;

            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(HomeworkTask task)
        {
            if (ModelState.IsValid)
            {
                _context.HomeworkTasks.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(task);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var task = await _context.HomeworkTasks.FindAsync(id);

            if (task == null)
            {
                return NotFound();
            }

            return View(task);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(HomeworkTask task)
        {
            if (ModelState.IsValid)
            {
                _context.HomeworkTasks.Update(task);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(task);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var task = await _context.HomeworkTasks.FindAsync(id);

            if (task != null)
            {
                _context.HomeworkTasks.Remove(task);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}