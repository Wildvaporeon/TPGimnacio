namespace CapaPresentacion
{
    partial class frmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeAbonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDePermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contaduriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoExitosoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDenegadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reposiciónStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmClientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesYBloqueosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesloguear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgAdmin = new System.Windows.Forms.DataGridView();
            this.lblBitacora = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.clasesToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.reportesToolStripMenuItem1,
            this.respaldoToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeClientesToolStripMenuItem,
            this.controlDeIngresoToolStripMenuItem,
            this.gestiónDeAbonoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // administraciónDeClientesToolStripMenuItem
            // 
            this.administraciónDeClientesToolStripMenuItem.Name = "administraciónDeClientesToolStripMenuItem";
            this.administraciónDeClientesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.administraciónDeClientesToolStripMenuItem.Text = "Administración de Clientes";
            this.administraciónDeClientesToolStripMenuItem.Click += new System.EventHandler(this.administraciónDeClientesToolStripMenuItem_Click);
            // 
            // controlDeIngresoToolStripMenuItem
            // 
            this.controlDeIngresoToolStripMenuItem.Name = "controlDeIngresoToolStripMenuItem";
            this.controlDeIngresoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.controlDeIngresoToolStripMenuItem.Text = "Control de ingreso";
            this.controlDeIngresoToolStripMenuItem.Click += new System.EventHandler(this.controlDeIngresoToolStripMenuItem_Click);
            // 
            // gestiónDeAbonoToolStripMenuItem
            // 
            this.gestiónDeAbonoToolStripMenuItem.Name = "gestiónDeAbonoToolStripMenuItem";
            this.gestiónDeAbonoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.gestiónDeAbonoToolStripMenuItem.Text = "Gestión de abono";
            this.gestiónDeAbonoToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeAbonoToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeUsuariosToolStripMenuItem,
            this.gestiónDePermisosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.usuariosToolStripMenuItem.Text = "Administrar Nomina";
            // 
            // administraciónDeUsuariosToolStripMenuItem
            // 
            this.administraciónDeUsuariosToolStripMenuItem.Name = "administraciónDeUsuariosToolStripMenuItem";
            this.administraciónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.administraciónDeUsuariosToolStripMenuItem.Text = "Gestión de empleados y usuarios";
            this.administraciónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administraciónDeUsuariosToolStripMenuItem_Click);
            // 
            // gestiónDePermisosToolStripMenuItem
            // 
            this.gestiónDePermisosToolStripMenuItem.Name = "gestiónDePermisosToolStripMenuItem";
            this.gestiónDePermisosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.gestiónDePermisosToolStripMenuItem.Text = "Roles y Bloqueos";
            this.gestiónDePermisosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDePermisosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeProductosToolStripMenuItem,
            this.ventaDeProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // administraciónDeProductosToolStripMenuItem
            // 
            this.administraciónDeProductosToolStripMenuItem.Name = "administraciónDeProductosToolStripMenuItem";
            this.administraciónDeProductosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.administraciónDeProductosToolStripMenuItem.Text = "Administración de productos";
            this.administraciónDeProductosToolStripMenuItem.Click += new System.EventHandler(this.administraciónDeProductosToolStripMenuItem_Click);
            // 
            // ventaDeProductosToolStripMenuItem
            // 
            this.ventaDeProductosToolStripMenuItem.Name = "ventaDeProductosToolStripMenuItem";
            this.ventaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.ventaDeProductosToolStripMenuItem.Text = "Venta de productos";
            this.ventaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.ventaDeProductosToolStripMenuItem_Click);
            // 
            // clasesToolStripMenuItem
            // 
            this.clasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeClasesToolStripMenuItem});
            this.clasesToolStripMenuItem.Name = "clasesToolStripMenuItem";
            this.clasesToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.clasesToolStripMenuItem.Text = "Clases";
            // 
            // administraciónDeClasesToolStripMenuItem
            // 
            this.administraciónDeClasesToolStripMenuItem.Name = "administraciónDeClasesToolStripMenuItem";
            this.administraciónDeClasesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.administraciónDeClasesToolStripMenuItem.Text = "Administración de clases";
            this.administraciónDeClasesToolStripMenuItem.Click += new System.EventHandler(this.administraciónDeClasesToolStripMenuItem_Click);
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeTurnosToolStripMenuItem});
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // administraciónDeTurnosToolStripMenuItem
            // 
            this.administraciónDeTurnosToolStripMenuItem.Name = "administraciónDeTurnosToolStripMenuItem";
            this.administraciónDeTurnosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.administraciónDeTurnosToolStripMenuItem.Text = "Administración de turnos";
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaduriaToolStripMenuItem1,
            this.bitacoraToolStripMenuItem1});
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(65, 22);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // contaduriaToolStripMenuItem1
            // 
            this.contaduriaToolStripMenuItem1.Name = "contaduriaToolStripMenuItem1";
            this.contaduriaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.contaduriaToolStripMenuItem1.Text = "Contaduria";
            this.contaduriaToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // bitacoraToolStripMenuItem1
            // 
            this.bitacoraToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.reposiciónStockToolStripMenuItem,
            this.abmClientesToolStripMenuItem2,
            this.usuariosToolStripMenuItem2,
            this.rolesYBloqueosToolStripMenuItem});
            this.bitacoraToolStripMenuItem1.Name = "bitacoraToolStripMenuItem1";
            this.bitacoraToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bitacoraToolStripMenuItem1.Text = "Bitacora del Sistema";
            this.bitacoraToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ingresoToolStripMenuItem.Text = "Ingreso Clientes";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoExitosoToolStripMenuItem,
            this.ingresoDenegadoToolStripMenuItem,
            this.cambioDeContraseñaToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.loginToolStripMenuItem.Text = "Logueo";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // ingresoExitosoToolStripMenuItem
            // 
            this.ingresoExitosoToolStripMenuItem.Name = "ingresoExitosoToolStripMenuItem";
            this.ingresoExitosoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ingresoExitosoToolStripMenuItem.Text = "Ingreso Exitoso";
            this.ingresoExitosoToolStripMenuItem.Click += new System.EventHandler(this.ingresoExitosoToolStripMenuItem_Click);
            // 
            // ingresoDenegadoToolStripMenuItem
            // 
            this.ingresoDenegadoToolStripMenuItem.Name = "ingresoDenegadoToolStripMenuItem";
            this.ingresoDenegadoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ingresoDenegadoToolStripMenuItem.Text = "Ingreso Denegado";
            this.ingresoDenegadoToolStripMenuItem.Click += new System.EventHandler(this.ingresoDenegadoToolStripMenuItem_Click);
            // 
            // cambioDeContraseñaToolStripMenuItem
            // 
            this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
            this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.cambioDeContraseñaToolStripMenuItem.Text = "Cambio de Contraseña";
            this.cambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContraseñaToolStripMenuItem_Click);
            // 
            // reposiciónStockToolStripMenuItem
            // 
            this.reposiciónStockToolStripMenuItem.Name = "reposiciónStockToolStripMenuItem";
            this.reposiciónStockToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.reposiciónStockToolStripMenuItem.Text = "Reposición Stock";
            this.reposiciónStockToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // abmClientesToolStripMenuItem2
            // 
            this.abmClientesToolStripMenuItem2.Name = "abmClientesToolStripMenuItem2";
            this.abmClientesToolStripMenuItem2.Size = new System.Drawing.Size(164, 22);
            this.abmClientesToolStripMenuItem2.Text = "ABM Clientes";
            this.abmClientesToolStripMenuItem2.Click += new System.EventHandler(this.clientesToolStripMenuItem2_Click);
            // 
            // usuariosToolStripMenuItem2
            // 
            this.usuariosToolStripMenuItem2.Name = "usuariosToolStripMenuItem2";
            this.usuariosToolStripMenuItem2.Size = new System.Drawing.Size(164, 22);
            this.usuariosToolStripMenuItem2.Text = "ABM Usuarios";
            this.usuariosToolStripMenuItem2.Click += new System.EventHandler(this.usuariosToolStripMenuItem2_Click);
            // 
            // rolesYBloqueosToolStripMenuItem
            // 
            this.rolesYBloqueosToolStripMenuItem.Name = "rolesYBloqueosToolStripMenuItem";
            this.rolesYBloqueosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.rolesYBloqueosToolStripMenuItem.Text = "Roles y Bloqueos";
            this.rolesYBloqueosToolStripMenuItem.Click += new System.EventHandler(this.rolesYBloqueosToolStripMenuItem_Click);
            // 
            // respaldoToolStripMenuItem
            // 
            this.respaldoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respaldarBDToolStripMenuItem,
            this.restaurarBDToolStripMenuItem});
            this.respaldoToolStripMenuItem.Name = "respaldoToolStripMenuItem";
            this.respaldoToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.respaldoToolStripMenuItem.Text = "Respaldo";
            // 
            // respaldarBDToolStripMenuItem
            // 
            this.respaldarBDToolStripMenuItem.Name = "respaldarBDToolStripMenuItem";
            this.respaldarBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.respaldarBDToolStripMenuItem.Text = "Respaldar BD";
            this.respaldarBDToolStripMenuItem.Click += new System.EventHandler(this.respaldarBDToolStripMenuItem_Click);
            // 
            // restaurarBDToolStripMenuItem
            // 
            this.restaurarBDToolStripMenuItem.Name = "restaurarBDToolStripMenuItem";
            this.restaurarBDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaurarBDToolStripMenuItem.Text = "Restaurar BD";
            this.restaurarBDToolStripMenuItem.Click += new System.EventHandler(this.restaurarBDToolStripMenuItem_Click);
            // 
            // btnDesloguear
            // 
            this.btnDesloguear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesloguear.Location = new System.Drawing.Point(487, 400);
            this.btnDesloguear.Name = "btnDesloguear";
            this.btnDesloguear.Size = new System.Drawing.Size(94, 32);
            this.btnDesloguear.TabIndex = 22;
            this.btnDesloguear.Text = "Desloguear";
            this.btnDesloguear.UseVisualStyleBackColor = true;
            this.btnDesloguear.Click += new System.EventHandler(this.btnDesloguear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSalir.Location = new System.Drawing.Point(21, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 32);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgAdmin
            // 
            this.dtgAdmin.AllowUserToAddRows = false;
            this.dtgAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgAdmin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAdmin.Location = new System.Drawing.Point(21, 61);
            this.dtgAdmin.Name = "dtgAdmin";
            this.dtgAdmin.RowHeadersWidth = 62;
            this.dtgAdmin.Size = new System.Drawing.Size(560, 321);
            this.dtgAdmin.TabIndex = 23;
            // 
            // lblBitacora
            // 
            this.lblBitacora.AutoSize = true;
            this.lblBitacora.BackColor = System.Drawing.Color.Transparent;
            this.lblBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacora.ForeColor = System.Drawing.Color.White;
            this.lblBitacora.Location = new System.Drawing.Point(262, 35);
            this.lblBitacora.Name = "lblBitacora";
            this.lblBitacora.Size = new System.Drawing.Size(71, 18);
            this.lblBitacora.TabIndex = 24;
            this.lblBitacora.Text = "Bitacora";
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(557, 35);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(24, 23);
            this.btnX.TabIndex = 25;
            this.btnX.Text = "x";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click_1);
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(602, 444);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.lblBitacora);
            this.Controls.Add(this.dtgAdmin);
            this.Controls.Add(this.btnDesloguear);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeIngresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeAbonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDePermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaduriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reposiciónStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmClientesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem2;
        private System.Windows.Forms.Button btnDesloguear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoExitosoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDenegadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgAdmin;
        private System.Windows.Forms.Label lblBitacora;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.ToolStripMenuItem rolesYBloqueosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldarBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}