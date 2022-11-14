using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPeliculas.Entidades
{
    public class AdminGenero
    {

        DBPeliculasContext context = new DBPeliculasContext();

        public Genero FindByName(string name)
        {
            List<Genero> lista = context.Generos.Where(genero => genero.Nombre == name).ToList();
            if (lista.Count() == 0)
            {
                Genero nuevo = new Genero() { Nombre = name, Id = (context.Generos.ToList().Count() + 1) };
                context.Generos.Add(nuevo);
                context.SaveChanges();
                return nuevo;
            }
            else
            {
                return lista.FirstOrDefault();
            }
        }

    }
}
