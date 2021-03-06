using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Controllers
{
    public class DondeVerController : Controller
    {
        private readonly ContextoDb _context;

        public DondeVerController(ContextoDb context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var todoDondeVers = await _context.Dondevers.ToListAsync();
            return View(todoDondeVers);
        }
    }
}
