using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Controllers
{
    public class DirectorController : Controller
    {

        private readonly ContextoDb _context;

        public DirectorController(ContextoDb context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var TodoDirectores = await _context.Directores.ToListAsync();
            return View(TodoDirectores);
        }
    }
}
