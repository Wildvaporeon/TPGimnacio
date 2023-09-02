namespace CapaPresentacion
{
    partial class frmIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdioma));
            this.lblEspañol = new System.Windows.Forms.Label();
            this.lblIngles = new System.Windows.Forms.Label();
            this.btnIngles = new System.Windows.Forms.Button();
            this.btnEspañol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEspañol
            // 
            this.lblEspañol.AutoSize = true;
            this.lblEspañol.BackColor = System.Drawing.Color.Transparent;
            this.lblEspañol.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblEspañol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEspañol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEspañol.Location = new System.Drawing.Point(74, 73);
            this.lblEspañol.Name = "lblEspañol";
            this.lblEspañol.Size = new System.Drawing.Size(193, 22);
            this.lblEspañol.TabIndex = 1;
            this.lblEspañol.Text = "Seleccionar Lenguaje";
            // 
            // lblIngles
            // 
            this.lblIngles.AutoSize = true;
            this.lblIngles.BackColor = System.Drawing.Color.Transparent;
            this.lblIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblIngles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIngles.Location = new System.Drawing.Point(316, 73);
            this.lblIngles.Name = "lblIngles";
            this.lblIngles.Size = new System.Drawing.Size(152, 24);
            this.lblIngles.TabIndex = 3;
            this.lblIngles.Text = "Select Language";
            // 
            // btnIngles
            // 
            this.btnIngles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnIngles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngles.Image = ((System.Drawing.Image)(resources.GetObject("btnIngles.Image")));
            this.btnIngles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIngles.Location = new System.Drawing.Point(298, 114);
            this.btnIngles.Name = "btnIngles";
            this.btnIngles.Size = new System.Drawing.Size(190, 100);
            this.btnIngles.TabIndex = 2;
            this.btnIngles.Text = "English";
            this.btnIngles.UseVisualStyleBackColor = true;
            this.btnIngles.Click += new System.EventHandler(this.btnIngles_Click);
            // 
            // btnEspañol
            // 
            this.btnEspañol.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEspañol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEspañol.Image = ((System.Drawing.Image)(resources.GetObject("btnEspañol.Image")));
            this.btnEspañol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEspañol.Location = new System.Drawing.Point(77, 114);
            this.btnEspañol.Name = "btnEspañol";
            this.btnEspañol.Size = new System.Drawing.Size(190, 100);
            this.btnEspañol.TabIndex = 0;
            this.btnEspañol.Text = "Español";
            this.btnEspañol.UseVisualStyleBackColor = true;
            this.btnEspañol.Click += new System.EventHandler(this.btnEspañol_Click);
            // 
            // frmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnEspañol;
            this.ClientSize = new System.Drawing.Size(573, 317);
            this.Controls.Add(this.lblIngles);
            this.Controls.Add(this.btnIngles);
            this.Controls.Add(this.lblEspañol);
            this.Controls.Add(this.btnEspañol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Admin";
            this.Load += new System.EventHandler(this.frmIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEspañol;
        private System.Windows.Forms.Label lblEspañol;
        private System.Windows.Forms.Button btnIngles;
        private System.Windows.Forms.Label lblIngles;
    }
}

