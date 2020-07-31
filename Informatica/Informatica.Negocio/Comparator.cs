using System;

namespace Informatica.Negocio
{
    public class Comparator
    {
        public int ObtenerMenor(int primerElemento, int segundoElemento)
        {
            //if (primerElemento < seguntoElemento)
            //   return primerElemento;
            // else
            //     return seguntoElemento;

            return primerElemento < segundoElemento ? primerElemento : segundoElemento;
        }
    }
}