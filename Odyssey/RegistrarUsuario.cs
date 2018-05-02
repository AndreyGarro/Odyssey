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
                        XmlDocument usuario = new XmlDocument();
                        XmlElement raiz = usuario.CreateElement("Inicio");
                        usuario.AppendChild(raiz);

                        XmlElement id = usuario.CreateElement("id");
                        id.AppendChild(usuario.CreateTextNode("00"));
                        raiz.AppendChild(id);

                        XmlElement nuevoUsuario = usuario.CreateElement("Usuario");
                        raiz.AppendChild(nuevoUsuario);

                        XmlElement user = usuario.CreateElement("NombreUsuario");
                        user.AppendChild(usuario.CreateTextNode(username));
                        nuevoUsuario.AppendChild(user);

                        XmlElement nombreApellido = usuario.CreateElement("NombreApellidos");
                        nombreApellido.AppendChild(usuario.CreateTextNode(nombres));
                        nuevoUsuario.AppendChild(nombreApellido);

                        XmlElement edad1 = usuario.CreateElement("Edad");
                        edad1.AppendChild(usuario.CreateTextNode(edad));
                        nuevoUsuario.AppendChild(edad1);

                        XmlElement password = usuario.CreateElement("Contrasena");
                        password.AppendChild(usuario.CreateTextNode(pass1));
                        nuevoUsuario.AppendChild(password);

                        String generos = "";
                        if (clbGeneros.CheckedItems.Count != 0)
                        {
                            for(int x = 0; x <= clbGeneros.CheckedItems.Count - 1; x++)
                            {
                                generos += clbGeneros.CheckedItems[x].ToString() + " ";
                            }
                        }

                        XmlElement generos1 = usuario.CreateElement("Generos");
                        generos1.AppendChild(usuario.CreateTextNode(generos));
                        nuevoUsuario.AppendChild(generos1);

                        usuario.Save("C:\\Users\\diego\\Desktop\\Odyssey\\Odyssey\\Xml\\sesion.xml");
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
    }
}
