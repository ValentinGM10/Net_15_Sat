namespace LeerCrearArchivoTexto
{
    partial class frmCargarCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarCatalogo));
            this.dgvTexto = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnLeerArchivoTxt = new System.Windows.Forms.Button();
            this.txtContar = new System.Windows.Forms.Label();
            this.lblObligacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTexto
            // 
            this.dgvTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTexto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTexto.Location = new System.Drawing.Point(16, 33);
            this.dgvTexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTexto.Name = "dgvTexto";
            this.dgvTexto.Size = new System.Drawing.Size(1160, 298);
            this.dgvTexto.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(197, 353);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(173, 28);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Subir datos al Servidor";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnLeerArchivoTxt
            // 
            this.btnLeerArchivoTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeerArchivoTxt.CausesValidation = false;
            this.btnLeerArchivoTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeerArchivoTxt.Location = new System.Drawing.Point(16, 353);
            this.btnLeerArchivoTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeerArchivoTxt.Name = "btnLeerArchivoTxt";
            this.btnLeerArchivoTxt.Size = new System.Drawing.Size(173, 28);
            this.btnLeerArchivoTxt.TabIndex = 4;
            this.btnLeerArchivoTxt.Text = "Leer Archivo Txt";
            this.btnLeerArchivoTxt.UseVisualStyleBackColor = true;
            this.btnLeerArchivoTxt.Click += new System.EventHandler(this.btnLeerArchivoTxt_Click);
            // 
            // txtContar
            // 
            this.txtContar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtContar.Location = new System.Drawing.Point(1045, 353);
            this.txtContar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtContar.Name = "txtContar";
            this.txtContar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContar.Size = new System.Drawing.Size(131, 18);
            this.txtContar.TabIndex = 6;
            this.txtContar.Text = "0";
            // 
            // lblObligacion
            // 
            this.lblObligacion.AutoSize = true;
            this.lblObligacion.Location = new System.Drawing.Point(660, 366);
            this.lblObligacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObligacion.Name = "lblObligacion";
            this.lblObligacion.Size = new System.Drawing.Size(45, 16);
            this.lblObligacion.TabIndex = 12;
            this.lblObligacion.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "id Obligación";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuario.Location = new System.Drawing.Point(1045, 406);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(131, 16);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "UsuarioPrueba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(972, 407);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Usuario :";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(16, 391);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(353, 44);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblColumnas
            // 
            this.lblColumnas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColumnas.Location = new System.Drawing.Point(1045, 379);
            this.lblColumnas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblColumnas.Size = new System.Drawing.Size(131, 17);
            this.lblColumnas.TabIndex = 19;
            this.lblColumnas.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(935, 356);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "No. Registros: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(963, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Columnas:";
            // 
            // frmCargarCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1212, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColumnas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblObligacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnLeerArchivoTxt);
            this.Controls.Add(this.dgvTexto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargarCatalogo";
            this.Text = "Cargar Catalogo";
            this.Load += new System.EventHandler(this.frmCargarCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTexto;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnLeerArchivoTxt;
        private System.Windows.Forms.Label txtContar;
        private System.Windows.Forms.Label lblObligacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}