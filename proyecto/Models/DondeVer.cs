using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Models
{
    public class DondeVer
    {
        [Key]

        public int Id { get; set; }


        public string Logo { get; set; }
        public string Nombre { get; set; }
        public string url { get; set; }


        //relaciones db

        public List<Pelicula> Peliculas { get; set; }
    }

}
