namespace CapaPresentacion.Productos
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.nmrIndumentaria = new System.Windows.Forms.NumericUpDown();
            this.cmbIndumentaria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.chcNoCliente = new System.Windows.Forms.CheckBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarFacturacion = new System.Windows.Forms.Button();
            this.dtgVenta = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbComestibles = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.nmrComestible = new System.Windows.Forms.NumericUpDown();
            this.dtpFactura = new System.Windows.Forms.DateTimePicker();
            this.lblClienteSelect = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlVentas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmrIndumentaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrComestible)).BeginInit();
            this.pnlVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar2.Location = new System.Drawing.Point(355, 84);
            this.btnAgregar2.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(75, 24);
            this.btnAgregar2.TabIndex = 66;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // nmrIndumentaria
            // 
            this.nmrIndumentaria.Location = new System.Drawing.Point(284, 86);
            this.nmrIndumentaria.Name = "nmrIndumentaria";
            this.nmrIndumentaria.Size = new System.Drawing.Size(46, 20);
            this.nmrIndumentaria.TabIndex = 65;
            this.nmrIndumentaria.ValueChanged += new System.EventHandler(this.nmrIndumentaria_ValueChanged);
            // 
            // cmbIndumentaria
            // 
            this.cmbIndumentaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIndumentaria.FormattingEnabled = true;
            this.cmbIndumentaria.Location = new System.Drawing.Point(11, 87);
            this.cmbIndumentaria.Name = "cmbIndumentaria";
            this.cmbIndumentaria.Size = new System.Drawing.Size(248, 21);
            this.cmbIndumentaria.TabIndex = 64;
            this.cmbIndumentaria.Leave += new System.EventHandler(this.cmbIndumentaria_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "Indumentaria";
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarId.Image")));
            this.btnBuscarId.Location = new System.Drawing.Point(222, 62);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(28, 23);
            this.btnBuscarId.TabIndex = 62;
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "ID";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(116, 64);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 60;
            // 
            // chcNoCliente
            // 
            this.chcNoCliente.AutoSize = true;
            this.chcNoCliente.BackColor = System.Drawing.Color.Transparent;
            this.chcNoCliente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcNoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcNoCliente.ForeColor = System.Drawing.Color.White;
            this.chcNoCliente.Location = new System.Drawing.Point(32, 116);
            this.chcNoCliente.Name = "chcNoCliente";
            this.chcNoCliente.Size = new System.Drawing.Size(93, 19);
            this.chcNoCliente.TabIndex = 59;
            this.chcNoCliente.Text = "No Cliente";
            this.chcNoCliente.UseVisualStyleBackColor = false;
            this.chcNoCliente.CheckedChanged += new System.EventHandler(this.chcNoCliente_CheckedChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(113, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 15);
            this.lblUser.TabIndex = 58;
            this.lblUser.Text = "Usuario";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.ForeColor = System.Drawing.Color.White;
            this.lblTotal2.Location = new System.Drawing.Point(400, 440);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(15, 16);
            this.lblTotal2.TabIndex = 57;
            this.lblTotal2.Text = "0";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(355, 27);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 24);
            this.btnAgregar.TabIndex = 54;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(322, 440);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 16);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Text = "TOTAL:  $";
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(678, 463);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 23);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardarFacturacion
            // 
            this.btnGuardarFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarFacturacion.Location = new System.Drawing.Point(37, 463);
            this.btnGuardarFacturacion.Name = "btnGuardarFacturacion";
            this.btnGuardarFacturacion.Size = new System.Drawing.Size(90, 23);
            this.btnGuardarFacturacion.TabIndex = 49;
            this.btnGuardarFacturacion.Text = "GUARDAR";
            this.btnGuardarFacturacion.UseVisualStyleBackColor = true;
            this.btnGuardarFacturacion.Click += new System.EventHandler(this.btnGuardarFacturacion_Click);
            // 
            // dtgVenta
            // 
            this.dtgVenta.AllowUserToAddRows = false;
            this.dtgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenta.Location = new System.Drawing.Point(37, 274);
            this.dtgVenta.Name = "dtgVenta";
            this.dtgVenta.Size = new System.Drawing.Size(728, 148);
            this.dtgVenta.TabIndex = 47;
            this.dtgVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVenta_CellDoubleClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(534, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 15);
            this.lblFecha.TabIndex = 46;
            this.lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(8, 11);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(86, 15);
            this.lblProducto.TabIndex = 45;
            this.lblProducto.Text = "Comestibles";
            // 
            // cmbComestibles
            // 
            this.cmbComestibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComestibles.FormattingEnabled = true;
            this.cmbComestibles.Location = new System.Drawing.Point(11, 30);
            this.cmbComestibles.Name = "cmbComestibles";
            this.cmbComestibles.Size = new System.Drawing.Size(248, 21);
            this.cmbComestibles.TabIndex = 44;
            this.cmbComestibles.Leave += new System.EventHandler(this.cmbComestibles_Leave);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(34, 68);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 15);
            this.lblCliente.TabIndex = 43;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.White;
            this.lblVendedor.Location = new System.Drawing.Point(34, 19);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(72, 15);
            this.lblVendedor.TabIndex = 41;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // nmrComestible
            // 
            this.nmrComestible.Location = new System.Drawing.Point(284, 30);
            this.nmrComestible.Name = "nmrComestible";
            this.nmrComestible.Size = new System.Drawing.Size(46, 20);
            this.nmrComestible.TabIndex = 39;
            this.nmrComestible.ValueChanged += new System.EventHandler(this.nmrComestible_ValueChanged);
            // 
            // dtpFactura
            // 
            this.dtpFactura.Location = new System.Drawing.Point(537, 47);
            this.dtpFactura.Name = "dtpFactura";
            this.dtpFactura.Size = new System.Drawing.Size(231, 20);
            this.dtpFactura.TabIndex = 38;
            // 
            // lblClienteSelect
            // 
            this.lblClienteSelect.AutoSize = true;
            this.lblClienteSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblClienteSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteSelect.ForeColor = System.Drawing.Color.White;
            this.lblClienteSelect.Location = new System.Drawing.Point(307, 117);
            this.lblClienteSelect.Name = "lblClienteSelect";
            this.lblClienteSelect.Size = new System.Drawing.Size(134, 16);
            this.lblClienteSelect.TabIndex = 67;
            this.lblClienteSelect.Text = "Cliente comprador";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(649, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlVentas
            // 
            this.pnlVentas.BackColor = System.Drawing.Color.Transparent;
            this.pnlVentas.Controls.Add(this.btnCancelar);
            this.pnlVentas.Controls.Add(this.btnAgregar2);
            this.pnlVentas.Controls.Add(this.nmrIndumentaria);
            this.pnlVentas.Controls.Add(this.cmbIndumentaria);
            this.pnlVentas.Controls.Add(this.label3);
            this.pnlVentas.Controls.Add(this.btnAgregar);
            this.pnlVentas.Controls.Add(this.lblProducto);
            this.pnlVentas.Controls.Add(this.cmbComestibles);
            this.pnlVentas.Controls.Add(this.nmrComestible);
            this.pnlVentas.Location = new System.Drawing.Point(26, 148);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(758, 117);
            this.pnlVentas.TabIndex = 69;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondo_app;
            this.ClientSize = new System.Drawing.Size(798, 500);
            this.Controls.Add(this.pnlVentas);
            this.Controls.Add(this.lblClienteSelect);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.chcNoCliente);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarFacturacion);
            this.Controls.Add(this.dtgVenta);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.dtpFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de productos";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrIndumentaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrComestible)).EndInit();
            this.pnlVentas.ResumeLayout(false);
            this.pnlVentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.NumericUpDown nmrIndumentaria;
        private System.Windows.Forms.ComboBox cmbIndumentaria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.CheckBox chcNoCliente;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarFacturacion;
        private System.Windows.Forms.DataGridView dtgVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbComestibles;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.NumericUpDown nmrComestible;
        private System.Windows.Forms.DateTimePicker dtpFactura;
        private System.Windows.Forms.Label lblClienteSelect;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlVentas;
    }
}