using proyecto.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace proyecto.Datos.Servicios
{
    public interface IServicioActores
    {
        Task<IEnumerable<Actores>> GetAll();

        Actores GetById(int id);
        void Aniadir(Actores actores);
        Actores Update(int id, Actores newActores);
        void Delete(int id);
        Task GetAllAsync();
        Task AddAsync(Actores actores);
    }
}
