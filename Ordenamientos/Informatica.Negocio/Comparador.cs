using System;

namespace Informatica.Negocio.Test
{
    public class Comparador
    {
        public int ObtenerMenor(int primerElemento, int segundoElemento)
        {
            /*          if (primerElemento < segundoElemento)
                          return primerElemento;
                      else
                          return segundoElemento;*/

            return primerElemento < segundoElemento ? primerElemento : segundoElemento;
        }
    }
}