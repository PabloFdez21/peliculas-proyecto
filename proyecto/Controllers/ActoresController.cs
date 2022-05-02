using Microsoft.AspNetCore.Mvc;
using proyecto.Datos;
using proyecto.Datos.Servicios;
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
            _servicio = servicio;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _servicio.GetAllAsync();
            return View(data);
        }
        public async Task<IActionResult> Crear() {
            return View();
        }
    }
}
