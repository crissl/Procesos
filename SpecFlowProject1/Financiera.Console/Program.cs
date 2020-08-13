using Calculos.Negocio;
using System;

namespace Financiera.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.PrimerNumero = 50;
            calculadora.SengundoNumero = 70;
            calculadora.suma();

            int resultado = calculadora.suma();

            Console.WriteLine($"La suma de {calculadora.PrimerNumero} y de {calculadora.SengundoNumero} es:{resultado}");
        }
    }
}
