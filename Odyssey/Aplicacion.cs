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
            abrirArchivo.InitialDirectory = "C:\\";
            abrirArchivo.Filter = "Music (.mp3)|*.mp3|ALL Files (*.*)|*.*";
            //abrirArchivo.FilterIndex = 2;
            abrirArchivo.RestoreDirectory = true;

            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                // Lee los datos de la cancion seleccionada y los convierte en bytes y String
                musicArray = File.ReadAllBytes(abrirArchivo.FileName);
                String stringSong;
                stringSong = Convert.ToBase64String(musicArray);

                XmlDocument song = DocumentoXML.agregaCancion(stringSong);                  
                SocketCliente.SendServidor(song);

            }
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {

        }
    }
}
