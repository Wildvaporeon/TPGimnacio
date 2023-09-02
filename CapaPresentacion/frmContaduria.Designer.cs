namespace CapaPresentacion
{
    partial class frmContaduria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContaduria));
            this.dtgContaduria = new System.Windows.Forms.DataGridView();
            this.dttInicio = new System.Windows.Forms.DateTimePicker();
            this.dttFinal = new System.Windows.Forms.DateTimePicker();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContaduria)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgContaduria
            // 
            this.dtgContaduria.AllowUserToAddRows = false;
            this.dtgContaduria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContaduria.Location = new System.Drawing.Point(12, 12);
            this.dtgContaduria.Name = "dtgContaduria";
            this.dtgContaduria.RowHeadersWidth = 62;
            this.dtgContaduria.Size = new System.Drawing.Size(505, 278);
            this.dtgContaduria.TabIndex = 3;
            // 
            // dttInicio
            // 
            this.dttInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttInicio.Location = new System.Drawing.Point(548, 52);
            this.dttInicio.Name = "dttInicio";
            this.dttInicio.Size = new System.Drawing.Size(80, 20);
            this.dttInicio.TabIndex = 4;
            this.dttInicio.Value = new System.DateTime(2022, 10, 30, 17, 46, 0, 0);
            // 
            // dttFinal
            // 
            this.dttFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttFinal.Location = new System.Drawing.Point(658, 52);
            this.dttFinal.Name = "dttFinal";
            this.dttFinal.Size = new System.Drawing.Size(80, 20);
            this.dttFinal.TabIndex = 5;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(548, 201);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(120, 35);
            this.btnVisualizar.TabIndex = 6;
            this.btnVisualizar.Text = "Visualizar ingresos";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(548, 255);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(122, 35);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.Color.White;
            this.lblFechaInicio.Location = new System.Drawing.Point(545, 33);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(85, 15);
            this.lblFechaInicio.TabIndex = 8;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.ForeColor = System.Drawing.Color.White;
            this.lblFechaFinal.Location = new System.Drawing.Point(655, 34);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(82, 15);
            this.lblFechaFinal.TabIndex = 9;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(698, 255);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 35);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(698, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmContaduria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondo_app;
            this.ClientSize = new System.Drawing.Size(774, 302);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.dttFinal);
            this.Controls.Add(this.dttInicio);
            this.Controls.Add(this.dtgContaduria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmContaduria";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contaduria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmContaduria_FormClosing);
            this.Load += new System.EventHandler(this.frmContaduria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContaduria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgContaduria;
        private System.Windows.Forms.DateTimePicker dttInicio;
        private System.Windows.Forms.DateTimePicker dttFinal;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
    }
}