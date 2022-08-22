using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FrmPrincipal : Form
    {
        DBHelper oDB = new DBHelper();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cargarCombo("ComboTiposCuenta", cboTiposCuenta, "nombre", "tipoCuenta");
            inicializarForm();
        }

        private void inicializarForm()
        {
            limpiar();
            cargarGrilla("GrillaClientesCuentas", dgvClientesyCuentas);
            cargarGrilla("GrillaCuentas", dgvCuentas);
            habilitarCliente(false);
            habilitarCuenta(false);
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;

            btnNuevoCliente.Enabled = true;
            btnEditarCliente.Enabled = true;

            btnNuevaCuenta.Enabled = true;
            btnEditarCuenta.Enabled = true;

            dgvClientesyCuentas.Enabled = false;
            dgvCuentas.Enabled = false;
            btnSalir.Focus();
        }

        private void habilitarCuenta(bool x)
        {
            txtCbuCuenta.Enabled = x;
            txtSaldo.Enabled = x;
            cboTiposCuenta.Enabled = x;
            txtUltimoMovimiento.Enabled = x;

            btnNuevaCuenta.Enabled = x;
            btnAgregarCuenta.Enabled = x;
            btnEditarCuenta.Enabled = x;
            btnActualizarCuenta.Enabled = x;
            btnEliminarCuenta.Enabled = x;
        }

        private void habilitarCliente(bool x)
        {
            txtNombre.Enabled = x;
            txtApellido.Enabled = x;
            txtDni.Enabled = x;
            txtCbuCliente.Enabled = x;

            btnNuevoCliente.Enabled = x;
            btnAgregarCliente.Enabled = x;
            btnEditarCliente.Enabled = x;
            btnActualizarCliente.Enabled = x;
            btnEliminarCliente.Enabled = x;
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtCbuCliente.Text = "";

            txtCbuCuenta.Text = "";
            txtSaldo.Text = "";
            cboTiposCuenta.SelectedIndex = -1;
            txtUltimoMovimiento.Text = "";
        }

        private void cargarCombo(string nombreComboSP, ComboBox nombreCombo, string displayMember, string valueMember)
        {
            DataTable tabla = oDB.consultarDB(nombreComboSP);
            nombreCombo.DataSource = tabla;
            nombreCombo.DisplayMember = displayMember;
            nombreCombo.ValueMember = valueMember;
        }

        private void cargarGrilla(string nombreGrillaSP, DataGridView nombreDGV)
        {
            DataTable tabla = oDB.consultarDB(nombreGrillaSP);
            nombreDGV.DataSource = tabla;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea abandonar la aplicación?",
               "SALIENDO",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializarForm();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            limpiar();
            txtNombre.Focus();
            habilitarCliente(true);
            habilitarCuenta(false);
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;

            btnNuevoCliente.Enabled = false;
            btnEditarCliente.Enabled = false;
            btnActualizarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
        }

        private void btnNuevaCuenta_Click(object sender, EventArgs e)
        {
            limpiar();
            txtCbuCuenta.Focus();
            habilitarCliente(false);
            habilitarCuenta(true);
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;

            btnNuevaCuenta.Enabled = false;
            btnEditarCuenta.Enabled = false;
            btnActualizarCuenta.Enabled = false;
            btnEliminarCuenta.Enabled = false;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCliente())
            {
                int dni = Convert.ToInt32(txtDni.Text);
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int cbuCliente = Convert.ToInt32(txtCbuCliente.Text);

                if (!existeDniCliente())
                {
                    if (existeCbuCliente())
                    {
                        oDB.abmDB("AgregarCliente", dni, nombre, apellido, cbuCliente, 0, 0, 0, 0);
                        MessageBox.Show("Cliente agregado con éxito!");
                        inicializarForm();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un CBU existente");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un valor no repetido para el DNI");
                    txtDni.Focus();
                }

            }
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {

            if (ValidarDatosCuenta())
            {
                if (!existeCbuCuenta())
                {
                    int cbuCuenta = Convert.ToInt32(txtCbuCuenta.Text);
                    int saldo = Convert.ToInt32(txtSaldo.Text);
                    int tipoCuenta = Convert.ToInt32(cboTiposCuenta.SelectedValue);
                    int ultimoMovimiento = Convert.ToInt32(txtUltimoMovimiento.Text);


                    oDB.abmDB("AgregarCuenta", 0, "", "", 0, cbuCuenta, saldo, tipoCuenta, ultimoMovimiento);
                    MessageBox.Show("Cuenta agregada con éxito!");
                    inicializarForm();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un valor no repetido para el CBU");
                    txtCbuCuenta.Focus();
                }
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe seleccionar un cliente de la grilla para poder editarlo o eliminarlo ...");
            limpiar();
            dgvClientesyCuentas.Enabled = true;
            txtDni.Focus();

            habilitarCliente(true);
            habilitarCuenta(false);
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;

            btnNuevoCliente.Enabled = false;
            btnAgregarCliente.Enabled = false;
            btnActualizarCliente.Enabled = false;
            btnEditarCliente.Enabled = false;
            btnActualizarCliente.Enabled = true;
            btnEliminarCliente.Enabled = true;

            txtDni.Enabled = false;
        }

        private void btnEditarCuenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe seleccionar una cuenta de la grilla para poder editarla o eliminarla ...");
            limpiar();
            dgvCuentas.Enabled = true;
            txtCbuCuenta.Focus();

            habilitarCliente(false);
            habilitarCuenta(true);
            btnCancelar.Enabled = true;
            btnSalir.Enabled = false;

            btnNuevaCuenta.Enabled = false;
            btnAgregarCuenta.Enabled = false;
            btnActualizarCuenta.Enabled = false;
            btnEditarCuenta.Enabled = false;
            btnActualizarCuenta.Enabled = true;
            btnEliminarCuenta.Enabled = true;

            txtCbuCuenta.Enabled = false;
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCliente())
            {
                if (existeCbuCliente())
                {
                    int dni = Convert.ToInt32(txtDni.Text);
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    int cbuCliente = Convert.ToInt32(txtCbuCliente.Text);
                    oDB.abmDB("ActualizarCliente", dni, nombre, apellido, cbuCliente, 0, 0, 0, 0);
                    MessageBox.Show("Cliente actualizado con éxito!");

                    inicializarForm();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un CBU existente");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente de la grilla para poder actualizarlo");
            }
        }

        private void btnActualizarCuenta_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCuenta())
            {
                int cbuCuenta = Convert.ToInt32(txtCbuCuenta.Text);
                int saldo = Convert.ToInt32(txtSaldo.Text);
                int tipoCuenta = Convert.ToInt32(cboTiposCuenta.SelectedValue);
                int ultimoMovimiento = Convert.ToInt32(txtUltimoMovimiento.Text);
                oDB.abmDB("ActualizarCuenta", 0, "", "", 0, cbuCuenta, saldo, tipoCuenta, ultimoMovimiento);
                MessageBox.Show("Cuenta actualizada con éxito!");

                inicializarForm();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cuenta de la grilla para poder actualizarla");
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCliente())
            {
                int dni = Convert.ToInt32(txtDni.Text);

                if (MessageBox.Show("Seguro que desea eliminar este cliente?",
                       "Eliminar cliente",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    oDB.abmDB("EliminarCliente", dni, "", "", 0, 0, 0, 0, 0);
                    MessageBox.Show("Cliente eliminado con éxito!");
                    inicializarForm();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente de la grilla para poder eliminarlo");
            }
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            if (ValidarDatosCuenta())
            {
                int cbuCuenta = Convert.ToInt32(txtCbuCuenta.Text);

                if (!existeCbuDeCuentaEnCliente())
                {
                    if (MessageBox.Show("Seguro que desea eliminar esta cuenta?",
                           "Eliminar cuenta",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        oDB.abmDB("EliminarCuenta", 0, "", "", 0, cbuCuenta, 0, 0, 0);
                        MessageBox.Show("Cuenta eliminada con éxito!");
                        inicializarForm();
                    }
                }
                else
                {
                    MessageBox.Show("No puede eliminar esta cuenta ya que le pertenece a un cliente, debera borrar primero al cliente para poder eliminarla");
                }
            } else
            {
                MessageBox.Show("Debe seleccionar una cuenta de la grilla para poder eliminarla");
            }
        }

        private void dgvClientesyCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientesyCuentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtNombre.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtApellido.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtDni.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtCbuCliente.Text = dgvClientesyCuentas.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
        }

        private void dgvCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtCbuCuenta.Text = dgvCuentas.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtSaldo.Text = dgvCuentas.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cboTiposCuenta.Text = dgvCuentas.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtUltimoMovimiento.Text = dgvCuentas.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
        }

        private bool ValidarDatosCuenta()
        {
            bool valido = true;
            if (txtCbuCuenta.Text == "")
            {
                MessageBox.Show("Debe ingresar un CBU ...");
                txtCbuCuenta.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCbuCuenta.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numérico para el CBU");
                    txtCbuCuenta.Focus();
                    return false;
                }
            }
            if (txtSaldo.Text == "")
            {
                MessageBox.Show("Debe ingresar un saldo ...");
                txtSaldo.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtSaldo.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numérico para el saldo");
                    txtSaldo.Focus();
                    return false;
                }
            }
            if (cboTiposCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de cuenta ...");
                cboTiposCuenta.Focus();
                valido = false;
            }
            if (txtUltimoMovimiento.Text == "")
            {
                MessageBox.Show("Debe ingresar un ultimo movimiento ...");
                txtUltimoMovimiento.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtUltimoMovimiento.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numérico para el ultimo movimiento");
                    txtUltimoMovimiento.Focus();
                    return false;
                }
            }
            return valido;
        }

        private bool ValidarDatosCliente()
        {
            bool valido = true;
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre ...");
                txtNombre.Focus();
                valido = false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido ...");
                txtApellido.Focus();
                valido = false;
            }
            if (txtDni.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI ...");
                txtDni.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDni.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numérico para el DNI");
                    txtDni.Focus();
                    return false;
                }
            }
            if (txtCbuCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un CBU ...");
                txtCbuCliente.Focus();
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCbuCliente.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numérico para el CBU");
                    txtCbuCliente.Focus();
                    return false;
                }
            }
            return valido;
        }

        private bool existeDniCliente()
        {
            for (int i = 0; i < dgvClientesyCuentas.Rows.Count; i++)
            {
                if (txtDni.Text == dgvClientesyCuentas.Rows[i].Cells[0].Value.ToString())
                    return true;
            }
            return false;
        }

        private bool existeCbuCliente()
        {
            for (int i = 0; i < dgvCuentas.Rows.Count; i++)
            {
                if (txtCbuCliente.Text == dgvCuentas.Rows[i].Cells[0].Value.ToString())
                    return true;
            }
            return false;
        }

        private bool existeCbuCuenta()
        {
            for (int i = 0; i < dgvCuentas.Rows.Count; i++)
            {
                if (txtCbuCuenta.Text == dgvCuentas.Rows[i].Cells[0].Value.ToString())
                    return true;
            }
            return false;
        }

        private bool existeCbuDeCuentaEnCliente()
        {
            for (int i = 0; i < dgvClientesyCuentas.Rows.Count; i++)
            {
                if (txtCbuCuenta.Text == dgvClientesyCuentas.Rows[i].Cells[3].Value.ToString())
                    return true;
            }
            return false;
        }
    }
}