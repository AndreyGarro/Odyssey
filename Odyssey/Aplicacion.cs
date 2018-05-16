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
 
    public partial class lblCalificacion : Form
    {
        private byte[] musicArray = null;
        private String stdDetails = "{0, -20}{1, -15}{2, -15}{3, -15}{4, -15}";

        public lblCalificacion()
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
            lstCanciones.Hide();
            lblNombre.Hide();
            lblArtista.Hide();
            lblCalif.Hide();
            lblAlbum.Hide();
            lblGenero.Hide();

        }

        private void txtCanciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            lstCanciones.Items.Clear();
            lstCanciones.Show();

            XmlDocument cargar = DocumentoXML.ordenamiento("02");
            XmlDocument lista = SocketCliente.SendServidor(cargar);

            XmlNodeList nombre = lista.GetElementsByTagName("nombre");
            XmlNodeList artista = lista.GetElementsByTagName("artista");
            XmlNodeList album = lista.GetElementsByTagName("album");
            XmlNodeList genero = lista.GetElementsByTagName("genero");
            XmlNodeList calificacion = lista.GetElementsByTagName("calificacion");

            int cont = 0;
            foreach (XmlElement i in nombre)
            {
                String nombre1 = nombre.Item(cont).InnerText;
                String artista1 = artista.Item(cont).InnerText;
                String album1 = album.Item(cont).InnerText;
                String genero1 = genero.Item(cont).InnerText;
                String calificacion1 = calificacion.Item(cont).InnerText;
                lstCanciones.Items.Add(String.Format(stdDetails, nombre1, artista1, album1, genero1, calificacion1));

                cont++;
            }
            lblNombre.Show();
            lblArtista.Show();
            lblCalif.Show();
            lblAlbum.Show();
            lblGenero.Show();
            
        }

        private void toolTipAgrega_Popup(object sender, PopupEventArgs e)
        {
            toolTipAgrega.UseFading = true;
            toolTipAgrega.UseAnimation = true;
            toolTipAgrega.ShowAlways = true;
            toolTipAgrega.AutoPopDelay = 6000;
            toolTipAgrega.InitialDelay = 500;
            toolTipAgrega.ReshowDelay = 500;
            
        }

        private void toolTip1Biblioteca_Popup(object sender, PopupEventArgs e)
        {
            toolTip1Biblioteca.UseFading = true;
            toolTip1Biblioteca.UseAnimation = true;
            toolTip1Biblioteca.ShowAlways = true;
            toolTip1Biblioteca.AutoPopDelay = 6000;
            toolTip1Biblioteca.InitialDelay = 500;
            toolTip1Biblioteca.ReshowDelay = 500;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            String opcion = (String)cmbBoxOrdena.SelectedItem;
            if (opcion.Equals("Álbum"))
            {
                MessageBox.Show("ordenado por album");
            }
        }

        private void listGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxOrdena_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lstCanciones.Items.Clear();
            XmlDocument ordenado = SocketCliente.SendServidor(DocumentoXML.ordenamiento("00"));

            XmlNodeList nombre = ordenado.GetElementsByTagName("nombre");
            XmlNodeList artista = ordenado.GetElementsByTagName("artista");
            XmlNodeList album = ordenado.GetElementsByTagName("album");
            XmlNodeList genero = ordenado.GetElementsByTagName("genero");
            XmlNodeList calificacion = ordenado.GetElementsByTagName("calificacion");

            int cont = 0;
            foreach (XmlElement i in nombre)
            {
                String nombre1 = nombre.Item(cont).InnerText;
                String artista1 = artista.Item(cont).InnerText;
                String album1 = album.Item(cont).InnerText;
                String genero1 = genero.Item(cont).InnerText;
                String calificacion1 = calificacion.Item(cont).InnerText;
                lstCanciones.Items.Add(String.Format(stdDetails, nombre1, artista1, album1, genero1, calificacion1));

                cont++;
            }
        }

        private void lblAlbum_Click(object sender, EventArgs e)
        {
            lstCanciones.Items.Clear();
            XmlDocument ordenado = SocketCliente.SendServidor(DocumentoXML.ordenamiento("02"));

            XmlNodeList nombre = ordenado.GetElementsByTagName("nombre");
            XmlNodeList artista = ordenado.GetElementsByTagName("artista");
            XmlNodeList album = ordenado.GetElementsByTagName("album");
            XmlNodeList genero = ordenado.GetElementsByTagName("genero");
            XmlNodeList calificacion = ordenado.GetElementsByTagName("calificacion");

            int cont = 0;
            foreach (XmlElement i in nombre)
            {
                String nombre1 = nombre.Item(cont).InnerText;
                String artista1 = artista.Item(cont).InnerText;
                String album1 = album.Item(cont).InnerText;
                String genero1 = genero.Item(cont).InnerText;
                String calificacion1 = calificacion.Item(cont).InnerText;
                lstCanciones.Items.Add(String.Format(stdDetails, nombre1, artista1, album1, genero1, calificacion1));

                cont++;
            }
        }

        private void reproductor_Enter(object sender, EventArgs e)
        {
            reproductor.URL = "";
        }

        private void lblArtista_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
