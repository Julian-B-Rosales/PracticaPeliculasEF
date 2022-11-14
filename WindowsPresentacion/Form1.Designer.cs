namespace WindowsPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.txtFechaEstreno = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.lblTraerPorGenero = new System.Windows.Forms.Label();
            this.txtTraerPorGenero = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridPeliculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(42, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(42, 100);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(83, 16);
            this.lblClasificacion.TabIndex = 0;
            this.lblClasificacion.Text = "Clasificacion";
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(147, 97);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(100, 22);
            this.txtClasificacion.TabIndex = 1;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(12, 128);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(113, 16);
            this.lblFechaEstreno.TabIndex = 0;
            this.lblFechaEstreno.Text = "Fecha de Estreno";
            // 
            // txtFechaEstreno
            // 
            this.txtFechaEstreno.Location = new System.Drawing.Point(147, 125);
            this.txtFechaEstreno.Name = "txtFechaEstreno";
            this.txtFechaEstreno.Size = new System.Drawing.Size(100, 22);
            this.txtFechaEstreno.TabIndex = 1;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(12, 164);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(128, 16);
            this.lblDuracion.TabIndex = 0;
            this.lblDuracion.Text = "Duracion en Minutos";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(147, 161);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(100, 22);
            this.txtDuracion.TabIndex = 1;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(42, 225);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(48, 16);
            this.lblIdioma.TabIndex = 0;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(42, 192);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 16);
            this.lblGenero.TabIndex = 0;
            this.lblGenero.Text = "Genero";
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(147, 222);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(100, 22);
            this.txtIdioma.TabIndex = 1;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(42, 253);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(59, 16);
            this.lblSinopsis.TabIndex = 0;
            this.lblSinopsis.Text = "Sinopsis";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(147, 189);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 22);
            this.txtGenero.TabIndex = 1;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(147, 250);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(100, 22);
            this.txtSinopsis.TabIndex = 1;
            // 
            // lblTraerPorGenero
            // 
            this.lblTraerPorGenero.AutoSize = true;
            this.lblTraerPorGenero.Location = new System.Drawing.Point(13, 313);
            this.lblTraerPorGenero.Name = "lblTraerPorGenero";
            this.lblTraerPorGenero.Size = new System.Drawing.Size(112, 16);
            this.lblTraerPorGenero.TabIndex = 0;
            this.lblTraerPorGenero.Text = "Traer Por Genero";
            // 
            // txtTraerPorGenero
            // 
            this.txtTraerPorGenero.Location = new System.Drawing.Point(173, 313);
            this.txtTraerPorGenero.Name = "txtTraerPorGenero";
            this.txtTraerPorGenero.Size = new System.Drawing.Size(100, 22);
            this.txtTraerPorGenero.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(304, 39);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(304, 81);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(304, 313);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridPeliculas
            // 
            this.gridPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeliculas.Location = new System.Drawing.Point(438, 35);
            this.gridPeliculas.Name = "gridPeliculas";
            this.gridPeliculas.RowHeadersWidth = 51;
            this.gridPeliculas.RowTemplate.Height = 24;
            this.gridPeliculas.Size = new System.Drawing.Size(350, 386);
            this.gridPeliculas.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridPeliculas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtTraerPorGenero);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.txtFechaEstreno);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTraerPorGenero);
            this.Controls.Add(this.lblSinopsis);
            this.Controls.Add(this.lblFechaEstreno);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.txtClasificacion);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.TextBox txtFechaEstreno;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Label lblTraerPorGenero;
        private System.Windows.Forms.TextBox txtTraerPorGenero;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridPeliculas;
    }
}

