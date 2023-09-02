namespace CapaPresentacion
{
    partial class frmCambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarContraseña));
            this.lblPasswordActual = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPassword2 = new System.Windows.Forms.Label();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPasswordActual
            // 
            this.lblPasswordActual.AutoSize = true;
            this.lblPasswordActual.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordActual.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblPasswordActual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPasswordActual.Location = new System.Drawing.Point(76, 76);
            this.lblPasswordActual.Name = "lblPasswordActual";
            this.lblPasswordActual.Size = new System.Drawing.Size(161, 22);
            this.lblPasswordActual.TabIndex = 8;
            this.lblPasswordActual.Text = "Contraseña actual";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(119, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 22);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(67, 101);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(67, 41);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblNewPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewPassword.Location = new System.Drawing.Point(78, 173);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(162, 22);
            this.lblNewPassword.TabIndex = 10;
            this.lblNewPassword.Text = "Contraseña nueva";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(69, 198);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(183, 20);
            this.txtNewPass.TabIndex = 9;
            // 
            // lblNewPassword2
            // 
            this.lblNewPassword2.AutoSize = true;
            this.lblNewPassword2.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblNewPassword2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewPassword2.Location = new System.Drawing.Point(76, 233);
            this.lblNewPassword2.Name = "lblNewPassword2";
            this.lblNewPassword2.Size = new System.Drawing.Size(170, 22);
            this.lblNewPassword2.TabIndex = 12;
            this.lblNewPassword2.Text = "Repetir contraseña";
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Location = new System.Drawing.Point(69, 258);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.PasswordChar = '*';
            this.txtNewPass2.Size = new System.Drawing.Size(183, 20);
            this.txtNewPass2.TabIndex = 11;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(87, 295);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(147, 36);
            this.btnCambiar.TabIndex = 13;
            this.btnCambiar.Text = "CAMBIAR";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondo_login;
            this.ClientSize = new System.Drawing.Size(318, 356);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblNewPassword2);
            this.Controls.Add(this.txtNewPass2);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lblPasswordActual);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.frmCambiarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordActual;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPassword2;
        private System.Windows.Forms.TextBox txtNewPass2;
        private System.Windows.Forms.Button btnCambiar;
    }
}