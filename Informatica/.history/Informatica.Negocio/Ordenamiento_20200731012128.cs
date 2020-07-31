using System.Collections.Generic;

namespace Informatica.Negocio.Test
{
    public class Ordenamiento
    {
        public static List<int> Ordenar(int primero, int segundo, int tercero)
        {
            //return new List<int> { tercero, segundo,  primero };
                        var resultado = new List<int>();

            if (primero <= segundo)
            {
                if (primero <= tercero)
                {
                    resultado.Add(primero);
                    if (segundo <= tercero)
                    {
                        resultado.Add(segundo);
                        resultado.Add(tercero);
                    }
                    else
                    {
                        resultado.Add(tercero);
                        resultado.Add(segundo);
                    }

                }
                else
                {
                    resultado.Add(tercero);
                    if (segundo <= primero)
                    {
                        resultado.Add(segundo);
                        resultado.Add(primero);
                    }
                    else
                    {
                        resultado.Add(primero);
                        resultado.Add(segundo);
                    }
                }

            }
            else
            }
                if (segundo <= tercero)
            {
                resultado.Add(segundo);
                if (primero <= tercero)
                {
                    resultado.Add(primero);
                    resultado.Add(tercero);
                }
                else
                {
                    resultado.Add(tercero);
                    resultado.Add(primero);
                }
            }
            else
            {
                resultado.Add(tercero);
                if (primero <= segundo)
                {
                    resultado.Add(primero);
                    resultado.Add(segundo);
                }
                else
                {
                    resultado.Add(segundo);
                    resultado.Add(primero);
                }
            }
            } 
            
            return resultado;
            /*            return primero <= segundo ? primero <= tercero ? resultado.Add(primero) : segundo <= tercero : resultado.Add(segundo):, resultado.Add(tercero): tercero, segundo : tercero ? segundo <= primero : segundo, primero : primero, segundo ? segundo <= tercero
            */
        }

    }
    
 }

