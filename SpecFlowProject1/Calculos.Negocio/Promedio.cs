using System;

namespace Calculos.Negocio
{
    public class Promedio
    {
        public int PrimerNumero { get; set; }
        public int SengundoNumero { get; set; }

        public int suma() 
        {
            return PrimerNumero / SengundoNumero;
        }

        public int division(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
