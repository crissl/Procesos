using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace Informatica.Negocio
{
    public class Ordenador
    {

        public List<int> Ordenar(int primero, int segundo, int tercero)
        {
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
            {
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
        }
        public List<Persona> Ordenar(Persona primero, Persona segundo, Persona tercero)
        {
            List<Persona> personas = new List<Persona> { primero, segundo, tercero };
            personas.Sort();
            return personas;
        }
        public List<int> OrdenarBurbujaInt(int cuartoLugar, int segundoLugar, int tercerLugar, int quintoLugar, int primerLugar)
        {
            List<int> resultado = new List<int>();

            int aux;
            for (int i = 0; i < resultado.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (resultado[i] < resultado[j])
                    {
                        aux = resultado[j];
                        resultado[j] = resultado[i];
                        resultado[j] = aux;
                    }
                }
            }
            return resultado;
        }
        public List<double> OrdenarBurbujaDouble(double puntaje5, double puntaje3, double puntaje1, double puntaje2, double puntaje4)
        {
            List<double> resultado = new List<double>();

            double aux;
            for (int i = 0; i < resultado.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (resultado[i] < resultado[j])
                    {
                        aux = resultado[j];
                        resultado[j] = resultado[i];
                        resultado[j] = aux;
                    }
                }
            }
            return resultado;

        }
        public  List<int> OrdenamientoShellInt(int boleto1, int boleto5, int boleto2, int boleto4, int boleto3)
        {
            List<int> resultado = new List<int>();
            if (resultado.Count != 0)
            {
                int incremento = resultado.Count / 2;
                while (incremento != 0)
                {
                    int current = incremento;
                    while (current < resultado.Count)
                    {
                        int hold = resultado[current];
                        int i = current - incremento;

                        while ((i >= 0) && (hold < resultado[i]))
                        {
                            resultado[i + incremento] = resultado[i];
                            i -= incremento;
                        }
                        resultado[i + incremento] = hold;
                        current = current + 1;
                    }
                }
            }
            return resultado;
        }
        public List<double> OrdenamientoShellDouble(double precio1, double precio2, double precio5, double precio4, double precio3)
        {
            List<double> resultado = new List<double>();
            if (resultado.Count != 0)
            {
                int incremento = resultado.Count / 2;
                while (incremento != 0)
                {
                    int current = incremento;

                    while (current < resultado.Count)
                    {
                        double hold = resultado[current];
                        int i = current - incremento;

                        while ((i >= 0) && (hold < resultado[i]))
                        {
                            resultado[i + incremento] = resultado[i];
                            i -= incremento;
                        }
                        resultado[i + incremento] = hold;
                        current = current + 1;
                    }
                }
            }
            return resultado;
        }
        public List<int> OrdenamientoHeapSortInt(int bola2, int bola1, int bola4, int bola5, int bola3, int bola6, int bola8, int bola7)
        {
            List<int> resultado = new List<int>();
            int izq = 2 * bola1 + 1;
            int der = izq + 1;
            int may;
            if (izq > bola8) return resultado;
            if (der > bola8) may = izq;
            else may = resultado[izq] > resultado[der] ? izq : der;
            if (resultado[bola2] < resultado[may])
            {
                int tmp = resultado[bola3];
                resultado[bola4] = resultado[may];
                resultado[may] = tmp;
                OrdenamientoHeapSortInt(bola1, bola2, bola3, bola4, bola5, bola6, bola7, bola8);
            }
            return resultado;
        }
        public List<double> OrdenamientoHeapSortDouble(double peso2, double peso1, double peso4, double peso3)
        {
            List<double> resultado = new List<double>();
            double izq = 2 * peso1 + 1;
            double der = (int)(izq + 1);
            int may;
            if (izq > peso4) return resultado;
            if ((int)der > peso4) may = (int)izq;
            else may = (int)(resultado[(int)izq] > resultado[(int)der] ? izq : der);
            if (resultado[(int)peso2] < resultado[may])
            {
                int tmp = (int)resultado[(int)peso3];
                resultado[(int)peso4] = resultado[may];
                resultado[may] = tmp;
                OrdenamientoHeapSortDouble(peso1, peso2, peso3, peso4);
            }
            return resultado;
        }
        public List<int> OrdenamientoHeapQuickSortInt(int turno1, int turno3, int turno2, int turno4)
        {
            List<int> resultado = new List<int>();
            int i, j, central;
            double pivote;
            central = (turno1 + turno4) / 2;
            pivote = resultado[central];
            i = turno1;
            j = turno4;
            do
            {
                while (resultado[i] < pivote) i++;
                while (resultado[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = resultado[i];
                    resultado[i] = resultado[j];
                    resultado[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (turno1 < j)
            {
                List<int> lists = QuickSortInt(resultado, turno1, j);
            }
            if (i < turno4)
            {
                QuickSortInt(resultado, i, turno4);
            }
            return resultado;
        }
        private List<int> QuickSortInt(List<int> resultado, int turno1, int j)
        {
            throw new NotImplementedException();
        }
        public List<double> OrdenamientoHeapQuickSortDouble(double botella2, double botella1, double botella3, double botella4)
        {
            List<double> resultado = new List<double>();
            double i, j, central;
            double pivote;
            central = (botella1 + botella4) / 2;
            pivote = resultado[(int)central];
            i = botella1;
            j = botella4;
            do
            {
                while ((int)resultado[(int)i] < pivote) i++;
                while ((int)resultado[(int)j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = (int)resultado[(int)i];
                    resultado[(int)i] = resultado[(int)j];
                    resultado[(int)j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (botella1 < j)
            {
                 QuickSortDouble(resultado, botella1, j);
            }
            if (i < botella4)
            {
                QuickSortDouble(resultado, i, botella4);
            }
            return resultado;
        }

        private void QuickSortDouble(List<double> resultado, double i, double botella4)
        {
            throw new NotImplementedException();
        }
    }
}


    

