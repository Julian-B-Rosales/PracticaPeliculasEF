using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPeliculas.Entidades
{
    public class AdminClasificacion
    {

        DBPeliculasContext context = new DBPeliculasContext();

        public Clasificacion FindByName(string tipo)
        {
            List<Clasificacion> clasificadas = context.Clasificaciones.Where(clasificacion => clasificacion.Tipo == tipo).ToList();
            if (clasificadas.Count() == 0)
            {
                Clasificacion nueva = new Clasificacion() { Tipo = tipo, Id = (context.Clasificaciones.ToList().Count() + 1) };
                context.Clasificaciones.Add(nueva);
                context.SaveChanges();
                return nueva;
            }
            else
            {
                return clasificadas.FirstOrDefault();
            }
        }

    }
}
