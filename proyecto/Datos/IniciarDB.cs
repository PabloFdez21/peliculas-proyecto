
using proyecto.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto.Datos
{
    public class IniciarDB
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ContextoDb>();
                //nos aseguramos de que esta creada
                context.Database.EnsureCreated();

                //añadimos donde ver, actores, director, peliculas...

                if (!context.Dondevers.Any())
                {
                    // donde ver

                    context.Dondevers.AddRange(new List<DondeVer>() {
                        new DondeVer(){
                            Nombre = "Netflix",
                            Logo = "https://brandemia.org/sites/default/files/sites/default/files/icono_netflix_nuevo.jpg",
                            url = "https://www.netflix.com"

                        },

                        new DondeVer(){
                            Nombre = "Amazon Prime",
                            Logo = "https://m.media-amazon.com/images/G/01/support_images/GUID-A5E374A8-16DA-4B39-8E3F-3F3B34E831FB=2=es-ES=Normal.png",
                            url = "https://www.primevideo.com"

                        },

                         new DondeVer(){
                            Nombre = "HBO",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/de/HBO_logo.svg/2560px-HBO_logo.svg.png",
                            url = "https://www.hbo.com"

                        },
                          new DondeVer(){
                            Nombre = "Youtube",
                            Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Logo_of_YouTube_%282015-2017%29.svg/502px-Logo_of_YouTube_%282015-2017%29.svg.png",
                            url = "www.youtube.com"

                        }
                    });
                    context.SaveChanges();
                }

                //actores

                if (!context.Actores.Any())
                {
                    context.Actores.AddRange(new List<Actores>()
                    {


                     new Actores()
                    {
                        Nombre = "Tom Holland",
                        FotoPerfil = "https://marvin.com.mx/wp-content/uploads/2019/08/noel-gallagher-entrevista-madre-liam-2019.jpg",
                        Biografia = "Bio simple"

                    },

                     new Actores()
                     {
                        Nombre = "Samuel L Jackson",
                        FotoPerfil = "https://es.web.img2.acsta.net/pictures/15/07/27/12/24/354255.jpg",
                        Biografia = "Bio Simple 2"
                     },

                      new Actores()
                     {
                        Nombre = "Leonardo Di caprio",
                        FotoPerfil = "https://img.huffingtonpost.com/asset/60eeba4e3b0000155cecbf42.jpg?cache=spKOFqdaLg&ops=scalefit_720_noupscale",
                        Biografia = "Bio Simple 3"
                     },

                       new Actores()
                     {
                        Nombre = "Patrick Wilson",
                        FotoPerfil = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/Patrick_Wilson_MFF_2016.jpg/800px-Patrick_Wilson_MFF_2016.jpg",
                        Biografia = "Bio Simple 4"
                     },

                        new Actores()
                     {
                        Nombre = "Jose Luis Gil",
                        FotoPerfil = "http://t3.gstatic.com/licensed-image?q=tbn:ANd9GcT7HASjsh-HM1x08pKAJcRkU1Lg96DZyhKNi8n4aw5eLCssXc0ScUXrEOstUqgg",
                        Biografia = "Bio Simple 5"
                     }

                });
                    context.SaveChanges();

                }


                //directores

                if (!context.Directores.Any())
                {
                    context.Directores.AddRange(new List<Director>()
                    {
                    new Director()
                    {
                        Nombre = "Martin Scorsese",
                        FotoPerfil = "https://as01.epimg.net/meristation/imagenes/2021/08/22/reportajes/1629583520_865544_1629583728_noticia_normal.jpg",
                        Biografia = "Bio simple director"
                    },

                     new Director()
                    {
                        Nombre = "Stanley Kubrick",
                        FotoPerfil = "https://indiehoy.com/wp-content/uploads/2022/01/stanley-kubrick-1200x675.jpg",
                        Biografia = "Bio simple director 2 "
                    },

                      new Director()
                    {
                        Nombre = "Steven Spilberg",
                        FotoPerfil = "http://t3.gstatic.com/licensed-image?q=tbn:ANd9GcTy15xLjdDpshk7blXFSb7FjXmh7Y3Z93QrEUGnxDyEMqEUfBbXY-IjRlrFpixk",
                        Biografia = "Bio simple director 3"
                    },

                       new Director()
                    {
                        Nombre = "Quentin Tarantino",
                        FotoPerfil = "http://t1.gstatic.com/licensed-image?q=tbn:ANd9GcT7FR3_4uCQQdvUjlsXmjN38uwP7J40Icgfii8ssna6dMQzze704tcNwWSNfbKI",
                        Biografia = "Bio simple director 4"
                    },

                        new Director()
                    {
                        Nombre = "Pedro Almodovar",
                        FotoPerfil = "http://t1.gstatic.com/licensed-image?q=tbn:ANd9GcR8Bq9U-JSCg8dnZav3DdFPk-GzWCSdbxds979aZqVnAcFNlZ6bdP8X8FCt6vph",
                        Biografia = "Bio simple director 5"
                    }
                    });

                    context.SaveChanges();

                }

                //peliculas

                if (!context.Peliculas.Any())
                {
                    context.Peliculas.AddRange(new List<Pelicula>()
                    {

                    new Pelicula()
                    {
                        NombrePelicula = "Insidious",
                        DescripcionPelicula = "bio simple pelicula 1",
                        Caratula = "https://es.web.img3.acsta.net/pictures/14/05/07/09/01/306626.jpg",
                        Estreno = DateTime.Today,
                        CategoriaPelicula = CategoriaPelicula.Terror,
                        DondeVerId = 1,
                        DirectorId = 1
                    }
                    });

                    context.SaveChanges();

                }

                //Actores_Peliculas

                if (!context.Actores_Peliculas.Any())
                {
                    context.Actores_Peliculas.AddRange(new List<Actor_Pelicula>()
                    {
                    new Actor_Pelicula(){
                    ActorId = 4,
                    PeliculaId = 1
                    }
                    });
                    context.SaveChanges();

                }



            }
        }
    }
}
