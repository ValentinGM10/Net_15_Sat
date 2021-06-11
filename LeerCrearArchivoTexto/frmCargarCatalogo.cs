using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LeerCrearArchivoTexto
{

    public partial class frmCargarCatalogo : Form
    {
        DataTable tabla;
        string _idObligacion;
        string _idUsuario;


        public frmCargarCatalogo()
        {
            InitializeComponent();
        }


        public frmCargarCatalogo(string pObligacion, string pUsuario)
        {
            _idObligacion = pObligacion;
            _idUsuario = pUsuario;
            InitializeComponent();
        }


        private void btnLeerArchivoTxt_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            // openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            string ruta = Directory.GetCurrentDirectory() + "\\Archivos";
            openFileDialog.InitialDirectory = ruta;

            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;


                Int32 NoColumnas = funLongCampos(FileName);

                //                MessageBox.Show(FileName);

                try
                {
                    if (NoColumnas == 8)
                    {
                        tabla = uc_CargarTexto.TextoATabla(FileName, '|');
                        //       tabla = uc_CargarTexto.TextoATabla("199_03-08-2016_FundamentosLegales_EF.txt", '|');
                        dgvTexto.DataSource = tabla;
                        int Total = tabla.Rows.Count;
                        txtContar.Text =  Total.ToString();
                        if (Total > 0)
                        {
                            btnExportar.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo no Corresponde con las columnas Especificadas");
                    }
                   
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message);
                }
               
            }

        }


        private Int32 funLongCampos(string Archivo)
        {
            Int32 NumeroCampos = 0;

            if (File.Exists(Archivo))
            {
                using (StreamReader sr = new StreamReader(Archivo))
                {
                    string[] cabeceras = sr.ReadLine().Split('|');
                    NumeroCampos = cabeceras.Length;

                    lblColumnas.Text = NumeroCampos.ToString();
                    sr.Close();
                }
            }
            return (NumeroCampos);
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            //string conexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            //MessageBox.Show(conexion);
            // ------------------------------------------------------
            // ELIMINAR  RQc_Fundamentos_RIF_Aux

            string strConexion = ConexionBD.CConexion;

            using (SqlConnection con = new SqlConnection(strConexion))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM RQc_Fundamentos_RIF_Aux", con))
                {
                    cmd.CommandType = CommandType.Text;
                 //   cmd.Parameters.AddWithValue("@Name", name);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            SqlConnection Conexion = new SqlConnection(strConexion);

            try
            {
                // INSERTAR  Datos
              
                Conexion.Open();
                string NombreTabla = "RQc_Fundamentos_RIF_Aux";
                // caraga de datos
                SqlBulkCopy exportar = default(SqlBulkCopy);
                exportar = new SqlBulkCopy(Conexion);
                exportar.DestinationTableName = NombreTabla;
                exportar.WriteToServer(tabla);


                //  Actalizar  datos
                int idObligacion = Int32.Parse(_idObligacion);
                bool exito;
                exito = false;
                SqlCommand cmd2 = new SqlCommand("RQ_spCargar_Req_SAT_Aux", Conexion);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@Tabla", NombreTabla);
                cmd2.Parameters.AddWithValue("@idObligacion", idObligacion);
                cmd2.Parameters.AddWithValue("@Ejercicio", 2000);
                cmd2.Parameters.AddWithValue("@NumeroCarga", 0);
                cmd2.Parameters.AddWithValue("@Usuario", lblUsuario.Text);

                int m = cmd2.ExecuteNonQuery();
                exito = (m > 0);


                Conexion.Close();

                MessageBox.Show("Proceso de carga terminado...", "Aviso", MessageBoxButtons.OK);

            }
            catch (Exception Error)
            {
                Conexion.Close();
                MessageBox.Show(Error.Message);
            }




        }

        private void frmCargarCatalogo_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            lblObligacion.Text = _idObligacion;
            lblUsuario.Text = _idUsuario;


            //  int idObligacion = Int32.Parse(_idObligacion);  lblColumnas
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
