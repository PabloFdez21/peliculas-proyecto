using Microsoft.EntityFrameworkCore;
using proyecto.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Datos.Servicios
{
    public class ServicioActores : IServicioActores
    {
        //CONSTRUCTOR 
        private readonly ContextoDb _context;
        public ServicioActores(ContextoDb contexto)
        {
            _context = contexto;
        }
        public void Aniadir(Actores actores)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actores>> GetAllAsync()
        {
            var resultado = await _context.Actores.ToListAsync();  
            return resultado;
        }

        public Actores GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actores Update(int id, Actores newActores)
        {
            throw new System.NotImplementedException();
        }
    }
}
