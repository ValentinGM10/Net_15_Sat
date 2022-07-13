using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LeerCrearArchivoTexto
{
    public partial class frmPrueba : Form
    {
    //    public string idObligacionP;
        string _idObligacion;
        string _idUsuario;
        DataTable tabla;

        //public frmPrueba()
        //{
        //    InitializeComponent();
        //}



        public frmPrueba(string pObligacion, string pUsuario)
        {
            _idObligacion = pObligacion;
            _idUsuario = pUsuario;
            InitializeComponent();
        }

        private void btnLeerArchivoTxt_Click(object sender, EventArgs e)
        {
            bool ErrorArchivo = false;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            //  string fullimagepath = Path.Combine(Application.StartupPath, "imagenes\iamge1.jpg");
            //  string misDatos = Environment.GetFolderPath(Environment.SpecialFolders.ApplicationData) + "\\miCarpetaDeDatos";
            // string misDatos = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;

            string ruta = Directory.GetCurrentDirectory() + "\\Archivos";



            //   openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //  openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.InitialDirectory = ruta;


            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                string NomArchivos =  Path.GetFileName(FileName);

                string NoCarga = NomArchivos.Substring(0, 3);
                string Ejercc = NomArchivos.Substring(10, 4);

                int i = 0;
                bool result;
                 result = int.TryParse(NoCarga, out i); 

                if (NoCarga != null && NoCarga.Length > 0 && result == true)
                {
                    lblNoCarga.Text = NoCarga;
                }
                else
                {
                    btnExportar.Enabled = true;
                    MessageBox.Show("El nombre del Archivo  no cumple el formato requerido..");
                    ErrorArchivo = true;
                }

                 i = 0;
                 result = int.TryParse(Ejercc, out i);

                if (Ejercc != null && Ejercc.Length > 0)
                {
                    lblEjercicio.Text = Ejercc;
                }
                else
                {
                    btnExportar.Enabled = true;
                    MessageBox.Show("El nombre del Archivo  no cumple el formato requerido..");
                    ErrorArchivo = true;
                }

                if (ErrorArchivo == false)
                {
                    Int32 NoColumnas = funLongCampos(FileName);
                    try
                    {
                        if (NoColumnas == 47)
                        {
                           tabla = ucTextoTabla.TextoATabla(FileName, '|', lblNoCarga.Text, lblObligacion.Text);

                   //         CargarDatosTxt(FileName, '|', lblNoCarga.Text, lblObligacion.Text);
                            
                            //  tabla = ucTextoTabla.TextoATabla("VigilanciaPlus.txt", '|', lblNoCarga.Text, lblObligacion.Text);
                            dgvTexto.DataSource = tabla;
                            int Total = tabla.Rows.Count;
                            int  TotalColumna = tabla.Columns.Count;

                            txtContar.Text = Total.ToString();
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

                //String[] substrings = NomArchivos.Split('_');
                //foreach (var substring in substrings)
                //    Console.WriteLine(substring);

                // 204_23-08-2016_omisos_EF
               

                //funLongCampos(FileName);
            }
        }

        
        private void  FuNumeroCarga(int Ejercicio, int idObligacionParam)
        {
            Console.WriteLine(Ejercicio);
            Console.WriteLine(idObligacionParam);


            string strConexion = ConexionBD.CConexion;
            SqlConnection Conexion = new SqlConnection(strConexion);
            Conexion.Open();

            SqlCommand cmd = new SqlCommand("SELECT IsNull( Max(NoCarga),0 ) + 1 as MaximoCarga FROM RQp_Requerimientos_SAT where Ejercicio_Emision = @Ejercicio and  idObligacion = @idObligacion ", Conexion);
            cmd.Parameters.Add("@Ejercicio", SqlDbType.Int).Value = Ejercicio;
            cmd.Parameters.Add("@idObligacion", SqlDbType.Int).Value = idObligacionParam;

            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblNoCarga.Text = dr.GetValue(0).ToString();
            }

            Conexion.Close();

        }


        private Int32 funLongCampos(string Archivo)
        {
            Int32 NumeroCampos = 0;

            if (File.Exists(Archivo))
            {
                using (StreamReader sr = new StreamReader(Archivo))
                {
                    string[] cabeceras = sr.ReadLine().Split('|');
                    Console.WriteLine(cabeceras.Length);

                    NumeroCampos = cabeceras.Length;

                    lblColumnas.Text = NumeroCampos.ToString();
                    sr.Close();
                }
            }
           return (NumeroCampos);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string strConexion = ConexionBD.CConexion;
            SqlConnection Conexion = new SqlConnection(strConexion);
          
            bool exito = false;

            using (SqlConnection con = new SqlConnection(strConexion))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM RQp_Requerimientos_SAT_Aux", con))
                {
                    cmd.CommandType = CommandType.Text;
                    //   cmd.Parameters.AddWithValue("@Name", name);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            string NombreTabla = "RQp_Requerimientos_SAT_Aux";
            try
            {
                //  Insertar  datos a tabla temporar
                Conexion.Open();
                SqlBulkCopy exportar = default(SqlBulkCopy);
                exportar = new SqlBulkCopy(Conexion);
                exportar.DestinationTableName = NombreTabla;
                exportar.WriteToServer(tabla);

                exito = false;

                int idObligacion = Int32.Parse(_idObligacion);
                int Ejercicio = Int32.Parse(lblEjercicio.Text);
                int NumeroCarga = Int32.Parse(lblNoCarga.Text);
                string Usuario = lblUsuario.Text;


                // Insertar datos de la tabla temporar a la buena
                exito = false;
                SqlCommand cmd2 = new SqlCommand("RQ_spCargar_Req_SAT_Aux", Conexion);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@Tabla", NombreTabla);
                cmd2.Parameters.AddWithValue("@idObligacion", idObligacion);
                cmd2.Parameters.AddWithValue("@Ejercicio", Ejercicio);
                cmd2.Parameters.AddWithValue("@NumeroCarga", NumeroCarga);
                cmd2.Parameters.AddWithValue("@Usuario", Usuario);


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

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            // this.Dock = DockStyle.Fill;    lblNoCarga

            this.LayoutMdi(MdiLayout.TileHorizontal);

            lblObligacion.Text = _idObligacion;
            lblUsuario.Text = _idUsuario;

            int idObligacion = Int32.Parse(_idObligacion);

            btnExportar.Enabled = false;

            string Titulo;
            if (idObligacion == 97)
            {
                Titulo = "Cargar Archivo RIF";
            }else
            {
                Titulo = "Cargar Archivo VIGILANCIA PLUS";
            }

            lblVentana.Text = Titulo;



            //DateTime Fecha = DateTime.Today;
            //int year = Fecha.Year;

            //lblEjercicio.Text = year.ToString();
            //FuNumeroCarga(year, idObligacion);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEjercicio_Click(object sender, EventArgs e)
        {

        }

     //   tabla = ucTextoTabla.TextoATabla(FileName, '|', lblNoCarga.Text, lblObligacion.Text);


        void  CargarDatosTxt(string archivo, char separador, string Numerocarga, string Obligacion)
        {

            if (File.Exists(archivo))
            {
                using (StreamReader sr = new StreamReader(archivo))
                {

                    DateTime Fecha = DateTime.Now;
                    string datos = "";

                    //   DataRow fila = null;
                    string[] campos = null;
                    while (!sr.EndOfStream)
                    {
                   //     fila = tabla.NewRow();
                        campos = sr.ReadLine().Split('|');
                        int j = 0;
                        string s = campos[0];
                        bool result = int.TryParse(s, out j); //i now = 108  
                        if (result)
                        {
                            if (campos != null && campos.Length > 0)
                            {
                                //for (int i = 0; i < campos.Length - 1; i++)
                                //{
                                //    fila[i] = campos[i];

                                //}
                                datos = "INSERT INTO TABLA  VALUES  ( " + campos[0]   +  ")";
                               // datos = "INSERT INTO TABLA  VALUES  ( " + campos[0] + ",'" + campos[1] + "','" + campos[2] + "','" + campos[3] + "')";

                                Console.WriteLine(datos);
                            }
                          //  tabla.Rows.Add(fila);
                        }
                    }
                //    sr.Close();

                }
            }
           
        }

        private void btnSubirtxt_Click(object sender, EventArgs e)
        {
            
            DateTime Fecha = new DateTime();

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\Catastro\PruebaCCC.txt"))
            {
                foreach (DataRow row in tabla.Rows)
                {
                    List<string> items = new List<string>();
                    foreach (DataColumn col in tabla.Columns)
                    {
                        //                        columntypes[j] = dt.Columns[j].GetType().Name;//dt.Rows[0][j].GetType().Name;

                        //                        string TipoDatos = row[col.ColumnName].GetType().Name;
                        //                       Console.WriteLine(TipoDatos);
                        if (row[col.ColumnName].GetType().Name.Equals("String"))
                        {
                            if (row[col.ColumnName].ToString().Equals(""))
                                items.Add("Null");
                            else
                                items.Add("'" + row[col.ColumnName].ToString() + "'");
                        }
                        else if (row[col.ColumnName].GetType().Name.Equals("Int32"))
                        {
                            if (row[col.ColumnName].ToString().Equals(""))
                                items.Add("0");
                            else
                                items.Add(row[col.ColumnName].ToString());
                        }
                        // else if (row[col.ColumnName].ToString() == "FECHA")
                        else if (row[col.ColumnName].GetType().Name.Equals("DateTime"))
                        {
                            if (row[col.ColumnName].ToString().Equals(""))
                                items.Add("Null");
                            else
                            {
                                Fecha = (DateTime)row[col.ColumnName];
                                string fecha = String.Format("{0: yyyyMMdd}", Fecha);
                                items.Add("'" + fecha + "'");
                            }
                        }
                        else
                        {
                            if (row[col.ColumnName].ToString().Equals(""))
                                items.Add("Null");
                            else
                                items.Add("'" + row[col.ColumnName].ToString() + "'");
                        }

                        //                        FECHA   FechaCarga
                    //    string fec = DateTime.Now.ToString(@"yyyy-MM-dd");

                    }
                    //                    string linea = string.Join("|", items.ToArray());
                    string linea = string.Join(",", items.ToArray());
                    file.WriteLine("INSERT INTO RQp_Requerimientos_SAT_Aux  VALUES( " + linea + ")" );
                }
            }
            MessageBox.Show("Proceso Terminado....");



        }

    }
}
