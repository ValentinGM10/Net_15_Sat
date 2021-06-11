namespace LeerCrearArchivoTexto
{
    partial class frmMDIParent
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_01_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_01_RegistroControl = new System.Windows.Forms.ToolStripMenuItem();
            this.nume_01_02_01_RIF = new System.Windows.Forms.ToolStripMenuItem();
            this.nume_01_02_02_V_PLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nume_01_02_03_Catalogo_RIF = new System.Windows.Forms.ToolStripMenuItem();
            this.nume_01_02_04_Catalogo_VPLUS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_01_02_05_PagosExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_01_Separador02 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_01_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_01_Excel = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_02_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diligenciacionRIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diligenciacionPLUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_01_File,
            this.menu_02_Usuario,
            this.sATToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(976, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // menu_01_File
            // 
            this.menu_01_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_01_RegistroControl,
            this.menu_01_Separador02,
            this.menu_01_Salir,
            this.menu_01_Excel});
            this.menu_01_File.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menu_01_File.Name = "menu_01_File";
            this.menu_01_File.Size = new System.Drawing.Size(60, 20);
            this.menu_01_File.Text = "&Archivo";
            this.menu_01_File.Click += new System.EventHandler(this.menu_01_File_Click);
            // 
            // menu_01_RegistroControl
            // 
            this.menu_01_RegistroControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nume_01_02_01_RIF,
            this.nume_01_02_02_V_PLUS,
            this.toolStripSeparator1,
            this.nume_01_02_03_Catalogo_RIF,
            this.nume_01_02_04_Catalogo_VPLUS,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.menu_01_02_05_PagosExcel});
            this.menu_01_RegistroControl.Image = ((System.Drawing.Image)(resources.GetObject("menu_01_RegistroControl.Image")));
            this.menu_01_RegistroControl.ImageTransparentColor = System.Drawing.Color.Black;
            this.menu_01_RegistroControl.Name = "menu_01_RegistroControl";
            this.menu_01_RegistroControl.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_01_RegistroControl.Size = new System.Drawing.Size(212, 22);
            this.menu_01_RegistroControl.Text = "Registro y Control";
            this.menu_01_RegistroControl.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // nume_01_02_01_RIF
            // 
            this.nume_01_02_01_RIF.Name = "nume_01_02_01_RIF";
            this.nume_01_02_01_RIF.Size = new System.Drawing.Size(288, 22);
            this.nume_01_02_01_RIF.Text = "Carga Vigilancia RIF";
            this.nume_01_02_01_RIF.Click += new System.EventHandler(this.cargaVigilanciaRIFToolStripMenuItem_Click);
            // 
            // nume_01_02_02_V_PLUS
            // 
            this.nume_01_02_02_V_PLUS.Name = "nume_01_02_02_V_PLUS";
            this.nume_01_02_02_V_PLUS.Size = new System.Drawing.Size(288, 22);
            this.nume_01_02_02_V_PLUS.Text = "Carga Vigilancia PLUS";
            this.nume_01_02_02_V_PLUS.Click += new System.EventHandler(this.cargaVigilanciaPLUSToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // nume_01_02_03_Catalogo_RIF
            // 
            this.nume_01_02_03_Catalogo_RIF.Name = "nume_01_02_03_Catalogo_RIF";
            this.nume_01_02_03_Catalogo_RIF.Size = new System.Drawing.Size(288, 22);
            this.nume_01_02_03_Catalogo_RIF.Text = "Catálogos Fundamentos de RIF";
            this.nume_01_02_03_Catalogo_RIF.Click += new System.EventHandler(this.nume_01_02_03_Catalogo_RIF_Click);
            // 
            // nume_01_02_04_Catalogo_VPLUS
            // 
            this.nume_01_02_04_Catalogo_VPLUS.Name = "nume_01_02_04_Catalogo_VPLUS";
            this.nume_01_02_04_Catalogo_VPLUS.Size = new System.Drawing.Size(288, 22);
            this.nume_01_02_04_Catalogo_VPLUS.Text = "Catalogo Fundamento de Vigilancia Plus";
            this.nume_01_02_04_Catalogo_VPLUS.Click += new System.EventHandler(this.catalogoFundamentoDeVigilanciaPlusToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(285, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(285, 6);
            // 
            // menu_01_02_05_PagosExcel
            // 
            this.menu_01_02_05_PagosExcel.Name = "menu_01_02_05_PagosExcel";
            this.menu_01_02_05_PagosExcel.Size = new System.Drawing.Size(288, 22);
            this.menu_01_02_05_PagosExcel.Text = "Carga de Pagos";
            this.menu_01_02_05_PagosExcel.Click += new System.EventHandler(this.menu_01_02_05_PagosExcel_Click);
            // 
            // menu_01_Separador02
            // 
            this.menu_01_Separador02.Name = "menu_01_Separador02";
            this.menu_01_Separador02.Size = new System.Drawing.Size(209, 6);
            // 
            // menu_01_Salir
            // 
            this.menu_01_Salir.Name = "menu_01_Salir";
            this.menu_01_Salir.Size = new System.Drawing.Size(212, 22);
            this.menu_01_Salir.Text = "&Salir";
            this.menu_01_Salir.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menu_01_Excel
            // 
            this.menu_01_Excel.Name = "menu_01_Excel";
            this.menu_01_Excel.Size = new System.Drawing.Size(212, 22);
            this.menu_01_Excel.Text = "Excel";
            this.menu_01_Excel.Click += new System.EventHandler(this.eXCELToolStripMenuItem_Click);
            // 
            // menu_02_Usuario
            // 
            this.menu_02_Usuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem});
            this.menu_02_Usuario.Name = "menu_02_Usuario";
            this.menu_02_Usuario.Size = new System.Drawing.Size(154, 20);
            this.menu_02_Usuario.Text = "Administrador de Usuario";
            this.menu_02_Usuario.Click += new System.EventHandler(this.menu_02_Usuario_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // sATToolStripMenuItem
            // 
            this.sATToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diligenciacionRIFToolStripMenuItem,
            this.diligenciacionPLUSToolStripMenuItem});
            this.sATToolStripMenuItem.Name = "sATToolStripMenuItem";
            this.sATToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sATToolStripMenuItem.Text = "SAT";
            // 
            // diligenciacionRIFToolStripMenuItem
            // 
            this.diligenciacionRIFToolStripMenuItem.Name = "diligenciacionRIFToolStripMenuItem";
            this.diligenciacionRIFToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.diligenciacionRIFToolStripMenuItem.Text = "Diligenciación RIF";
            this.diligenciacionRIFToolStripMenuItem.Click += new System.EventHandler(this.diligenciacionRIFToolStripMenuItem_Click);
            // 
            // diligenciacionPLUSToolStripMenuItem
            // 
            this.diligenciacionPLUSToolStripMenuItem.Name = "diligenciacionPLUSToolStripMenuItem";
            this.diligenciacionPLUSToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.diligenciacionPLUSToolStripMenuItem.Text = "Diligenciación PLUS";
            this.diligenciacionPLUSToolStripMenuItem.Click += new System.EventHandler(this.diligenciacionPLUSToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 440);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(976, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // frmMDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 462);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMDIParent";
            this.Text = "Carga de Archivo de Texto";
            this.Activated += new System.EventHandler(this.frmMDIParent_Activated);
            this.Load += new System.EventHandler(this.frmMDIParent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator menu_01_Separador02;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem menu_01_File;
        private System.Windows.Forms.ToolStripMenuItem menu_01_RegistroControl;
        private System.Windows.Forms.ToolStripMenuItem menu_01_Salir;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem nume_01_02_01_RIF;
        private System.Windows.Forms.ToolStripMenuItem nume_01_02_02_V_PLUS;
        private System.Windows.Forms.ToolStripMenuItem nume_01_02_04_Catalogo_VPLUS;
        private System.Windows.Forms.ToolStripMenuItem menu_01_Excel;
        private System.Windows.Forms.ToolStripMenuItem menu_02_Usuario;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nume_01_02_03_Catalogo_RIF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diligenciacionRIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diligenciacionPLUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menu_01_02_05_PagosExcel;
    }
}



