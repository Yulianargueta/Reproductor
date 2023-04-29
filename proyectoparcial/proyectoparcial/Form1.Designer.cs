namespace proyectoparcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.txtnom_cancion = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_canciones = new System.Windows.Forms.ListBox();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnadjunt = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadjunt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUbicacion);
            this.groupBox1.Controls.Add(this.lblUbicacion);
            this.groupBox1.Controls.Add(this.txtaño);
            this.groupBox1.Controls.Add(this.txtgenero);
            this.groupBox1.Controls.Add(this.txtnom_cancion);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(155, 163);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(100, 22);
            this.txtUbicacion.TabIndex = 9;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(22, 163);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(68, 16);
            this.lblUbicacion.TabIndex = 8;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(155, 122);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(100, 22);
            this.txtaño.TabIndex = 7;
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(155, 93);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(100, 22);
            this.txtgenero.TabIndex = 6;
            // 
            // txtnom_cancion
            // 
            this.txtnom_cancion.Location = new System.Drawing.Point(155, 64);
            this.txtnom_cancion.Name = "txtnom_cancion";
            this.txtnom_cancion.Size = new System.Drawing.Size(100, 22);
            this.txtnom_cancion.TabIndex = 5;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(155, 30);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 22);
            this.txtnom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año Lanzamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre cancion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artista";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_canciones);
            this.groupBox2.Location = new System.Drawing.Point(24, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 194);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de canciones";
            // 
            // list_canciones
            // 
            this.list_canciones.FormattingEnabled = true;
            this.list_canciones.ItemHeight = 16;
            this.list_canciones.Location = new System.Drawing.Point(25, 31);
            this.list_canciones.Name = "list_canciones";
            this.list_canciones.Size = new System.Drawing.Size(342, 148);
            this.list_canciones.TabIndex = 0;
            this.list_canciones.SelectedIndexChanged += new System.EventHandler(this.list_canciones_SelectedIndexChanged);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(68, 462);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 23);
            this.btninsertar.TabIndex = 6;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Location = new System.Drawing.Point(179, 462);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnrefrescar.TabIndex = 7;
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(431, 206);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(220, 107);
            this.Reproductor.TabIndex = 8;
            // 
            // btnadjunt
            // 
            this.btnadjunt.Image = global::proyectoparcial.Properties.Resources.the_guy_listens_to_music_with_headphones_music_sounds_the_man_is_a_music_lover_vector1;
            this.btnadjunt.Location = new System.Drawing.Point(496, 446);
            this.btnadjunt.Name = "btnadjunt";
            this.btnadjunt.Size = new System.Drawing.Size(100, 50);
            this.btnadjunt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnadjunt.TabIndex = 9;
            this.btnadjunt.TabStop = false;
            this.btnadjunt.Click += new System.EventHandler(this.btnadjunt_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(316, 462);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 544);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnadjunt);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadjunt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.TextBox txtnom_cancion;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox list_canciones;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btnrefrescar;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.PictureBox btnadjunt;
        private System.Windows.Forms.Button btnEliminar;
    }
}

