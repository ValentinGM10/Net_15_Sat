using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LeerCrearArchivoTexto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Datos incompletos... ");
            
                return;
            }

            
              DateTime FechaP = new DateTime(2018, 11, 7);


            //    bool bandera = true;

           // string PasswordEnc = CodificarPassword(txtPassword.Text);
           // string PasswordEnc = Seguridad.Encriptar(txtPassword.Text);
            string PasswordEnc = Encrip.cifrar(txtPassword.Text);

            string Msg = "OK";
            if (UsuarioAC.Autentificar(txtUsuario.Text, PasswordEnc, ref Msg) > 0 )
       //     if (FechaP >  DateTime.Now)
            {
                this.Hide();
                frmMDIParent form = new frmMDIParent( txtUsuario.Text);
                form.ShowDialog();
            }
            else
            {
            //    MessageBox.Show("Password Incorecto");
                MessageBox.Show(Msg);
                txtPassword.SelectionStart = 0;
                txtPassword.SelectionLength = txtPassword.Text.Length;
                txtPassword.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cifrar
            string nuestra_cadena = "123456";
            txtPrueba.Text = Encrip.cifrar(nuestra_cadena);

            //    MessageBox.Show(resultado);

            //            string cadenaSifrada = txtPrueba.Text;
            string cadenaSifrada = "1xds5t9IOUQ=";

            

            //   string resultado2 = Encrip.descifrar(resultado);
            string resultado2 = Encrip.descifrar(cadenaSifrada);

            MessageBox.Show(resultado2);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nuestra_cadena = "MellamoValentin";
            string resultado = Seguridad.Encriptar(nuestra_cadena);

            MessageBox.Show(resultado);

            string resultado2 = Seguridad.DesEncriptar(resultado);

            MessageBox.Show(resultado2);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //string Cadena = "MellamoValentin";
            //string re;

            //foreach (string letter in Cadena.Select(c => Convert.ToString(c, 2)))
            //{
            //   Console.Write (letter);
            //}

            //string val = "hola";
            //string[] numerote = new string[val.Length];
            //int contador = 0;
            //foreach (char c in val)
            //{
            //    numerote[contador] = Convert.ToString(Convert.ToInt32(((int)c).ToString("X"), 16), 2);
            //    contador++;
            //}
            //string binarios = string.Join(" ", numerote);

            //MessageBox.Show(binarios);

         //    txtPassword.Text = encodePassword("12345");
            // MessageBox.Show(encodePassword("MellamoValentin"));

            this.Close();

        }


        public string CodificarPassword(string originalPassword)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            byte[] encodedBytes = md5.ComputeHash(originalBytes);
            return Convert.ToBase64String(encodedBytes);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Maquina = Environment.MachineName;
            if (Maquina == "SH-ET-28")
            {
                txtUsuario.Text = "ADMIN";
                txtPassword.Text = "dellT3500";
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }



        // https://basicsinsql.wordpress.com/2012/10/18/how-to-encrypt-and-decrypt-the-password-using-c-in-asp-net/

        const string passphrase = "Password@123";  //consant string Pass key

        private void button3_Click(object sender, EventArgs e)
        {
            string Nombre = "Valentin";
            string NombreEncritado = encrypt(Nombre);
            MessageBox.Show(NombreEncritado);

            string NombreDesCriptado = decrypt(NombreEncritado);

            MessageBox.Show(NombreDesCriptado);
        }


        public string encrypt(string message)
        {
            byte[] results;
            UTF8Encoding utf8 = new UTF8Encoding();
            //to create the object for UTF8Encoding  class
            //TO create the object for MD5CryptoServiceProvider 
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] deskey = md5.ComputeHash(utf8.GetBytes(passphrase));
            //to convert to binary passkey
            //TO create the object for  TripleDESCryptoServiceProvider 
            TripleDESCryptoServiceProvider desalg = new TripleDESCryptoServiceProvider();
            desalg.Key = deskey;//to  pass encode key
            desalg.Mode = CipherMode.ECB;
            desalg.Padding = PaddingMode.PKCS7;
            byte[] encrypt_data = utf8.GetBytes(message);
            //to convert the string to utf encoding binary 
            try
            {
                //To transform the utf binary code to md5 encrypt    
                ICryptoTransform encryptor = desalg.CreateEncryptor();
                results = encryptor.TransformFinalBlock(encrypt_data, 0, encrypt_data.Length);
            }
            finally
            {
                //to clear the allocated memory
                desalg.Clear();
                md5.Clear();
            }
            //to convert to 64 bit string from converted md5 algorithm binary code
            return Convert.ToBase64String(results);
        }


        public string decrypt(string message)
        {
            byte[] results;
            UTF8Encoding utf8 = new UTF8Encoding();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] deskey = md5.ComputeHash(utf8.GetBytes(passphrase));
            TripleDESCryptoServiceProvider desalg = new TripleDESCryptoServiceProvider();
            desalg.Key = deskey;
            desalg.Mode = CipherMode.ECB;
            desalg.Padding = PaddingMode.PKCS7;
            byte[] decrypt_data = Convert.FromBase64String(message);
            try
            {
                //To transform the utf binary code to md5 decrypt
                ICryptoTransform decryptor = desalg.CreateDecryptor();
                results = decryptor.TransformFinalBlock(decrypt_data, 0, decrypt_data.Length);
            }
            finally
            {
                desalg.Clear();
                md5.Clear();

            }
            //TO convert decrypted binery code to string
            return utf8.GetString(results);
        }


    }
}
