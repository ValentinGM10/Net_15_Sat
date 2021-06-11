using System;
using System.Windows.Forms;

namespace LeerCrearArchivoTexto
{
    public partial class frmMDIParent : Form
    {
        string _idUsuario;
        // menu_01_Excel
        frmCargarCatalogo frmCatalogoRIF;
        frmCargarCatalogo frmCatalogoVPlus;

        frmPrueba frmCargarDatos;
        frmPrueba frmCargarDatos02;
        frnExcel frmExcel;
        frmRegistro rfmUsuario;

        frmDiligenciacion frmDiligenciaRif;
        frmDiligenciacion frmDiligenciaVPlus;

        frmAboutBox frmAcerca;

     //    frmCarga_Excel_BD frmCargaExcel;


        //  private int childFormNumber = 0;

        public frmMDIParent()
        {
            InitializeComponent();
        }


        public frmMDIParent(string pLogin)
        {
          
            InitializeComponent();
            _idUsuario = pLogin;
        //    _idUsuario = "ADMIN";



        }


        private void ShowNewForm(object sender, EventArgs e)
        {
           
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        //private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
        //    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = saveFileDialog.FileName;
        //    }
        //}

   
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void cargaVigilanciaPLUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCargarDatos02 == null)
            {
                //                Form Formulario = new frmPrueba("97");
                frmCargarDatos02 = new frmPrueba("96", _idUsuario);
                frmCargarDatos02.MdiParent = this;
                frmCargarDatos02.FormClosed += new FormClosedEventHandler(frmCargarDatos02_FormClosed);
                frmCargarDatos02.Show();
            }
            else
            {
                frmCargarDatos02.Activate();
            }
        }
        
        void frmCargarDatos02_FormClosed(object sender, EventArgs e)
        {
            frmCargarDatos02 = null;
        }


        private void cargaVigilanciaRIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 96	Vigilancia Plus
            // 97  RIF
            //   frmCargarCatalogo frCargarCatalogo;
            //   frmPrueba frmCargarDatos;


//            Form1.WindowState = 0 normal
//Form1.WindowState = 1 minimizar
//Form1.WindowState = 2 maximizar



            if (frmCargarDatos == null)
            {
                //                Form Formulario = new frmPrueba("97");
                frmCargarDatos = new frmPrueba("97",_idUsuario);
                frmCargarDatos.Text = " R I F.";

                //                frmCargarDatos.FormBorderStyle = frmCargarDatos.FormBorderStyle.None;
                //               frmCargarDatos.BackColor = Color.Black;

        //        frmCargarDatos.WindowState = FormWindowState.Maximized;
                frmCargarDatos.MdiParent = this;
                frmCargarDatos.FormClosed += new FormClosedEventHandler(frmCargarDatos_FormClosed);
                frmCargarDatos.Show();
            }else
            {
                frmCargarDatos.Activate();
            }

        }

        void frmCargarDatos_FormClosed(object sender, EventArgs e)
        {
            frmCargarDatos = null;
        }



        private void catalogoFundamentoDeVigilanciaPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCatalogoVPlus == null)
            {
                //                Form Formulario = new frmPrueba("97");    frmCatalogoRIF
                frmCatalogoVPlus = new frmCargarCatalogo("96", _idUsuario);
                frmCatalogoVPlus.MdiParent = this;
                frmCatalogoVPlus.FormClosed += new FormClosedEventHandler(frmCatalogoVPlus_FormClosed);
                frmCatalogoVPlus.Show();
            }
            else
            {
                frmCatalogoVPlus.Activate();
            }
        }


       



