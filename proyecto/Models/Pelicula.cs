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
        [Display(Name = "Titulo")]
        public string NombrePelicula { get; set; }
        [Display(Name = "Descripcion")]
        public string DescripcionPelicula { get; set; }
        [Display(Name = "Caratula")]

        public string Caratula { get; set; }
        [Display(Name = "Fecha de estreno")]

        public DateTime Estreno { get; set; }
        [Display(Name = "Categoria")]

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
