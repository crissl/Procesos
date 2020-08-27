using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Informatica.Negocio
{
    public class Persona : IComparable<Persona>
    {
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CompareTo([AllowNull] Persona other)
        {
            return Apellido.CompareTo(other.Apellido);

        }
    }
}
