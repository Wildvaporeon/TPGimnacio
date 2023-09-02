namespace CapaPresentacion
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.dtgIngreso = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAdmClientes = new System.Windows.Forms.Button();
            this.btnGestionClases = new System.Windows.Forms.Button();
            this.btnGestionTurnos = new System.Windows.Forms.Button();
            this.btnVentaProductos = new System.Windows.Forms.Button();
            this.btnGestionAbono = new System.Windows.Forms.Button();
            this.lblHistorialIngreso = new System.Windows.Forms.Label();
            this.btnDesloguear = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnReposProductos = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngreso)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(12, 12);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtIngreso.TabIndex = 0;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdCliente.Location = new System.Drawing.Point(29, 35);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(70, 15);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "ID Cliente";
            // 
            // dtgIngreso
            // 
            this.dtgIngreso.AllowUserToAddRows = false;
            this.dtgIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIngreso.Location = new System.Drawing.Point(24, 118);
            this.dtgIngreso.Name = "dtgIngreso";
            this.dtgIngreso.Size = new System.Drawing.Size(299, 278);
            this.dtgIngreso.TabIndex = 2;
            this.dtgIngreso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgIngreso_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(24, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAdmClientes
            // 
            this.btnAdmClientes.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmClientes.Location = new System.Drawing.Point(354, 113);
            this.btnAdmClientes.Name = "btnAdmClientes";
            this.btnAdmClientes.Size = new System.Drawing.Size(204, 29);
            this.btnAdmClientes.TabIndex = 4;
            this.btnAdmClientes.Text = "Administración de clientes";
            this.btnAdmClientes.UseVisualStyleBackColor = true;
            this.btnAdmClientes.Click += new System.EventHandler(this.btnAdmClientes_Click);
            // 
            // btnGestionClases
            // 
            this.btnGestionClases.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionClases.Location = new System.Drawing.Point(354, 148);
            this.btnGestionClases.Name = "btnGestionClases";
            this.btnGestionClases.Size = new System.Drawing.Size(204, 29);
            this.btnGestionClases.TabIndex = 5;
            this.btnGestionClases.Text = "Gestión de clases";
            this.btnGestionClases.UseVisualStyleBackColor = true;
            this.btnGestionClases.Click += new System.EventHandler(this.btnGestionClases_Click);
            // 
            // btnGestionTurnos
            // 
            this.btnGestionTurnos.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionTurnos.Location = new System.Drawing.Point(354, 183);
            this.btnGestionTurnos.Name = "btnGestionTurnos";
            this.btnGestionTurnos.Size = new System.Drawing.Size(204, 29);
            this.btnGestionTurnos.TabIndex = 6;
            this.btnGestionTurnos.Text = "Gestión de turnos";
            this.btnGestionTurnos.UseVisualStyleBackColor = true;
            this.btnGestionTurnos.Click += new System.EventHandler(this.btnGestionTurnos_Click);
            // 
            // btnVentaProductos
            // 
            this.btnVentaProductos.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaProductos.Location = new System.Drawing.Point(354, 218);
            this.btnVentaProductos.Name = "btnVentaProductos";
            this.btnVentaProductos.Size = new System.Drawing.Size(204, 29);
            this.btnVentaProductos.TabIndex = 7;
            this.btnVentaProductos.Text = "Venta de productos";
            this.btnVentaProductos.UseVisualStyleBackColor = true;
            this.btnVentaProductos.Click += new System.EventHandler(this.btnVentaProductos_Click);
            // 
            // btnGestionAbono
            // 
            this.btnGestionAbono.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAbono.Location = new System.Drawing.Point(354, 253);
            this.btnGestionAbono.Name = "btnGestionAbono";
            this.btnGestionAbono.Size = new System.Drawing.Size(204, 29);
            this.btnGestionAbono.TabIndex = 8;
            this.btnGestionAbono.Text = "Gestión de abono";
            this.btnGestionAbono.UseVisualStyleBackColor = true;
            this.btnGestionAbono.Click += new System.EventHandler(this.btnGestionAbono_Click);
            // 
            // lblHistorialIngreso
            // 
            this.lblHistorialIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblHistorialIngreso.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialIngreso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHistorialIngreso.Location = new System.Drawing.Point(21, 87);
            this.lblHistorialIngreso.Name = "lblHistorialIngreso";
            this.lblHistorialIngreso.Size = new System.Drawing.Size(135, 18);
            this.lblHistorialIngreso.TabIndex = 9;
            this.lblHistorialIngreso.Text = "Historial de ingreso";
            // 
            // btnDesloguear
            // 
            this.btnDesloguear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesloguear.Location = new System.Drawing.Point(464, 401);
            this.btnDesloguear.Name = "btnDesloguear";
            this.btnDesloguear.Size = new System.Drawing.Size(94, 31);
            this.btnDesloguear.TabIndex = 10;
            this.btnDesloguear.Text = "Desloguear";
            this.btnDesloguear.UseVisualStyleBackColor = true;
            this.btnDesloguear.Click += new System.EventHandler(this.btnDesloguear_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUser.Location = new System.Drawing.Point(240, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(135, 16);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Usuario Logueado";
            // 
            // btnReposProductos
            // 
            this.btnReposProductos.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReposProductos.Location = new System.Drawing.Point(354, 288);
            this.btnReposProductos.Name = "btnReposProductos";
            this.btnReposProductos.Size = new System.Drawing.Size(204, 29);
            this.btnReposProductos.TabIndex = 12;
            this.btnReposProductos.Text = "Reposición de productos";
            this.btnReposProductos.UseVisualStyleBackColor = true;
            this.btnReposProductos.Click += new System.EventHandler(this.btnReposProductos_Click_1);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(119, 10);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnIngreso.TabIndex = 13;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 444);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnReposProductos);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnDesloguear);
            this.Controls.Add(this.lblHistorialIngreso);
            this.Controls.Add(this.btnGestionAbono);
            this.Controls.Add(this.btnVentaProductos);
            this.Controls.Add(this.btnGestionTurnos);
            this.Controls.Add(this.btnGestionClases);
            this.Controls.Add(this.btnAdmClientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgIngreso);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.txtIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAdmClientes;
        private System.Windows.Forms.Button btnGestionClases;
        private System.Windows.Forms.Button btnGestionTurnos;
        private System.Windows.Forms.Button btnVentaProductos;
        private System.Windows.Forms.Button btnGestionAbono;
        private System.Windows.Forms.Label lblHistorialIngreso;
        private System.Windows.Forms.Button btnDesloguear;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnReposProductos;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.DataGridView dtgIngreso;
    }
}