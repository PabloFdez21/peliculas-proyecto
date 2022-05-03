using Microsoft.AspNetCore.Mvc;
using proyecto.Datos;
using proyecto.Datos.Servicios;
using proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Controllers
{
    public class ActoresController : Controller
    {

        private readonly IServicioActores _servicio;

        public ActoresController(IServicioActores servicio)
        {
            servicio = servicio;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _servicio.GetAllAsync();
            return View(data);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Nombre,FotoPerfil,Biografia")] Actores actores)
        {
            if (!ModelState.IsValid)
            {
                return View(actores);
            }
            await _servicio.AddAsync(actores);
            return RedirectToAction(nameof(Index));
        }
    }
}
