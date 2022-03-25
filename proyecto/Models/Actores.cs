using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Models
{
    public class Actores
    {
        //key Id
        [Key]
        public int Id { get; set; }
        //propiedades tabla actor
        [Display(Name = "Foto de perfil")]

        public string FotoPerfil { get; set; }
        public string Nombre { get; set; }

        public string Biografia { get; set; }

        //relacioens db

        public List<Actor_Pelicula> Actor_Peliculas { get; set; }
    }
}
