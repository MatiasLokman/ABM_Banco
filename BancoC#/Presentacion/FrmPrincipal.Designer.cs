
namespace Banco
{
    partial class FrmPrincipal
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
            this.btnEditarCuenta = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.btnNuevaCuenta = new System.Windows.Forms.Button();
            this.pCrudCuenta = new System.Windows.Forms.Panel();
            this.txtUltimoMovimiento = new System.Windows.Forms.TextBox();
            this.txtCbuCuenta = new System.Windows.Forms.TextBox();
            this.lblCbuClient = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblUltimoMovimiento = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.cboTiposCuenta = new System.Windows.Forms.ComboBox();
            this.pCrudCliente = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblCbucliente = new System.Windows.Forms.Label();
            this.txtCbuCliente = new System.Windows.Forms.TextBox();
            this.lblCrudCuenta = new System.Windows.Forms.Label();
            this.lblCrudCliente = new System.Windows.Forms.Label();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizarCuenta = new System.Windows.Forms.Button();
            this.btnEliminarCuenta = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.dgvClientesyCuentas = new System.Windows.Forms.DataGridView();
            this.lblClientesyCuentas = new System.Windows.Forms.Label();
            this.lblCuentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.pCrudCuenta.SuspendLayout();
            this.pCrudCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesyCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarCuenta
            // 
            this.btnEditarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCuenta.Location = new System.Drawing.Point(911, 483);
            this.btnEditarCuenta.Name = "btnEditarCuenta";
            this.btnEditarCuenta.Size = new System.Drawing.Size(152, 35);
            this.btnEditarCuenta.TabIndex = 114;
            this.btnEditarCuenta.Text = "Editar Cuenta";
            this.btnEditarCuenta.UseVisualStyleBackColor = true;
            this.btnEditarCuenta.Click += new System.EventHandler(this.btnEditarCuenta_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.Location = new System.Drawing.Point(146, 484);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(152, 35);
            this.btnEditarCliente.TabIndex = 113;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCuentas.Location = new System.Drawing.Point(730, 37);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentas.Size = new System.Drawing.Size(673, 199);
            this.dgvCuentas.TabIndex = 112;
            this.dgvCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellClick);
            // 
            // btnNuevaCuenta
            // 
            this.btnNuevaCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCuenta.Location = new System.Drawing.Point(911, 442);
            this.btnNuevaCuenta.Name = "btnNuevaCuenta";
            this.btnNuevaCuenta.Size = new System.Drawing.Size(152, 35);
            this.btnNuevaCuenta.TabIndex = 111;
            this.btnNuevaCuenta.Text = "Nueva Cuenta";
            this.btnNuevaCuenta.UseVisualStyleBackColor = true;
            this.btnNuevaCuenta.Click += new System.EventHandler(this.btnNuevaCuenta_Click);
            // 
            // pCrudCuenta
            // 
            this.pCrudCuenta.BackColor = System.Drawing.SystemColors.WindowText;
            this.pCrudCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCrudCuenta.Controls.Add(this.txtUltimoMovimiento);
            this.pCrudCuenta.Controls.Add(this.txtCbuCuenta);
            this.pCrudCuenta.Controls.Add(this.lblCbuClient);
            this.pCrudCuenta.Controls.Add(this.lblSaldo);
            this.pCrudCuenta.Controls.Add(this.txtSaldo);
            this.pCrudCuenta.Controls.Add(this.lblUltimoMovimiento);
            this.pCrudCuenta.Controls.Add(this.lblTipoCuenta);
            this.pCrudCuenta.Controls.Add(this.cboTiposCuenta);
            this.pCrudCuenta.Location = new System.Drawing.Point(911, 267);
            this.pCrudCuenta.Name = "pCrudCuenta";
            this.pCrudCuenta.Size = new System.Drawing.Size(316, 169);
            this.pCrudCuenta.TabIndex = 110;
            // 
            // txtUltimoMovimiento
            // 
            this.txtUltimoMovimiento.Location = new System.Drawing.Point(130, 124);
            this.txtUltimoMovimiento.Name = "txtUltimoMovimiento";
            this.txtUltimoMovimiento.Size = new System.Drawing.Size(155, 20);
            this.txtUltimoMovimiento.TabIndex = 51;
            // 
            // txtCbuCuenta
            // 
            this.txtCbuCuenta.Location = new System.Drawing.Point(130, 24);
            this.txtCbuCuenta.Name = "txtCbuCuenta";
            this.txtCbuCuenta.Size = new System.Drawing.Size(155, 20);
            this.txtCbuCuenta.TabIndex = 34;
            // 
            // lblCbuClient
            // 
            this.lblCbuClient.AutoSize = true;
            this.lblCbuClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCbuClient.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCbuClient.Location = new System.Drawing.Point(88, 25);
            this.lblCbuClient.Name = "lblCbuClient";
            this.lblCbuClient.Size = new System.Drawing.Size(36, 16);
            this.lblCbuClient.TabIndex = 32;
            this.lblCbuClient.Text = "CBU";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSaldo.Location = new System.Drawing.Point(80, 59);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 16);
            this.lblSaldo.TabIndex = 35;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(130, 57);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(155, 20);
            this.txtSaldo.TabIndex = 36;
            // 
            // lblUltimoMovimiento
            // 
            this.lblUltimoMovimiento.AutoSize = true;
            this.lblUltimoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoMovimiento.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUltimoMovimiento.Location = new System.Drawing.Point(6, 128);
            this.lblUltimoMovimiento.Name = "lblUltimoMovimiento";
            this.lblUltimoMovimiento.Size = new System.Drawing.Size(118, 16);
            this.lblUltimoMovimiento.TabIndex = 47;
            this.lblUltimoMovimiento.Text = "Ultimo movimiento";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCuenta.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTipoCuenta.Location = new System.Drawing.Point(26, 91);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(98, 16);
            this.lblTipoCuenta.TabIndex = 48;
            this.lblTipoCuenta.Text = "Tipo de cuenta";
            // 
            // cboTiposCuenta
            // 
            this.cboTiposCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiposCuenta.FormattingEnabled = true;
            this.cboTiposCuenta.Location = new System.Drawing.Point(130, 90);
            this.cboTiposCuenta.Name = "cboTiposCuenta";
            this.cboTiposCuenta.Size = new System.Drawing.Size(155, 21);
            this.cboTiposCuenta.TabIndex = 50;
            // 
            // pCrudCliente
            // 
            this.pCrudCliente.BackColor = System.Drawing.SystemColors.WindowText;
            this.pCrudCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCrudCliente.Controls.Add(this.txtNombre);
            this.pCrudCliente.Controls.Add(this.lblApellido);
            this.pCrudCliente.Controls.Add(this.lblNombre);
            this.pCrudCliente.Controls.Add(this.lblDni);
            this.pCrudCliente.Controls.Add(this.txtApellido);
            this.pCrudCliente.Controls.Add(this.txtDni);
            this.pCrudCliente.Controls.Add(this.lblCbucliente);
            this.pCrudCliente.Controls.Add(this.txtCbuCliente);
            this.pCrudCliente.Location = new System.Drawing.Point(146, 269);
            this.pCrudCliente.Name = "pCrudCliente";
            this.pCrudCliente.Size = new System.Drawing.Size(316, 169);
            this.pCrudCliente.TabIndex = 109;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 28;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.lblApellido.Location = new System.Drawing.Point(32, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 16);
            this.lblApellido.TabIndex = 25;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombre.Location = new System.Drawing.Point(33, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDni.Location = new System.Drawing.Point(59, 93);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 16);
            this.lblDni.TabIndex = 27;
            this.lblDni.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 57);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 20);
            this.txtApellido.TabIndex = 29;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(110, 92);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(155, 20);
            this.txtDni.TabIndex = 30;
            // 
            // lblCbucliente
            // 
            this.lblCbucliente.AutoSize = true;
            this.lblCbucliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCbucliente.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCbucliente.Location = new System.Drawing.Point(54, 128);
            this.lblCbucliente.Name = "lblCbucliente";
            this.lblCbucliente.Size = new System.Drawing.Size(36, 16);
            this.lblCbucliente.TabIndex = 31;
            this.lblCbucliente.Text = "CBU";
            // 
            // txtCbuCliente
            // 
            this.txtCbuCliente.Location = new System.Drawing.Point(110, 127);
            this.txtCbuCliente.Name = "txtCbuCliente";
            this.txtCbuCliente.Size = new System.Drawing.Size(155, 20);
            this.txtCbuCliente.TabIndex = 33;
            // 
            // lblCrudCuenta
            // 
            this.lblCrudCuenta.AutoSize = true;
            this.lblCrudCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrudCuenta.Location = new System.Drawing.Point(996, 239);
            this.lblCrudCuenta.Name = "lblCrudCuenta";
            this.lblCrudCuenta.Size = new System.Drawing.Size(164, 25);
            this.lblCrudCuenta.TabIndex = 106;
            this.lblCrudCuenta.Text = "CRUD CUENTA";
            // 
            // lblCrudCliente
            // 
            this.lblCrudCliente.AutoSize = true;
            this.lblCrudCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrudCliente.Location = new System.Drawing.Point(235, 239);
            this.lblCrudCliente.Name = "lblCrudCliente";
            this.lblCrudCliente.Size = new System.Drawing.Size(166, 25);
            this.lblCrudCliente.TabIndex = 105;
            this.lblCrudCliente.Text = "CRUD CLIENTE";
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.Location = new System.Drawing.Point(310, 484);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(152, 35);
            this.btnActualizarCliente.TabIndex = 104;
            this.btnActualizarCliente.Text = "Actualizar Cliente";
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(310, 525);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(152, 35);
            this.btnEliminarCliente.TabIndex = 103;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCuenta.Location = new System.Drawing.Point(1075, 442);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(152, 35);
            this.btnAgregarCuenta.TabIndex = 102;
            this.btnAgregarCuenta.Text = "Agregar Cuenta";
            this.btnAgregarCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(146, 444);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(152, 35);
            this.btnNuevoCliente.TabIndex = 101;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(658, 298);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 36);
            this.btnSalir.TabIndex = 100;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(658, 256);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 36);
            this.btnCancelar.TabIndex = 99;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizarCuenta
            // 
            this.btnActualizarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCuenta.Location = new System.Drawing.Point(1075, 483);
            this.btnActualizarCuenta.Name = "btnActualizarCuenta";
            this.btnActualizarCuenta.Size = new System.Drawing.Size(152, 35);
            this.btnActualizarCuenta.TabIndex = 98;
            this.btnActualizarCuenta.Text = "Actualizar Cuenta";
            this.btnActualizarCuenta.UseVisualStyleBackColor = true;
            this.btnActualizarCuenta.Click += new System.EventHandler(this.btnActualizarCuenta_Click);
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCuenta.Location = new System.Drawing.Point(1075, 524);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Size = new System.Drawing.Size(152, 34);
            this.btnEliminarCuenta.TabIndex = 95;
            this.btnEliminarCuenta.Text = "Eliminar Cuenta";
            this.btnEliminarCuenta.UseVisualStyleBackColor = true;
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCuenta_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(310, 444);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(152, 35);
            this.btnAgregarCliente.TabIndex = 94;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dgvClientesyCuentas
            // 
            this.dgvClientesyCuentas.AllowUserToAddRows = false;
            this.dgvClientesyCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesyCuentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientesyCuentas.Location = new System.Drawing.Point(12, 37);
            this.dgvClientesyCuentas.Name = "dgvClientesyCuentas";
            this.dgvClientesyCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesyCuentas.Size = new System.Drawing.Size(673, 199);
            this.dgvClientesyCuentas.TabIndex = 93;
            this.dgvClientesyCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesyCuentas_CellClick);
            // 
            // lblClientesyCuentas
            // 
            this.lblClientesyCuentas.AutoSize = true;
            this.lblClientesyCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesyCuentas.Location = new System.Drawing.Point(12, 9);
            this.lblClientesyCuentas.Name = "lblClientesyCuentas";
            this.lblClientesyCuentas.Size = new System.Drawing.Size(241, 25);
            this.lblClientesyCuentas.TabIndex = 115;
            this.lblClientesyCuentas.Text = "CLIENTES Y CUENTAS";
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.Location = new System.Drawing.Point(725, 9);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(112, 25);
            this.lblCuentas.TabIndex = 116;
            this.lblCuentas.Text = "CUENTAS";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 571);
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.lblClientesyCuentas);
            this.Controls.Add(this.btnEditarCuenta);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.btnNuevaCuenta);
            this.Controls.Add(this.pCrudCuenta);
            this.Controls.Add(this.pCrudCliente);
            this.Controls.Add(this.lblCrudCuenta);
            this.Controls.Add(this.lblCrudCliente);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnAgregarCuenta);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizarCuenta);
            this.Controls.Add(this.btnEliminarCuenta);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.dgvClientesyCuentas);
            this.Name = "FrmPrincipal";
            this.Text = "ABM Banco";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.pCrudCuenta.ResumeLayout(false);
            this.pCrudCuenta.PerformLayout();
            this.pCrudCliente.ResumeLayout(false);
            this.pCrudCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesyCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarCuenta;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Button btnNuevaCuenta;
        private System.Windows.Forms.Panel pCrudCuenta;
        private System.Windows.Forms.TextBox txtCbuCuenta;
        private System.Windows.Forms.Label lblCbuClient;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblUltimoMovimiento;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ComboBox cboTiposCuenta;
        private System.Windows.Forms.Panel pCrudCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblCbucliente;
        private System.Windows.Forms.TextBox txtCbuCliente;
        private System.Windows.Forms.Label lblCrudCuenta;
        private System.Windows.Forms.Label lblCrudCliente;
        private System.Windows.Forms.Button btnActualizarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizarCuenta;
        private System.Windows.Forms.Button btnEliminarCuenta;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.DataGridView dgvClientesyCuentas;
        private System.Windows.Forms.Label lblClientesyCuentas;
        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.TextBox txtUltimoMovimiento;
    }
}

