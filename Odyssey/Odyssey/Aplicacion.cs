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
using System.Net.Sockets;

namespace Odyssey
{
    public partial class Aplicacion : Form
    {
        byte[] musicArray = null;


        public Aplicacion()
        {
            InitializeComponent();
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.InitialDirectory = "C:\\";
            txtDir.Text = abrirArchivo.FileName;
            abrirArchivo.Filter = "Music (.mp3)|*.mp3|ALL Files (*.*)|*.*";
            //abrirArchivo.FilterIndex = 2;
            abrirArchivo.RestoreDirectory = true;

            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                musicArray = File.ReadAllBytes(abrirArchivo.FileName);
                String stringSong;
                stringSong = Convert.ToBase64String(musicArray);

                XmlDocument song = new XmlDocument();

                XmlElement raiz = song.CreateElement("Cancion");
                song.AppendChild(raiz);

                XmlElement id = song.CreateElement("id");
                raiz.AppendChild(id);
                id.AppendChild(song.CreateTextNode("00"));

                XmlElement nombre = song.CreateElement("name");
                raiz.AppendChild(nombre);
                nombre.AppendChild(song.CreateTextNode("nombreCancion"));

                XmlElement cancion = song.CreateElement("song");
                raiz.AppendChild(cancion);
                cancion.AppendChild(song.CreateTextNode(stringSong));

                song.Save("C:\\Users\\diego\\Desktop\\Odyssey\\Odyssey\\Xml\\song.xml");

            }
        }

        private void txtDir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


