using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class TipoCuenta
    {
        // Propiedades
        public string Nombre { get; set; }

        // Constructor sin parámetros
        public TipoCuenta()
        {
            Nombre = "";
        }

        // Constructor con parámetros
        public TipoCuenta(string nombre)
        {
            Nombre = nombre;
        }

        // Método ToString()
        public override string ToString()
        {
            return Nombre;
        }
    }
}
