using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Odyssey
{
    public partial class vtnPrincipal : Form
    {
        public vtnPrincipal()
        {
            InitializeComponent();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            XmlDocument sesion = new XmlDocument();

            XmlElement raiz = sesion.CreateElement("Inicio");
            sesion.AppendChild(raiz);

            XmlElement id = sesion.CreateElement("id");
            id.AppendChild(sesion.CreateTextNode("01"));
            raiz.AppendChild(id);

            XmlElement usuario = sesion.CreateElement("Usuario");
            raiz.AppendChild(usuario);

            String username = txtUser.Text;
            String pass = txtPassword.Text;
            String ipAddress = txtIP.Text;
            XmlElement nombreUsuario = sesion.CreateElement("NombreUsuario");
            XmlElement ip = sesion.CreateElement("ip");
            XmlElement contrasena = sesion.CreateElement("Contrasena");
            if (username.Length != 0 && pass.Length >= 8)
            {
                nombreUsuario.AppendChild(sesion.CreateTextNode(username));
                usuario.AppendChild(nombreUsuario);
                contrasena.AppendChild(sesion.CreateTextNode(pass));
                usuario.AppendChild(contrasena);

                sesion.Save("C:\\Users\\diego\\Desktop\\Odyssey\\Odyssey\\Xml\\sesion.xml");
                Form aplicacion = new Aplicacion();
                this.Hide();
                aplicacion.Show();
            }
            else
            {
                MessageBox.Show("Ingrese Usuario y Contraseña","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form registrar = new RegistrarUsuario();
            this.Hide();
            registrar.Show();
        }
    }
}
