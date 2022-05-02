using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Controllers
{
    public class PeliculaController : Controller
    {
        private readonly ContextoDb _context;

        public PeliculaController(ContextoDb context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var TodoPeliculas = await _context.Peliculas.ToListAsync();
            return View(TodoPeliculas);
        }
    }
}
