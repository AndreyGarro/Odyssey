using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;
using InputKey;

namespace Odyssey
{
    public partial class Aplicacion : Form
    {
        byte[] musicArray = null;


        public Aplicacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abre la ventana de Windows para seleccionar la cancion
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Multiselect = true;
            abrirArchivo.InitialDirectory = "C:\\";
            abrirArchivo.Filter = "Music (.mp3)|*.mp3|ALL Files (*.*)|*.*";
            abrirArchivo.RestoreDirectory = true;

            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                // Lee los datos de la cancion seleccionada y los convierte en bytes y String
                musicArray = File.ReadAllBytes(abrirArchivo.FileName);
                String stringSong = Convert.ToBase64String(musicArray);

                //Solicita el nombre y artista de la cancion y lo guarda en variables
                String nombre = InputDialog.mostrar("Introduzca el nombre de la canción:");
                String artista = InputDialog.mostrar("Introduzca el artista de la canción:");

                XmlDocument song = DocumentoXML.agregaCancion(stringSong, nombre, artista);
                SocketCliente.SendServidor(song);
               /* String[] archivosMp3 = abrirArchivo.SafeFileNames;
                String[] rutaMp3 = abrirArchivo.FileNames;
                foreach (var archivoMp3 in archivosMp3)
                {
                    lstCanciones.Items.Add(archivoMp3);
                }

                reproductor.URL = rutaMp3[0];
                lstCanciones.SelectedIndex = 0;*/
            }
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
          
        }

        private void txtCanciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
