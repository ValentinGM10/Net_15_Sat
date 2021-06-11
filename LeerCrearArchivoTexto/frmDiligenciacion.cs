using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LeerCrearArchivoTexto
{
    public partial class frmDiligenciacion : Form
    {

     //   DataTable tabla;
        string _idObligacion;
        string _idUsuario;


        public frmDiligenciacion()
        {
            InitializeComponent();
        }


        public frmDiligenciacion(string pObligacion, string pUsuario)
        {
            _idObligacion = pObligacion;
            _idUsuario = pUsuario;
            InitializeComponent();
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string strConexion = ConexionBD.CConexion;
            SqlConnection Conexion = new SqlConnection(strConexion);


            try
            {

                DateTime Fecha = DateTime.Now;

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("RQ_spSatResultadoDiligenciacion", Conexion );
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@idObligacion", SqlDbType.TinyInt);
                da.SelectCommand.Parameters["@idObligacion"].Value = _idObligacion;

                da.SelectCommand.Parameters.Add("@NoCarga", SqlDbType.Int);
                da.SelectCommand.Parameters["@NoCarga"].Value = comboBox1.SelectedValue;

                // string sql = "Exec RQ_spSatResultadoDiligenciacion " + _idObligacion + ", " + comboBox1.SelectedValue;
                //   Console.Write(sql);


                da.Fill(dt);

                this.dgvConsulta.DataSource = dt;

                LabelStatus.Text = "No. de Registros: " + dt.Rows.Count;

             
             //   LabelStatus.Text = Fecha.ToString("yy/MM/dd");
//                string CadenaFecha = "\\Archivos\\Envios\\ResultadoDiligenciacionEF" + Fecha.ToString("yyMMdd") + ".txt";
                string CadenaFecha = "\\Archivos\\Envios\\ResultadoDiligenciacionEF" + Fecha.ToString("ddMMyy") + ".txt";
                string rutaArchivo = Directory.GetCurrentDirectory() + CadenaFecha;

//                ucTextoTabla.TablaATexto(dt, "ResultadoDiligenciacionEF070416.txt", '|');
                ucTextoTabla.TablaATexto(dt, rutaArchivo, '|');


          //      MessageBox.Show(rutaArchivo);


                //            'D:\NET\VS_2015\Escritorio\CargaArchivoPlano\LeerCrearArchivoTexto\bin\DebugEnvios\ResultadoDiligenciacionEF24\04\17'.

                 MessageBox.Show("Archivo de Texto creado");

            }
            catch (Exception ex)
            {
                this.LabelNonQuery.Text = "Error: " + ex.Message;
                LabelStatus.Text = "ERROR";
            }



            //SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["BarManConnectionString"].ConnectionString);
            //conn.Open();
            //string query = "SELECT * FROM [EventOne]";

            //SqlCommand cmd = new SqlCommand(query, conn);

            //DataTable t1 = new DataTable();
            //using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            //{
            //    a.Fill(t1);
            //}

        }


        private DataTable CargarProductosDT()
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks2012;Integrated Security=True"))
            {
                string ConsultaProductos = "SELECT Name,ProductNumber,Color,Class FROM Production.Product";
                SqlCommand cmd = new SqlCommand(ConsultaProductos, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        private void frmDiligenciacion_Load(object sender, EventArgs e)
        {
            lblObligacion.Text = _idObligacion;

            if (_idObligacion == "97")
            {
                lblObligacion.Text = "RIF";
            }
            else
            {
                lblObligacion.Text = "V. PLUS";
            }

            string strConexion = ConexionBD.CConexion;
            SqlConnection Conexion = new SqlConnection(strConexion);


            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(strConexion))
            {
             //   string query = "select  NoCarga from dbo.RQp_Requerimientos_SAT where idObligacion = 96 group by  NoCarga";

                // SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand cmd = new SqlCommand("SELECT  NoCarga FROM dbo.RQp_Requerimientos_SAT WHERE idObligacion = @idObligacion group by  NoCarga", conn);
                           cmd.Parameters.Add("@idObligacion", SqlDbType.Int).Value = _idObligacion;
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            comboBox1.DisplayMember = "NoCarga";
            comboBox1.ValueMember = "NoCarga";
            comboBox1.DataSource = dt;

        }




        private void btnExportar_Click(object sender, EventArgs e)
        {
            DateTime Fecha = DateTime.Now;
            LabelStatus.Text = Fecha.ToString("yy/MM/dd");

            //            string CadenaFecha = "\\Envios\\ResultadoDiligenciacionEF" + Fecha.ToString("dd/MM/yy");
            string CadenaFecha = "\\Envios\\ResultadoDiligenciacionEF.txt";


//            'D:\NET\VS_2015\Escritorio\CargaArchivoPlano\LeerCrearArchivoTexto\bin\DebugEnvios\ResultadoDiligenciacionEF24\04\17'.


            string rutaArchivo = Directory.GetCurrentDirectory() + CadenaFecha;

 //           MessageBox.Show(rutaArchivo);

 //           ucTextoTabla.TablaATexto(tabla, "Producto.txt", '|');

            MessageBox.Show("Archivo de Texto creado");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelNonQuery_Click(object sender, EventArgs e)
        {

        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {

            string CadenaFecha = "\\Archivos\\Envios";
            string rutaArchivo = Directory.GetCurrentDirectory() + CadenaFecha;


         //   string rutaArchivo = Directory.GetCurrentDirectory();
         //   MessageBox.Show(rutaArchivo);
                
            // System.Diagnostics.Process.Start(@"C:\");
            System.Diagnostics.Process.Start(rutaArchivo);


        }




        //   using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ATCNTV1ConnectionString"].ConnectionString))
        //{
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand();
        //cmd.Connection = con;
        //        cmd.CommandText = "SELECT ProgramID, ProgramName FROM tblPrograms WHERE ProgramCatID > 0 AND ProgramStatusID = (CASE WHEN @StudyYearID = 'VPR' THEN 10 ELSE 7 END) AND ProgramID NOT IN (23,112,113) ORDER BY ProgramName";
        //        cmd.Parameters.Add("@StudyYearID", SqlDbType.Char).Value = "11";
        //        DataTable wsPrograms = new DataTable();
        //wsPrograms.Load(cmd.ExecuteReader());

        //        //populate the Programs ddl list
        //        ddlPrograms.DataSource = wsPrograms;
        //        ddlPrograms.DataTextField = "ProgramName";
        //        ddlPrograms.DataValueField = "ProgramID";
        //        ddlPrograms.DataBind();
        //        ddlPrograms.Items.Insert(0, new ListItem("<Select Program>", "0"));
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle the error
        //    }
        //} 





    }
}
