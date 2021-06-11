namespace LeerCrearArchivoTexto
{
    partial class frmDiligenciacion
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelNonQuery = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.lblObligacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(258, 48);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(37, 265);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(10, 13);
            this.LabelStatus.TabIndex = 1;
            this.LabelStatus.Text = "-";
            // 
            // LabelNonQuery
            // 
            this.LabelNonQuery.AutoSize = true;
            this.LabelNonQuery.Location = new System.Drawing.Point(37, 283);
            this.LabelNonQuery.Name = "LabelNonQuery";
            this.LabelNonQuery.Size = new System.Drawing.Size(10, 13);
            this.LabelNonQuery.TabIndex = 2;
            this.LabelNonQuery.Text = "-";
            this.LabelNonQuery.Click += new System.EventHandler(this.LabelNonQuery_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(23, 93);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(747, 150);
            this.dgvConsulta.TabIndex = 3;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(40, 310);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(153, 23);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Generar Archivo de Texto";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero de Carga:";
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Location = new System.Drawing.Point(746, 64);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(24, 23);
            this.btnDirectorio.TabIndex = 7;
            this.btnDirectorio.Text = "...";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // lblObligacion
            // 
            this.lblObligacion.AutoSize = true;
            this.lblObligacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObligacion.Location = new System.Drawing.Point(364, 9);
            this.lblObligacion.Name = "lblObligacion";
            this.lblObligacion.Size = new System.Drawing.Size(57, 20);
            this.lblObligacion.TabIndex = 8;
            this.lblObligacion.Text = "label2";
            // 
            // frmDiligenciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 357);
            this.Controls.Add(this.lblObligacion);
            this.Controls.Add(this.btnDirectorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.LabelNonQuery);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmDiligenciacion";
            this.Text = "frmDiligenciacion";
            this.Load += new System.EventHandler(this.frmDiligenciacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelNonQuery;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.Label lblObligacion;
    }
}