//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibPeliculas.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pelicula
    {
        public int Id { get; set; }
        public int ClasificacionId { get; set; }
        public int GeneroId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string CantidadMinutos { get; set; }
        public string Idioma { get; set; }
        public string Sinopsis { get; set; }
    
        public virtual Clasificacion Clasificacion { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
