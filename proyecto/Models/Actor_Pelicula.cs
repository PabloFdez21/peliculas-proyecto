using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Models
{
    public class Actor_Pelicula
    {
        //union db

        //foreign key
        public int PeliculaId { get; set; }
        //foreign key

        public int ActorId { get; set; }


        public  Pelicula Pelicula { get; set; }

        public Actores Actor { get; set; }
    }
}
