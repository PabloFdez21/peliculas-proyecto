using proyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Models
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }

        public string NombrePelicula { get; set; }
        public string DescripcionPelicula { get; set; }
        public string Caratula { get; set; }
        public DateTime Estreno { get; set; }
        public CategoriaPelicula CategoriaPelicula { get; set; }

        // relaciones db

        //uno a muchos y muchos a muchos. 

        public List<Actor_Pelicula> Actor_Pelciulas { get; set; }

        //Donde Ver

        public int DondeVerId { get; set; }
        
        [ForeignKey("DondeVerId")]

        public DondeVer DondeVer { get; set; }

        //productor

        public int DirectorId { get; set; }

        [ForeignKey("DirectorId")]

        public Director Director { get; set; }


    }
}
