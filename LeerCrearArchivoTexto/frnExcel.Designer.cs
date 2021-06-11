namespace LeerCrearArchivoTexto
{
    partial class frnExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnExcel));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.txtHoja = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExportarBD = new System.Windows.Forms.Button();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEjercicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(502, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(146, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Cargar Archivo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(77, 34);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(405, 20);
            this.txtArchivo.TabIndex = 1;
            // 
            // txtHoja
            // 
            this.txtHoja.Location = new System.Drawing.Point(674, 38);
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(100, 20);
            this.txtHoja.TabIndex = 2;
            this.txtHoja.Text = "Hoja1";
            this.txtHoja.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 243);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hoja a Leer";
            this.label2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(119, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(293, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExportarBD
            // 
            this.btnExportarBD.Location = new System.Drawing.Point(687, 313);
            this.btnExportarBD.Name = "btnExportarBD";
            this.btnExportarBD.Size = new System.Drawing.Size(148, 35);
            this.btnExportarBD.TabIndex = 9;
            this.btnExportarBD.Text = "Subir datos al Servidor";
            this.btnExportarBD.UseVisualStyleBackColor = true;
            this.btnExportarBD.Click += new System.EventHandler(this.btnExportarBD_Click);
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.Enabled = false;
            this.txtEjercicio.Location = new System.Drawing.Point(1004, 344);
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.Size = new System.Drawing.Size(105, 20);
            this.txtEjercicio.TabIndex = 10;
            this.txtEjercicio.TextChanged += new System.EventHandler(this.txtEjercicio_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuario.Location = new System.Drawing.Point(545, 348);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(103, 19);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "UsuarioPrueba";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Usuario :";
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEjercicio.Location = new System.Drawing.Point(545, 321);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(103, 19);
            this.lblEjercicio.TabIndex = 19;
            // 
            // frnExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 376);
            this.Controls.Add(this.lblEjercicio);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.btnExportarBD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHoja);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frnExcel";
            this.Text = "frnExcel";
            this.Load += new System.EventHandler(this.frnExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.TextBox txtHoja;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExportarBD;
        private System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEjercicio;
    }
}