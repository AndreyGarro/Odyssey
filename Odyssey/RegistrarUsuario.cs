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

                        byte[] encripted = Encoding.Unicode.GetBytes(pass1);
                        String passEncripted = Convert.ToBase64String(encripted);
  
                        XmlDocument nuevoUsuario = DocumentoXML.registraUsuario(username, nombres, edad, passEncripted, generos);
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

        private void txtNames_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Contraseña"))
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void label9_Leave(object sender, EventArgs e)
        {

        }

        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            if (txtPassword2.Text.Equals("Confirmar Contraseña"))
            {
                txtPassword2.Text = "";
                txtPassword2.ForeColor = Color.LightGray;
                txtPassword2.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            if (txtPassword2.Text.Equals(""))
            {
                txtPassword2.Text = "Confirmar Contraseña";
                txtPassword2.ForeColor = Color.DimGray;
                txtPassword2.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Nombre de Usuario"))
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = "Nombre de Usuario";
                txtUsername.ForeColor = Color.DimGray;
            }
        }

        private void txtNames_Enter(object sender, EventArgs e)
        {
            if (txtNames.Text.Equals("Nombre y Apellidos"))
            {
                txtNames.Text = "";
                txtNames.ForeColor = Color.LightGray;
            }
        }

        private void txtNames_Leave(object sender, EventArgs e)
        {
            if (txtNames.Text.Equals(""))
            {
                txtNames.Text = "Nombre y Apellidos";
                txtNames.ForeColor = Color.DimGray;
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_Enter(object sender, EventArgs e)
        {
            if (txtAge.Text.Equals("Edad"))
            {
                txtAge.Text = "";
                txtAge.ForeColor = Color.LightGray;
            }
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (txtAge.Text.Equals(""))
            {
                txtAge.Text = "Edad";
                txtAge.ForeColor = Color.DimGray;
            }
        }

        private void clbGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
