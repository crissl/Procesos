using Calculos.Negocio;
using System;

namespace Financiera.Consola
{
    class Program
    {
        public static string Estado { get; private set; }
        public static object Rol { get; private set; }

        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.PrimerNumero = 50;
            calculadora.SengundoNumero = 70;

            int resultado = calculadora.suma();
            int resultados = calculadora.suma(50, 70);
            Console.WriteLine($"La suma entre {calculadora.PrimerNumero} y {calculadora.SengundoNumero} es: {resultado}");
            Console.WriteLine($"La suma entre 50 y 70 es: {resultados}");

            Aprobado aprobado = new Aprobado();
            aprobado.Estado = true;
            aprobado.Rol = true;
            aprobado.Estudiante = true;
            aprobado.nota1 = 7;
            aprobado.nota2 = 6;
            aprobado.aprueba = true;
            aprobado.noAprueba = false;
            aprobado.Nopromovido = false;



            //int resultado = calculadora.suma();
            //int resultados = calculadora.suma(50, 70);
            Console.WriteLine($"EL docente esta Logeado y tiene el rol Docente y el estudiante es : pAUL, ademas la nota del estudiante es: {aprobado.nota1} por lo tanto el estudiante esta APROBADO");
            /*Console.WriteLine($"La suma entre 50 y 70 es: {resultados}");*/

            
        }
    }
}
