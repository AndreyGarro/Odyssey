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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String edad = txtAge.Text;
            String nombres = txtNames.Text;
            String pass1 = txtPassword.Text;
            String pass2 = txtPassword2.Text;
 
            if(pass1 == pass2)
            {
                if (pass1.Length >= 8)
                {
                    if (username.Length > 0 && edad.Length > 0 && nombres.Length > 0)
                    {
                        String generos = "";
                        if (clbGeneros.CheckedItems.Count != 0)
                        {
                            for(int x = 0; x <= clbGeneros.CheckedItems.Count - 1; x++)
                            {
                                generos += clbGeneros.CheckedItems[x].ToString() + " ";
                            }
                        }
                        XmlDocument nuevoUsuario = DocumentoXML.registraUsuario(username, nombres, edad, pass1, generos);
                        XmlDocument respuestaXml = SocketCliente.SendServidor(nuevoUsuario);
                        XmlNodeList respuesta1 = respuestaXml.GetElementsByTagName("Respuesta");
                        String res = respuesta1[0].InnerText;

                        if (res.Equals("true"))
                        {
                            MessageBox.Show("Usuario Registrado Exitosamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form principal = new vtnPrincipal();
                            this.Hide();
                            principal.Show();

                        }
                        else
                        {
                            MessageBox.Show("Usuario Ya Registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son Requeridos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña debe ser mayor o igual a 8 dígitos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form principal = new vtnPrincipal();
            this.Hide();
            principal.Show();
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
