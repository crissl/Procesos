using System;

namespace Calculos.Negocio
{
    public class Calculadora
    {
        public int PrimerNumero { get; set; }
        public int SengundoNumero { get; set; }

        public int suma() 
        {
            return PrimerNumero + SengundoNumero;
        }

        public int suma(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
