using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cliente
    {
        // Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public Cuenta Cbu { get; set; }

        // Constructor sin parámetros
        public Cliente()
        {
            Nombre = "";
            Apellido = "";
            Dni = 0;
            Cbu = null;
        }

        // Constructor con parámetros
        public Cliente(string nombre, string apellido, int dni, Cuenta cbu)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Cbu = cbu;
        }

        // Método ToString()
        public override string ToString()
        {
            return Apellido + ", " + Nombre + " - " + Dni;
        }
    }
}
