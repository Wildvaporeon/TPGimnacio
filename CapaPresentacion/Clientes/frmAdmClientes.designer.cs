namespace CapaPresentacion
{
    partial class frmAdmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmClientes));
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDirección = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblNominaClientes = new System.Windows.Forms.Label();
            this.pnlMantenimiento = new System.Windows.Forms.Panel();
            this.dttAptoFisico = new System.Windows.Forms.DateTimePicker();
            this.lblAptoFisico = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbAbono = new System.Windows.Forms.ComboBox();
            this.lblAbono = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dttFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.pnlMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToOrderColumns = true;
            this.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgClientes.ColumnHeadersHeight = 30;
            this.dtgClientes.EnableHeadersVisualStyles = false;
            this.dtgClientes.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgClientes.Location = new System.Drawing.Point(16, 105);
            this.dtgClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            this.dtgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgClientes.RowHeadersVisible = false;
            this.dtgClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgClientes.Size = new System.Drawing.Size(586, 284);
            this.dtgClientes.TabIndex = 0;
            this.dtgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgClientes_CellClick);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(99, 231);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(172, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(17, 231);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 19);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.White;
            this.lblFechaNac.Location = new System.Drawing.Point(279, 231);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(102, 19);
            this.lblFechaNac.TabIndex = 5;
            this.lblFechaNac.Text = "Fecha de Nac:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(99, 268);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(225, 23);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirección.ForeColor = System.Drawing.Color.White;
            this.lblDirección.Location = new System.Drawing.Point(17, 269);
            this.lblDirección.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(77, 19);
            this.lblDirección.TabIndex = 7;
            this.lblDirección.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(345, 334);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(148, 23);
            this.txtTelefono.TabIndex = 10;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(263, 338);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 19);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Telefono:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightCyan;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(21, 400);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(228, 42);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightCyan;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(16, 397);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(121, 35);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCyan;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(146, 397);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 35);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.ForeColor = System.Drawing.Color.White;
            this.lblDatosCliente.Location = new System.Drawing.Point(17, 138);
            this.lblDatosCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(131, 23);
            this.lblDatosCliente.TabIndex = 14;
            this.lblDatosCliente.Text = "Datos de cliente";
            // 
            // lblNominaClientes
            // 
            this.lblNominaClientes.AutoSize = true;
            this.lblNominaClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblNominaClientes.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNominaClientes.ForeColor = System.Drawing.Color.White;
            this.lblNominaClientes.Location = new System.Drawing.Point(12, 81);
            this.lblNominaClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNominaClientes.Name = "lblNominaClientes";
            this.lblNominaClientes.Size = new System.Drawing.Size(124, 24);
            this.lblNominaClientes.TabIndex = 15;
            this.lblNominaClientes.Text = "Nomina Clientes";
            // 
            // pnlMantenimiento
            // 
            this.pnlMantenimiento.BackColor = System.Drawing.Color.DimGray;
            this.pnlMantenimiento.Controls.Add(this.dttAptoFisico);
            this.pnlMantenimiento.Controls.Add(this.lblAptoFisico);
            this.pnlMantenimiento.Controls.Add(this.btnCancelar);
            this.pnlMantenimiento.Controls.Add(this.lblFoto);
            this.pnlMantenimiento.Controls.Add(this.txtGenero);
            this.pnlMantenimiento.Controls.Add(this.lblGenero);
            this.pnlMantenimiento.Controls.Add(this.cmbAbono);
            this.pnlMantenimiento.Controls.Add(this.lblAbono);
            this.pnlMantenimiento.Controls.Add(this.txtCel);
            this.pnlMantenimiento.Controls.Add(this.lblCelular);
            this.pnlMantenimiento.Controls.Add(this.btnFoto);
            this.pnlMantenimiento.Controls.Add(this.pctFoto);
            this.pnlMantenimiento.Controls.Add(this.lblProvincia);
            this.pnlMantenimiento.Controls.Add(this.txtProvincia);
            this.pnlMantenimiento.Controls.Add(this.btnGuardar);
            this.pnlMantenimiento.Controls.Add(this.txtLocalidad);
            this.pnlMantenimiento.Controls.Add(this.lblLocalidad);
            this.pnlMantenimiento.Controls.Add(this.txtEmail);
            this.pnlMantenimiento.Controls.Add(this.lblEmail);
            this.pnlMantenimiento.Controls.Add(this.dttFechaNac);
            this.pnlMantenimiento.Controls.Add(this.lblDni);
            this.pnlMantenimiento.Controls.Add(this.txtDni);
            this.pnlMantenimiento.Controls.Add(this.lblNombre);
            this.pnlMantenimiento.Controls.Add(this.txtNombre);
            this.pnlMantenimiento.Controls.Add(this.lblDatosCliente);
            this.pnlMantenimiento.Controls.Add(this.lblApellido);
            this.pnlMantenimiento.Controls.Add(this.txtApellido);
            this.pnlMantenimiento.Controls.Add(this.lblFechaNac);
            this.pnlMantenimiento.Controls.Add(this.txtTelefono);
            this.pnlMantenimiento.Controls.Add(this.lblTelefono);
            this.pnlMantenimiento.Controls.Add(this.lblDirección);
            this.pnlMantenimiento.Controls.Add(this.txtDireccion);
            this.pnlMantenimiento.Location = new System.Drawing.Point(630, -3);
            this.pnlMantenimiento.Name = "pnlMantenimiento";
            this.pnlMantenimiento.Size = new System.Drawing.Size(517, 457);
            this.pnlMantenimiento.TabIndex = 16;
            // 
            // dttAptoFisico
            // 
            this.dttAptoFisico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttAptoFisico.Location = new System.Drawing.Point(386, 155);
            this.dttAptoFisico.Name = "dttAptoFisico";
            this.dttAptoFisico.Size = new System.Drawing.Size(105, 23);
            this.dttAptoFisico.TabIndex = 41;
            // 
            // lblAptoFisico
            // 
            this.lblAptoFisico.AutoSize = true;
            this.lblAptoFisico.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAptoFisico.ForeColor = System.Drawing.Color.White;
            this.lblAptoFisico.Location = new System.Drawing.Point(290, 158);
            this.lblAptoFisico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAptoFisico.Name = "lblAptoFisico";
            this.lblAptoFisico.Size = new System.Drawing.Size(89, 19);
            this.lblAptoFisico.TabIndex = 40;
            this.lblAptoFisico.Text = "Apto Fisico:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightCyan;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(268, 400);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(225, 42);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFoto.Location = new System.Drawing.Point(249, 118);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(226, 17);
            this.lblFoto.TabIndex = 37;
            this.lblFoto.Text = "(La imagen debe ser JPG 100x100)";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(403, 265);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(90, 23);
            this.txtGenero.TabIndex = 6;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(332, 269);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(63, 19);
            this.lblGenero.TabIndex = 36;
            this.lblGenero.Text = "Genero:";
            // 
            // cmbAbono
            // 
            this.cmbAbono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbono.FormattingEnabled = true;
            this.cmbAbono.Location = new System.Drawing.Point(383, 367);
            this.cmbAbono.Name = "cmbAbono";
            this.cmbAbono.Size = new System.Drawing.Size(108, 25);
            this.cmbAbono.Sorted = true;
            this.cmbAbono.TabIndex = 12;
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbono.ForeColor = System.Drawing.Color.White;
            this.lblAbono.Location = new System.Drawing.Point(279, 368);
            this.lblAbono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(59, 19);
            this.lblAbono.TabIndex = 34;
            this.lblAbono.Text = "Abono:";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(125, 334);
            this.txtCel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(130, 23);
            this.txtCel.TabIndex = 9;
            // 
            // lblCelular
            // 
            this.lblCelular.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.ForeColor = System.Drawing.Color.White;
            this.lblCelular.Location = new System.Drawing.Point(17, 335);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(61, 19);
            this.lblCelular.TabIndex = 32;
            this.lblCelular.Text = "Celular:";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(171, 112);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 31;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pctFoto
            // 
            this.pctFoto.BackColor = System.Drawing.Color.White;
            this.pctFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctFoto.ErrorImage")));
            this.pctFoto.Image = ((System.Drawing.Image)(resources.GetObject("pctFoto.Image")));
            this.pctFoto.InitialImage = null;
            this.pctFoto.Location = new System.Drawing.Point(21, 15);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(120, 120);
            this.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFoto.TabIndex = 30;
            this.pctFoto.TabStop = false;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.White;
            this.lblProvincia.Location = new System.Drawing.Point(259, 305);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(77, 19);
            this.lblProvincia.TabIndex = 29;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(345, 301);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(148, 23);
            this.txtProvincia.TabIndex = 8;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(99, 301);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(147, 23);
            this.txtLocalidad.TabIndex = 7;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.White;
            this.lblLocalidad.Location = new System.Drawing.Point(17, 304);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(79, 19);
            this.lblLocalidad.TabIndex = 26;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 367);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 23);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(17, 368);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 19);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // dttFechaNac
            // 
            this.dttFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttFechaNac.Location = new System.Drawing.Point(388, 227);
            this.dttFechaNac.Name = "dttFechaNac";
            this.dttFechaNac.Size = new System.Drawing.Size(105, 23);
            this.dttFechaNac.TabIndex = 4;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(321, 192);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 19);
            this.lblDni.TabIndex = 17;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(367, 191);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(124, 23);
            this.txtDni.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(17, 192);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 19);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombres:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 192);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(16, 34);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(144, 23);
            this.txtBuscarId.TabIndex = 17;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCliente.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.ForeColor = System.Drawing.Color.White;
            this.lblIdCliente.Location = new System.Drawing.Point(12, 11);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(67, 21);
            this.lblIdCliente.TabIndex = 19;
            this.lblIdCliente.Text = "ID Cliente";
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarId.Image = global::CapaPresentacion.Properties.Resources.lupaIcono;
            this.btnBuscarId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarId.Location = new System.Drawing.Point(183, 32);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarId.TabIndex = 21;
            this.btnBuscarId.Text = "Buscar";
            this.btnBuscarId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDni.Image = global::CapaPresentacion.Properties.Resources.lupaIcono;
            this.btnBuscarDni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarDni.Location = new System.Drawing.Point(467, 30);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarDni.TabIndex = 24;
            this.btnBuscarDni.Text = "Buscar";
            this.btnBuscarDni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarDni.UseVisualStyleBackColor = true;
            this.btnBuscarDni.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDniCliente.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.ForeColor = System.Drawing.Color.White;
            this.lblDniCliente.Location = new System.Drawing.Point(303, 9);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(76, 21);
            this.lblDniCliente.TabIndex = 23;
            this.lblDniCliente.Text = "DNI Cliente";
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.Location = new System.Drawing.Point(307, 32);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(135, 23);
            this.txtBuscarDni.TabIndex = 22;
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Location = new System.Drawing.Point(143, 81);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarClientes.TabIndex = 25;
            this.btnMostrarClientes.Text = "Mostrar";
            this.btnMostrarClientes.UseVisualStyleBackColor = true;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // frmAdmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1139, 445);
            this.Controls.Add(this.btnMostrarClientes);
            this.Controls.Add(this.btnBuscarDni);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.txtBuscarDni);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.txtBuscarId);
            this.Controls.Add(this.pnlMantenimiento);
            this.Controls.Add(this.lblNominaClientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dtgClientes);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAdmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Clientes";
            this.Load += new System.EventHandler(this.frmAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.pnlMantenimiento.ResumeLayout(false);
            this.pnlMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label lblNominaClientes;
        private System.Windows.Forms.Panel pnlMantenimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dttFechaNac;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbAbono;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dttAptoFisico;
        private System.Windows.Forms.Label lblAptoFisico;
    }
}

