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
            String username = txtUser.Text;
            String pass = txtPassword.Text;
            String ipAddress = txtIP.Text;

            if (username.Length > 0 && pass.Length > 0)
            {
                XmlDocument sesion = DocumentoXML.ingresaUsuario(username, pass);
                SocketCliente.SendServidor(sesion);
                //Realiza la validacion si el usuario esta registrado
                Boolean registrado = false;
                if (registrado == true)
                {
                    Form registrar = new RegistrarUsuario();
                    this.Hide();
                    registrar.Show();
                }
                else
                {
                    MessageBox.Show("Usuario No Registrado", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else {       
                MessageBox.Show("Ingrese Usuario y Contraseña", "", MessageBoxButtons.OK, MessageBoxIcon.Information);            
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

        private void vtnPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
