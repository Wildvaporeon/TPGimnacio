namespace CapaPresentacion.Usuarios
{
    partial class frmAdmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmUsuarios));
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.btnEliminarUs = new System.Windows.Forms.Button();
            this.btnMostrarUs = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtBuscarCuil = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.btnBuscarCuil = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardaCambios = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpPersonas = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnMostrarEmpleados = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.dttFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.Navy;
            this.grpLogin.Controls.Add(this.lblRol);
            this.grpLogin.Controls.Add(this.cmbRol);
            this.grpLogin.Controls.Add(this.lblIdEmpleado);
            this.grpLogin.Controls.Add(this.btnAceptar);
            this.grpLogin.Controls.Add(this.label18);
            this.grpLogin.Controls.Add(this.label17);
            this.grpLogin.Controls.Add(this.label16);
            this.grpLogin.Controls.Add(this.txtPassConfirm);
            this.grpLogin.Controls.Add(this.txtPass);
            this.grpLogin.Controls.Add(this.txtUsuario);
            this.grpLogin.Enabled = false;
            this.grpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.Color.White;
            this.grpLogin.Location = new System.Drawing.Point(759, 5);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(375, 266);
            this.grpLogin.TabIndex = 7;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Datos Logueo";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Location = new System.Drawing.Point(7, 203);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(94, 16);
            this.lblRol.TabIndex = 47;
            this.lblRol.Text = "Rol de usuario";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(10, 222);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 24);
            this.cmbRol.TabIndex = 46;
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.Location = new System.Drawing.Point(207, 18);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(30, 16);
            this.lblIdEmpleado.TabIndex = 45;
            this.lblIdEmpleado.Text = "ID: ";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(193, 221);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(160, 25);
            this.btnAceptar.TabIndex = 44;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(7, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 16);
            this.label18.TabIndex = 6;
            this.label18.Text = "Repetir contraseña";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(6, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "Contraseña";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(6, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nombre de usuario";
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(9, 165);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.PasswordChar = '*';
            this.txtPassConfirm.Size = new System.Drawing.Size(186, 22);
            this.txtPassConfirm.TabIndex = 16;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(9, 117);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(186, 22);
            this.txtPass.TabIndex = 15;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(9, 73);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(186, 22);
            this.txtUsuario.TabIndex = 14;
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.AllowUserToAddRows = false;
            this.dtgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(133, 277);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.RowHeadersWidth = 62;
            this.dtgEmpleados.Size = new System.Drawing.Size(620, 162);
            this.dtgEmpleados.TabIndex = 8;
            this.dtgEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleados_CellClick);
            // 
            // btnEliminarUs
            // 
            this.btnEliminarUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUs.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarUs.Location = new System.Drawing.Point(223, 102);
            this.btnEliminarUs.Name = "btnEliminarUs";
            this.btnEliminarUs.Size = new System.Drawing.Size(130, 29);
            this.btnEliminarUs.TabIndex = 46;
            this.btnEliminarUs.Text = "Eliminar Usuario";
            this.btnEliminarUs.UseVisualStyleBackColor = true;
            this.btnEliminarUs.Click += new System.EventHandler(this.btnEliminarUs_Click);
            // 
            // btnMostrarUs
            // 
            this.btnMostrarUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarUs.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarUs.Location = new System.Drawing.Point(34, 67);
            this.btnMostrarUs.Name = "btnMostrarUs";
            this.btnMostrarUs.Size = new System.Drawing.Size(130, 29);
            this.btnMostrarUs.TabIndex = 45;
            this.btnMostrarUs.Text = "Mostrar Usuarios";
            this.btnMostrarUs.UseVisualStyleBackColor = true;
            this.btnMostrarUs.Click += new System.EventHandler(this.btnMostrarUs_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnModificarUsuario.Location = new System.Drawing.Point(223, 36);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(130, 45);
            this.btnModificarUsuario.TabIndex = 44;
            this.btnModificarUsuario.Text = "Cambiar Contraseña";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.btnEliminarUs);
            this.groupBox1.Controls.Add(this.btnMostrarUs);
            this.groupBox1.Controls.Add(this.btnModificarUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(759, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 162);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnBuscarId);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtBuscarCuil);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtBuscarId);
            this.panel1.Controls.Add(this.btnBuscarCuil);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.lblBuscar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardaCambios);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 445);
            this.panel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(11, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 40);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarId.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarId.Image = global::CapaPresentacion.Properties.Resources.lupaIcono;
            this.btnBuscarId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarId.Location = new System.Drawing.Point(28, 246);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarId.TabIndex = 46;
            this.btnBuscarId.Text = "Buscar";
            this.btnBuscarId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Cuil Empleado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(10, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 43);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtBuscarCuil
            // 
            this.txtBuscarCuil.Location = new System.Drawing.Point(11, 322);
            this.txtBuscarCuil.Name = "txtBuscarCuil";
            this.txtBuscarCuil.Size = new System.Drawing.Size(106, 20);
            this.txtBuscarCuil.TabIndex = 44;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(11, 99);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(11, 220);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(106, 20);
            this.txtBuscarId.TabIndex = 41;
            // 
            // btnBuscarCuil
            // 
            this.btnBuscarCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCuil.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarCuil.Image = global::CapaPresentacion.Properties.Resources.lupaIcono;
            this.btnBuscarCuil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCuil.Location = new System.Drawing.Point(28, 348);
            this.btnBuscarCuil.Name = "btnBuscarCuil";
            this.btnBuscarCuil.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarCuil.TabIndex = 43;
            this.btnBuscarCuil.Text = "Buscar";
            this.btnBuscarCuil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCuil.UseVisualStyleBackColor = true;
            this.btnBuscarCuil.Click += new System.EventHandler(this.btnBuscarCuil_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(11, 67);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(24, 196);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(79, 15);
            this.lblBuscar.TabIndex = 42;
            this.lblBuscar.Text = "ID Empleado";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 21);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.Location = new System.Drawing.Point(10, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardaCambios
            // 
            this.btnGuardaCambios.Location = new System.Drawing.Point(11, 67);
            this.btnGuardaCambios.Name = "btnGuardaCambios";
            this.btnGuardaCambios.Size = new System.Drawing.Size(106, 23);
            this.btnGuardaCambios.TabIndex = 4;
            this.btnGuardaCambios.Text = "Guardar Cambios";
            this.btnGuardaCambios.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(11, 98);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // grpPersonas
            // 
            this.grpPersonas.BackColor = System.Drawing.Color.White;
            this.grpPersonas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpPersonas.BackgroundImage")));
            this.grpPersonas.Controls.Add(this.label21);
            this.grpPersonas.Controls.Add(this.label20);
            this.grpPersonas.Controls.Add(this.label19);
            this.grpPersonas.Controls.Add(this.label15);
            this.grpPersonas.Controls.Add(this.label14);
            this.grpPersonas.Controls.Add(this.btnMostrarEmpleados);
            this.grpPersonas.Controls.Add(this.label13);
            this.grpPersonas.Controls.Add(this.txtSector);
            this.grpPersonas.Controls.Add(this.label9);
            this.grpPersonas.Controls.Add(this.btnCrearUsuario);
            this.grpPersonas.Controls.Add(this.dttFechaNac);
            this.grpPersonas.Controls.Add(this.txtGenero);
            this.grpPersonas.Controls.Add(this.label8);
            this.grpPersonas.Controls.Add(this.label3);
            this.grpPersonas.Controls.Add(this.txtCel);
            this.grpPersonas.Controls.Add(this.txtProvincia);
            this.grpPersonas.Controls.Add(this.txtLocalidad);
            this.grpPersonas.Controls.Add(this.label12);
            this.grpPersonas.Controls.Add(this.label11);
            this.grpPersonas.Controls.Add(this.label7);
            this.grpPersonas.Controls.Add(this.txtDireccion);
            this.grpPersonas.Controls.Add(this.label6);
            this.grpPersonas.Controls.Add(this.txtEmail);
            this.grpPersonas.Controls.Add(this.label5);
            this.grpPersonas.Controls.Add(this.txtTelefono);
            this.grpPersonas.Controls.Add(this.label4);
            this.grpPersonas.Controls.Add(this.txtCuil);
            this.grpPersonas.Controls.Add(this.label2);
            this.grpPersonas.Controls.Add(this.txtNombres);
            this.grpPersonas.Controls.Add(this.label1);
            this.grpPersonas.Controls.Add(this.txtApellido);
            this.grpPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonas.ForeColor = System.Drawing.Color.White;
            this.grpPersonas.Location = new System.Drawing.Point(133, 5);
            this.grpPersonas.Name = "grpPersonas";
            this.grpPersonas.Size = new System.Drawing.Size(620, 266);
            this.grpPersonas.TabIndex = 5;
            this.grpPersonas.TabStop = false;
            this.grpPersonas.Text = "Datos de Empleado";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(56, 115);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 18);
            this.label21.TabIndex = 49;
            this.label21.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(52, 148);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 18);
            this.label20.TabIndex = 48;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(322, 41);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 18);
            this.label19.TabIndex = 47;
            this.label19.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(52, 41);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 18);
            this.label15.TabIndex = 46;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(32, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 18);
            this.label14.TabIndex = 45;
            this.label14.Text = "*";
            // 
            // btnMostrarEmpleados
            // 
            this.btnMostrarEmpleados.ForeColor = System.Drawing.Color.Black;
            this.btnMostrarEmpleados.Location = new System.Drawing.Point(271, 223);
            this.btnMostrarEmpleados.Name = "btnMostrarEmpleados";
            this.btnMostrarEmpleados.Size = new System.Drawing.Size(174, 29);
            this.btnMostrarEmpleados.TabIndex = 44;
            this.btnMostrarEmpleados.Text = "Mostrar Empleados";
            this.btnMostrarEmpleados.UseVisualStyleBackColor = true;
            this.btnMostrarEmpleados.Click += new System.EventHandler(this.btnMostrarEmpleados_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 42;
            this.label13.Text = "Sector";
            // 
            // txtSector
            // 
            this.txtSector.Location = new System.Drawing.Point(75, 222);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(179, 22);
            this.txtSector.TabIndex = 12;
            this.txtSector.Leave += new System.EventHandler(this.txtSector_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(418, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "Fecha Nac.";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnCrearUsuario.Location = new System.Drawing.Point(477, 223);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(130, 29);
            this.btnCrearUsuario.TabIndex = 43;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // dttFechaNac
            // 
            this.dttFechaNac.CustomFormat = "--/--/----";
            this.dttFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttFechaNac.Location = new System.Drawing.Point(493, 72);
            this.dttFechaNac.Name = "dttFechaNac";
            this.dttFechaNac.Size = new System.Drawing.Size(114, 22);
            this.dttFechaNac.TabIndex = 5;
            this.dttFechaNac.Value = new System.DateTime(2022, 10, 4, 0, 0, 0, 0);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(341, 72);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(71, 22);
            this.txtGenero.TabIndex = 4;
            this.txtGenero.Leave += new System.EventHandler(this.txtGenero_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Celular";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(75, 146);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(179, 22);
            this.txtCel.TabIndex = 8;
            this.txtCel.Leave += new System.EventHandler(this.txtCel_Leave_1);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(341, 181);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(266, 22);
            this.txtProvincia.TabIndex = 11;
            this.txtProvincia.Leave += new System.EventHandler(this.txtProvincia_Leave);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(341, 145);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(266, 22);
            this.txtLocalidad.TabIndex = 9;
            this.txtLocalidad.Leave += new System.EventHandler(this.txtLocalidad_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(266, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Provincia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(266, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Localidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(341, 109);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(266, 22);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 22);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(75, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(179, 22);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuil";
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(75, 74);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(179, 22);
            this.txtCuil.TabIndex = 3;
            this.txtCuil.Leave += new System.EventHandler(this.txtCuil_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(341, 35);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(266, 22);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.Leave += new System.EventHandler(this.txtNombres_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(75, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(179, 22);
            this.txtApellido.TabIndex = 0;
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // frmAdmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Usuarios";
            this.Load += new System.EventHandler(this.frmAdmUsuarios_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpPersonas.ResumeLayout(false);
            this.grpPersonas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardaCambios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpPersonas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dttFechaNac;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBuscarCuil;
        private System.Windows.Forms.Button btnBuscarCuil;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnMostrarEmpleados;
        private System.Windows.Forms.Button btnEliminarUs;
        private System.Windows.Forms.Button btnMostrarUs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}