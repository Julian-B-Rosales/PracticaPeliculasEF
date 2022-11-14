using LibPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AdminClasificacion adminClasificacion = new AdminClasificacion();
        AdminGenero adminGenero = new AdminGenero();
        AdminPelicula adminPelicula = new AdminPelicula();

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            

            pelicula.Id = Convert.ToInt32(txtId.Text);
            pelicula.Nombre = txtNombre.Text;
            pelicula.Clasificacion = adminClasificacion.FindByName(txtClasificacion.Text);
            pelicula.FechaEstreno = DateTime.Parse(txtFechaEstreno.Text);
            pelicula.CantidadMinutos = Convert.ToInt32(txtDuracion.Text);
            pelicula.Genero = adminGenero.FindByName(txtGenero.Text);
            pelicula.Idioma = txtIdioma.Text;
            pelicula.Sinopsis= txtSinopsis.Text;

            adminPelicula.Insertar(pelicula);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            adminPelicula.Eliminar(Convert.ToInt32(txtId.Text));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Pelicula> peliculas = adminPelicula.TraerPorGenero(txtTraerPorGenero.Text);
            gridPeliculas.DataSource = peliculas;


        }
    }
}
