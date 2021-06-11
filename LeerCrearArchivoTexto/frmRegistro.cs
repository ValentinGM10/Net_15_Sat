using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LeerCrearArchivoTexto
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPassword01.Text) || string.IsNullOrEmpty(txtpassword02.Text))
            {
                MessageBox.Show("Datos incompletos... ");
                    return;
            }


                    if (txtPassword01.Text == txtpassword02.Text)
                    {
//                        string PasswordEnc = CodificarPassword(txtPassword01.Text);
                //          string PasswordEnc = Seguridad.Encriptar(txtPassword01.Text);
                            string PasswordEnc = Encrip.cifrar(txtPassword01.Text);

                if (UsuarioAC.CrearCuenta(txtUsuario.Text, txtNombre.Text, PasswordEnc) > 0)
                        {
                            MessageBox.Show(" Cuenta creado con Exito");
                        }
                        else
                        {
                            MessageBox.Show(" No se pudo Crear la cuenta");

                        }
                    }
                    else {
                MessageBox.Show("El password deben de ser iguales");
                txtPassword01.Text = "";
                txtpassword02.Text = "";
                txtPassword01.Focus();

                
                            }
               }
           

        public string CodificarPassword(string originalPassword)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            byte[] encodedBytes = md5.ComputeHash(originalBytes);
            return Convert.ToBase64String(encodedBytes);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPassword01_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtpassword02_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
