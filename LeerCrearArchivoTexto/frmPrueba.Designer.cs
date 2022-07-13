namespace LeerCrearArchivoTexto
{
    partial class frmPrueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrueba));
            this.dgvTexto = new System.Windows.Forms.DataGridView();
            this.btnLeerArchivoTxt = new System.Windows.Forms.Button();
            this.txtContar = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblNoCarga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblObligacion = new System.Windows.Forms.Label();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.lblVentana = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubirtxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTexto
            // 
            this.dgvTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTexto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTexto.Location = new System.Drawing.Point(16, 44);
            this.dgvTexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTexto.Name = "dgvTexto";
            this.dgvTexto.Size = new System.Drawing.Size(1155, 298);
            this.dgvTexto.TabIndex = 0;
            // 
            // btnLeerArchivoTxt
            // 
            this.btnLeerArchivoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeerArchivoTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeerArchivoTxt.Location = new System.Drawing.Point(16, 356);
            this.btnLeerArchivoTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeerArchivoTxt.Name = "btnLeerArchivoTxt";
            this.btnLeerArchivoTxt.Size = new System.Drawing.Size(173, 34);
            this.btnLeerArchivoTxt.TabIndex = 1;
            this.btnLeerArchivoTxt.Text = "Leer Archivo Txt";
            this.btnLeerArchivoTxt.UseVisualStyleBackColor = true;
            this.btnLeerArchivoTxt.Click += new System.EventHandler(this.btnLeerArchivoTxt_Click);
            // 
            // txtContar
            // 
            this.txtContar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtContar.Location = new System.Drawing.Point(955, 364);
            this.txtContar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtContar.Name = "txtContar";
            this.txtContar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContar.Size = new System.Drawing.Size(133, 18);
            this.txtContar.TabIndex = 2;
            this.txtContar.Text = "0";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.AutoSize = true;
            this.btnExportar.Location = new System.Drawing.Point(197, 356);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(173, 34);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Subir datos al Servidor";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblNoCarga
            // 
            this.lblNoCarga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoCarga.AutoSize = true;
            this.lblNoCarga.Location = new System.Drawing.Point(597, 431);
            this.lblNoCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoCarga.Name = "lblNoCarga";
            this.lblNoCarga.Size = new System.Drawing.Size(15, 16);
            this.lblNoCarga.TabIndex = 4;
            this.lblNoCarga.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero de Carga:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ejercicio:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 373);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "id Obligación:";
            // 
            // lblObligacion
            // 
            this.lblObligacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObligacion.AutoSize = true;
            this.lblObligacion.Location = new System.Drawing.Point(597, 374);
            this.lblObligacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObligacion.Name = "lblObligacion";
            this.lblObligacion.Size = new System.Drawing.Size(15, 16);
            this.lblObligacion.TabIndex = 10;
            this.lblObligacion.Text = "0";
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.Location = new System.Drawing.Point(597, 402);
            this.lblEjercicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(15, 16);
            this.lblEjercicio.TabIndex = 11;
            this.lblEjercicio.Text = "0";
            this.lblEjercicio.Click += new System.EventHandler(this.lblEjercicio_Click);
            // 
            // lblVentana
            // 
            this.lblVentana.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblVentana.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVentana.Location = new System.Drawing.Point(16, 11);
            this.lblVentana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVentana.Name = "lblVentana";
            this.lblVentana.Size = new System.Drawing.Size(1101, 30);
            this.lblVentana.TabIndex = 12;
            this.lblVentana.Text = "label4";
            this.lblVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.AutoSize = true;
            this.btnSalir.Location = new System.Drawing.Point(16, 407);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(353, 44);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(877, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Usuario :";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuario.Location = new System.Drawing.Point(951, 428);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(137, 23);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "UsuarioPrueba";
            // 
            // lblColumnas
            // 
            this.lblColumnas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColumnas.Location = new System.Drawing.Point(955, 395);
            this.lblColumnas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblColumnas.Size = new System.Drawing.Size(133, 23);
            this.lblColumnas.TabIndex = 16;
            this.lblColumnas.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(868, 399);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Columnas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "No. Registros: ";
            // 
            // btnSubirtxt
            // 
            this.btnSubirtxt.Location = new System.Drawing.Point(379, 350);
            this.btnSubirtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubirtxt.Name = "btnSubirtxt";
            this.btnSubirtxt.Size = new System.Drawing.Size(83, 28);
            this.btnSubirtxt.TabIndex = 24;
            this.btnSubirtxt.Text = "Subir 1x1";
            this.btnSubirtxt.UseVisualStyleBackColor = true;
            this.btnSubirtxt.Visible = false;
            this.btnSubirtxt.Click += new System.EventHandler(this.btnSubirtxt_Click);
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1201, 462);
            this.Controls.Add(this.btnSubirtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblColumnas);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblVentana);
            this.Controls.Add(this.lblEjercicio);
            this.Controls.Add(this.lblObligacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoCarga);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.txtContar);
            this.Controls.Add(this.btnLeerArchivoTxt);
            this.Controls.Add(this.dgvTexto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTexto;
        private System.Windows.Forms.Button btnLeerArchivoTxt;
        private System.Windows.Forms.Label txtContar;
        private System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.Label lblNoCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblObligacion;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.Label lblVentana;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubirtxt;
    }
}