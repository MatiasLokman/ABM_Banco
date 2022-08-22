using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; // Para poder utilizar SQL
using System.Data; // Soporta las data tables


namespace Banco
{
    class DBHelper
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-T54OBOV\SQLEXPRESS;Initial Catalog=db_113870;Integrated Security=True");
        SqlCommand comando = new SqlCommand();

        #region Conectar
        private void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }
        #endregion

        #region Desconectar
        public void desconectar()
        {
            conexion.Close();
        }
        #endregion

        #region Read
        public DataTable consultarDB(string procedimientoAlmacenado)
        {
            conectar();
            comando.CommandText = procedimientoAlmacenado;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader()); // Para ejecutar el Select
            desconectar(); // Desconectamos antes de retornar tabla - trabaja desconectado
            return tabla;
        }
        #endregion

        #region Create - Update - Delete
        public void abmDB(string procedimientoAlmacenado, int dni, string nombre, string apellido, int cbuCliente, int cbuCuenta, int saldo, int tipoCuenta, int ultimoMovimiento)
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = procedimientoAlmacenado;

            if (procedimientoAlmacenado == "AgregarCliente" || procedimientoAlmacenado == "ActualizarCliente")
            {
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                comando.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                comando.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = apellido;
                comando.Parameters.AddWithValue("@cbuCliente", SqlDbType.Int).Value = cbuCliente;
            }
            else if (procedimientoAlmacenado == "AgregarCuenta" || procedimientoAlmacenado == "ActualizarCuenta")
            {
                comando.Parameters.AddWithValue("@cbuCuenta", SqlDbType.Int).Value = cbuCuenta;
                comando.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = saldo;
                comando.Parameters.AddWithValue("@tipoCuenta", SqlDbType.Int).Value = tipoCuenta;
                comando.Parameters.AddWithValue("@ultimoMovimiento", SqlDbType.Money).Value = ultimoMovimiento;
            }
            else if (procedimientoAlmacenado == "EliminarCliente")
            {
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
            }
            else if (procedimientoAlmacenado == "EliminarCuenta")
            {
                comando.Parameters.AddWithValue("@cbuCuenta", SqlDbType.Int).Value = cbuCuenta;
            }
            else
            {
                // error
            }
            comando.ExecuteNonQuery(); // ejecuta la sentencia

            comando.Parameters.Clear();
            desconectar();
        }
        #endregion
    }
}
