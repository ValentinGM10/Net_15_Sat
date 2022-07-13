using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LeerCrearArchivoTexto
{
   

    public partial class frnExcel : Form
    {
        string _idUsuario;
        DataSet dataSet = null;

        //public frnExcel()
        //{
        //    InitializeComponent();
        //}

        public frnExcel(string pUsuario)
        {
            _idUsuario = pUsuario;
            InitializeComponent();
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string hoja = "Hoja1";
            OpenFileDialog dialog = new OpenFileDialog();

            // dialog.InitialDirectory = "c:\\";
            string directorio = Directory.GetCurrentDirectory();
             dialog.InitialDirectory = directorio;

            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; 
            dialog.Title = "Seleccione el archivo de Excel"; 
            dialog.FileName = string.Empty; 
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtArchivo.Text = dialog.FileName;
                hoja = txtHoja.Text; 
                LLenarGrid(txtArchivo.Text, hoja); 
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                                                                                        //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
            }
        }


        private void LLenarGrid(string archivo, string hoja)
        {

            //DataTable dt = new DataTable();
            //dt.Columns.Add("No_Control");
            //dt.Columns.Add("Ejercicio", typeof(int));
            //dt.Columns.Add("Periodo", typeof(int));
            //dt.Columns.Add("idObligacion", typeof(int));
            //dt.Columns.Add("Regimen");
            //dt.Columns.Add("FechaVencimiento");
            //dt.Columns.Add("FolioPago");
            //dt.Columns.Add("FechaPago");
            //dt.Columns.Add("Importe", typeof(int));


            OleDbConnection conexion = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";
            OleDbDataAdapter da = null;
            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);
                    conexion.Open();
                    da = new OleDbDataAdapter(consultaHojaExcel, conexion); 
                    dataSet = new DataSet();
                    da.Fill(dataSet, hoja);
                    dataGridView1.DataSource = dataSet.Tables[0]; 
                    conexion.Close();
                    dataGridView1.AllowUserToAddRows = false;     
                    lblEjercicio.Text = dataGridView1.Rows[2].Cells[2].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }


        public void CambiarOpcionesMenu(ToolStripItemCollection colOpcionesMenu)
        {
            // recorrer el submenú
            foreach (ToolStripItem itmOpcion in colOpcionesMenu)
            {
                // restaurar el tipo de letra original


                // si es una opción de menú normal...
                if (itmOpcion.GetType() == typeof(ToolStripMenuItem))
                {


                    // OJO que hay que colocar el texto que contiene el elemento ej. Imprimir
                    if (itmOpcion.Text == "Imprimir")
                    {
                        //Aqui lo deshabilitamos
                        ((ToolStripMenuItem)itmOpcion).Enabled = false;
                    }

                    // si esta opción a su vez despliega un nuevo submenú
                    // llamar recursivamente a este método para cambiar sus opciones
                    if (((ToolStripMenuItem)itmOpcion).DropDownItems.Count > 0)
                    {
                        this.CambiarOpcionesMenu(((ToolStripMenuItem)itmOpcion).DropDownItems);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel.Worksheet hojas = (Microsoft.Office.Interop.Excel.Worksheet)Globals.ThisAddIn.Application.Workbooks[1].Worksheets[1];
            //for (int i = 0; i < 101; i++)//hojas.UsedRange.Rows.Count; i++)
            //{
            //    hojas.Cells[i + 1, 1] = i;
            //}
            string Cadena = "";
            string concatenar = "";

            string NombreArchivo = "prueba";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Temporal\ArchivoTexto\" + NombreArchivo + ".txt", true))
            {
                for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
                {
                    for (int col = 0; col < dataGridView1.Rows[fila].Cells.Count; col++)
                    {
                     //   string valor = dataGridView1.Rows[fila].Cells[col].Value.ToString();
                            Cadena =  dataGridView1.Rows[fila].Cells[col].Value.ToString().Trim();
                        concatenar += Cadena;
                    }
                }

            }

        }

        private void frnExcel_Load(object sender, EventArgs e)
        {
         //   txtEjercicio.Text = _idObligacion;
            lblUsuario.Text = _idUsuario;
        }



        private void btnExportarBD_Click(object sender, EventArgs e)
        {
            string strConexion = ConexionBD.CConexion;

            using (SqlConnection con = new SqlConnection(strConexion))
            {
                

//                using (SqlCommand cmd = new SqlCommand("DELETE FROM RQp_PagosSat_Auxiliar", con))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM RQd_PagosSat_Auxiliar", con))
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
                string NombreTabla = "RQd_PagosSat_Auxiliar";
                // caraga de datos
                SqlBulkCopy exportar = default(SqlBulkCopy);
                exportar = new SqlBulkCopy(Conexion);
                exportar.DestinationTableName = NombreTabla;
                exportar.WriteToServer(dataSet.Tables[0]);


                // Actalizar datos
                // int idObligacion = Int32.Parse(_idObligacion);
                bool exito;
                exito = false;
                SqlCommand cmd2 = new SqlCommand("RQ_spCarga_Pagos_Sat", Conexion);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@vEjercicio", 2019);
                cmd2.Parameters.AddWithValue("@vUsuario", lblUsuario.Text);
                int m = cmd2.ExecuteNonQuery();
                exito = (m > 0);



                //   //  Actalizar  datos ---------------------------------------------------------------------------------------




                Conexion.Close();

                MessageBox.Show("Proceso de carga terminado...", "Aviso", MessageBoxButtons.OK);

            }
            catch (Exception Error)
            {
                Conexion.Close();
                MessageBox.Show(Error.Message);
            }
        }

        private void txtEjercicio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
