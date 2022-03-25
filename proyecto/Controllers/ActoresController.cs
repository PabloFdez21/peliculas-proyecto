using Microsoft.AspNetCore.Mvc;
using proyecto.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Controllers
{
    public class ActoresController : Controller
    {

        private readonly ContextoDb _context;

        public ActoresController(ContextoDb context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Actores.ToList();
            return View(data);

            //data es simplemente la lista de los actores
        }
    }
}
