using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Models
{
    public class Director
    {
        //key Id
        [Key]
        public int Id { get; set; }
        //propiedades tabla Director
        [Display(Name = "Foto de perfil")]

        public string FotoPerfil { get; set; }

        public string Nombre { get; set; }

        public string Biografia { get; set; }

        //relaciones db

        public List<Pelicula> Peliculas { get; set; }
    }
}
