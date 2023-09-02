namespace CapaPresentacion
{
    partial class frmFicha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFicha));
            this.pctFicha = new System.Windows.Forms.PictureBox();
            this.dtgFicha = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAptoFisico = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAbono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctFicha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFicha)).BeginInit();
            this.SuspendLayout();
            // 
            // pctFicha
            // 
            this.pctFicha.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctFicha.ErrorImage")));
            this.pctFicha.InitialImage = global::CapaPresentacion.Properties.Resources.silueta;
            this.pctFicha.Location = new System.Drawing.Point(12, 12);
            this.pctFicha.Name = "pctFicha";
            this.pctFicha.Size = new System.Drawing.Size(120, 120);
            this.pctFicha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFicha.TabIndex = 0;
            this.pctFicha.TabStop = false;
            // 
            // dtgFicha
            // 
            this.dtgFicha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFicha.Location = new System.Drawing.Point(12, 147);
            this.dtgFicha.Name = "dtgFicha";
            this.dtgFicha.RowHeadersWidth = 62;
            this.dtgFicha.Size = new System.Drawing.Size(453, 77);
            this.dtgFicha.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(365, 82);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 41);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(147, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "APTO FÍSICO:";
            // 
            // lblAptoFisico
            // 
            this.lblAptoFisico.AutoSize = true;
            this.lblAptoFisico.BackColor = System.Drawing.Color.Transparent;
            this.lblAptoFisico.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAptoFisico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAptoFisico.Location = new System.Drawing.Point(257, 43);
            this.lblAptoFisico.Name = "lblAptoFisico";
            this.lblAptoFisico.Size = new System.Drawing.Size(48, 14);
            this.lblAptoFisico.TabIndex = 4;
            this.lblAptoFisico.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(147, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ABONO:";
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.BackColor = System.Drawing.Color.Transparent;
            this.lblAbono.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAbono.Location = new System.Drawing.Point(217, 82);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(54, 17);
            this.lblAbono.TabIndex = 6;
            this.lblAbono.Text = "label4";
            // 
            // frmFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(475, 233);
            this.Controls.Add(this.lblAbono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAptoFisico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtgFicha);
            this.Controls.Add(this.pctFicha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFicha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha Cliente";
            this.Load += new System.EventHandler(this.frmFicha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFicha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFicha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFicha;
        private System.Windows.Forms.DataGridView dtgFicha;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAptoFisico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAbono;
    }
}