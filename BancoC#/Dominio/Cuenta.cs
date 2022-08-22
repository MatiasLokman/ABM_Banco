using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cuenta
    {
        // Propiedades
        public int Cbu { get; set; }
        public int Saldo { get; set; }
        public TipoCuenta TipoCuenta { get; set; }
        public int UltimoMovimiento { get; set; }

        // Constructor sin parámetros
        public Cuenta()
        {
            Cbu = 0;
            Saldo = 0;
            TipoCuenta = null;
            UltimoMovimiento = 0;
        }

        // Constructor con parámetros
        public Cuenta(int cbu, int saldo, TipoCuenta tipoCuenta, int ultimoMovimiento)
        {
            Cbu = cbu;
            Saldo = saldo;
            TipoCuenta = tipoCuenta;
            UltimoMovimiento = ultimoMovimiento;
        }

        // Método ToString()
        public override string ToString()
        {
            return Cbu + " - " + TipoCuenta;
        }
    }
}
