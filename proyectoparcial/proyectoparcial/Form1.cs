
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proyectoparcial
{
    public partial class Form1 : Form

        
    {
        List<string>listaCanciones= new List<String>();

        LinkedList<string> queue = new LinkedList<string>();

        string[] ArchMP3;
        string[] rutasArchivoMP3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (txtnom.Text == "" || txtnom_cancion.Text == "" | txtgenero.Text== "" | txtaño.Text == "" /*| txtUbicacion.Text == ""*/)
            {
                MessageBox.Show("No hay cancion","Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nomCancion;

                nomCancion = txtnom.Text+" " +txtnom_cancion.Text+ " "+txtgenero.Text+ " "+txtaño.Text /*+ " " +txtUbicacion.Text*/;
                listaCanciones.Add(nomCancion);

                list_canciones.DataSource = null;

                list_canciones.DataSource= listaCanciones;
            }

            queue.AddLast("C:\\Users\\PC-ELHID\\Desktop\\canciones mp3.mp3");

            if (queue.Count > 0)
            {
                string nextSong = queue.First.Value;
                queue.RemoveFirst();
                Reproductor.currentPlaylist.appendItem(Reproductor.newMedia(nextSong));
                Reproductor.Ctlcontrols.play();
            }

        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            txtnom_cancion.Clear();
            txtnom.Clear();
            txtgenero.Clear();
            txtaño.Clear();
            //txtUbicacion.Clear();
        }

        private void btnadjunt_Click(object sender, EventArgs e)
        {
            OpenFileDialog BusquedaDeArchivos = new OpenFileDialog();
            BusquedaDeArchivos.Multiselect = true;

            if (BusquedaDeArchivos.ShowDialog() == DialogResult.OK)
            {
                ArchMP3 = BusquedaDeArchivos.SafeFileNames;
                rutasArchivoMP3 = BusquedaDeArchivos.FileNames;
                foreach (var ArchivoMP3 in ArchMP3)
                {
                    list_canciones.Items.Add(ArchivoMP3);

                }

                Reproductor.URL = rutasArchivoMP3[0];
                list_canciones.SelectedIndex = 0;
            }

            queue.AddLast("C:\\Users\\PC-ELHID\\Desktop\\canciones mp3.mp3");

            if (queue.Count > 0)
            {
                string nextSong = queue.First.Value;
                queue.RemoveFirst();
                Reproductor.currentPlaylist.appendItem(Reproductor.newMedia(nextSong));
                Reproductor.Ctlcontrols.play();
            }


        }

        private void list_canciones_SelectedIndexChanged(object sender, EventArgs e)
        {
           Reproductor.URL = rutasArchivoMP3[list_canciones.SelectedIndex];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
