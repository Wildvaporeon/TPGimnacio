namespace CapaPresentacion
{
    partial class frmAcerca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcerca));
            this.lblAcerca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAcerca
            // 
            this.lblAcerca.AutoSize = true;
            this.lblAcerca.Font = new System.Drawing.Font("Dubai", 12F);
            this.lblAcerca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcerca.Location = new System.Drawing.Point(12, 9);
            this.lblAcerca.Name = "lblAcerca";
            this.lblAcerca.Size = new System.Drawing.Size(318, 270);
            this.lblAcerca.TabIndex = 1;
            this.lblAcerca.Text = resources.GetString("lblAcerca.Text");
            // 
            // frmAcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(377, 297);
            this.Controls.Add(this.lblAcerca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcerca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            this.Load += new System.EventHandler(this.frmAcerca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcerca;
    }
}