void frmCatalogoVPlus_FormClosed(object sender, EventArgs e)
        {
            frmCatalogoVPlus = null;
        }


        private void frmMDIParent_Load(object sender, EventArgs e)
        {
            //string vUsuario = _idUsuario.ToString(); ;

            if (_idUsuario == "ADMIN")
            {
                menu_02_Usuario.Visible = true;
                menu_01_Excel.Visible = true;
            }
            else
            {
                menu_02_Usuario.Visible = false;
                menu_01_Excel.Visible = false;
            }

            //    menu_02_Usuario.Visible = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void eXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmExcel == null)
            {
                frmExcel = new frnExcel(_idUsuario);
                frmExcel.MdiParent = this;
                frmExcel.FormClosed += new FormClosedEventHandler(frmExcel_FormClosed);
                frmExcel.Show();

            }
            else
            {
                frmExcel.Activate();
            }
        }


        void frmExcel_FormClosed(object sender, EventArgs e)
        {
            frmExcel = null;
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rfmUsuario == null)
            {
                //                Form Formulario = new frmPrueba("97");
                rfmUsuario = new frmRegistro();
                rfmUsuario.MdiParent = this;
                   rfmUsuario.FormClosed += new FormClosedEventHandler(rfmUsuario_FormClosed);
                rfmUsuario.Show();
            }
            else
            {
                rfmUsuario.Activate();
            }
            
        }

        void rfmUsuario_FormClosed(object sender, EventArgs e)
        {
            rfmUsuario = null;
        }

        private void frmMDIParent_Activated(object sender, EventArgs e)
        {
           
        }

        private void menu_02_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void nume_01_02_03_Catalogo_RIF_Click(object sender, EventArgs e)
        {

            if (frmCatalogoRIF == null)
            {
                //                Form Formulario = new frmPrueba("97");    frmCatalogoRIF
                frmCatalogoRIF = new frmCargarCatalogo("97", _idUsuario);
                frmCatalogoRIF.MdiParent = this;
                frmCatalogoRIF.FormClosed += new FormClosedEventHandler(frmCatalogoRIF_FormClosed);
                frmCatalogoRIF.Show();
            }
            else
            {
                frmCatalogoVPlus.Activate();
            }
        }

        void frmCatalogoRIF_FormClosed(object sender, EventArgs e)
        {
            frmCatalogoVPlus = null;
        }

        private void diligenciacionRIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            frmDiligenciacion frmDiligenciaRif;
 //           frmDiligenciacion frmDiligenciaVPlus;

            if (frmDiligenciaRif == null)
            {
                //                Form Formulario = new frmPrueba("97");    frmCatalogoRIF
                frmDiligenciaRif = new frmDiligenciacion("97", _idUsuario); // RIF
                frmDiligenciaRif.MdiParent = this;
                frmDiligenciaRif.FormClosed += new FormClosedEventHandler(frmDiligenciacionRif_FormClosed);
                frmDiligenciaRif.Show();
            }
            else
            {
                frmDiligenciaRif.Activate();
            }
            
        }

        void frmDiligenciacionRif_FormClosed(object sender, EventArgs e)
        {
            frmDiligenciaRif = null;
        }



        private void diligenciacionPLUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDiligenciaVPlus == null)
            {
                //                Form Formulario = new frmPrueba("97");    frmCatalogoRIF
                frmDiligenciaVPlus = new frmDiligenciacion("96", _idUsuario); // RIF
                frmDiligenciaVPlus.MdiParent = this;
                frmDiligenciaVPlus.FormClosed += new FormClosedEventHandler(frmDiligenciaVPlus_FormClosed);
                frmDiligenciaVPlus.Show();
            }
            else
            {
                frmDiligenciaVPlus.Activate();
            }
        }

        void frmDiligenciaVPlus_FormClosed(object sender, EventArgs e)
        {
            frmDiligenciaVPlus = null;
        }

        private void menu_01_File_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAboutBox Acerca = new frmAboutBox();
            //Acerca.Show();

            if (frmAcerca == null)
            {
                frmAcerca = new frmAboutBox();
                frmAcerca.MdiParent = this;
                frmAcerca.FormClosed += new FormClosedEventHandler(frmAcerca_FormClosed);
                frmAcerca.Show();
            }
            else
            {
                frmAcerca.Activate();
            }
    }

        void frmAcerca_FormClosed(object sender, EventArgs e)
        {
            frmDiligenciaVPlus = null;
        }

        private void menu_01_02_05_PagosExcel_Click(object sender, EventArgs e)
        {

            if (frmExcel == null)
            {
                frmExcel = new frnExcel(_idUsuario);
                frmExcel.MdiParent = this;
                frmExcel.FormClosed += new FormClosedEventHandler(frmExcel_FormClosed);
                frmExcel.Show();

            }
            else
            {
                frmExcel.Activate();
            }


        }
    }
}
