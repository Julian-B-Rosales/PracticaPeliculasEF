using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPeliculas.Entidades
{
    public class AdminPelicula
    {

        DBPeliculasContext context = new DBPeliculasContext();

        public void Insertar(Pelicula pelicula)
        {
            context.Peliculas.Add(pelicula);

            context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            Pelicula pelicula = context.Peliculas.Find(id);
            context.Peliculas.Remove(pelicula);

            context.SaveChanges();
        }

        public List<Pelicula> TraerPorGenero(string genero) 
        {
            List<Pelicula> peliculas = context.Peliculas.Where(pelicula => pelicula.Genero.ToString().ToLower() == genero.ToLower()).ToList();

            return peliculas;

        }

    }
}
