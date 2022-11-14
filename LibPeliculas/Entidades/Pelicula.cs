namespace LibPeliculas.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("Pelicula")]
    public partial class Pelicula
    {
        public int Id { get; set; }

        public int ClasificacionId { get; set; }

        public int GeneroId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime FechaEstreno { get; set; }

        [Required]
        public int CantidadMinutos { get; set; }

        [Required]
        public string Idioma { get; set; }

        public string Sinopsis { get; set; }

        public virtual Genero Genero { get; set; }

        public virtual Clasificacion Clasificacion { get; set; }
    }
}
