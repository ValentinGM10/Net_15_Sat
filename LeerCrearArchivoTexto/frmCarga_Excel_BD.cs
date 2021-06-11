using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace LeerCrearArchivoTexto
{
    public partial class frmCarga_Excel_BD : Form
    {
        string cn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DatosExcel.xls;Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'";

        public frmCarga_Excel_BD()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos();


        }


        public void CargarDatos()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Datos();
        }

        public DataTable Datos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Sueldo", typeof(int));
            using (OleDbConnection cnn = new OleDbConnection(cn))
            {
                string sql = "SELECT *FROM [Hoja1$]";

                OleDbCommand command = new OleDbCommand(sql, cnn);

                OleDbDataAdapter da = new OleDbDataAdapter(command);

                da.Fill(dt);
                return dt;
            }
        }

    }
}
