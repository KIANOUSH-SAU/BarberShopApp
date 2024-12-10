using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarberShopApp.Web.Data;

namespace BarberShopApp.Web.Controllers
{
    public class LoginTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LoginTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoginTypes.ToListAsync());
        }

        // GET: LoginTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginType = await _context.LoginTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loginType == null)
            {
                return NotFound();
            }

            return View(loginType);
        }

        // GET: LoginTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoginTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Role")] LoginType loginType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loginType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loginType);
        }


        private bool LoginTypeExists(int id)
        {
            return _context.LoginTypes.Any(e => e.Id == id);
        }
    }
}
