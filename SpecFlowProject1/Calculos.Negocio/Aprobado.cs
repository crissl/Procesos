using System;

namespace Calculos.Negocio
{
    public class Aprobado
    {
        public Boolean Estado { get; set; }
        public Boolean Rol { get; set; }
        public  Boolean  Estudiante { get; set; }
        public int nota1 { get; set; }
        public int nota2 { get; set; }
        public Boolean aprueba {  get; set; }
        public Boolean noAprueba { get; set; }
        public  Boolean promovido { get; set; }
        public  Boolean Nopromovido { get; set; }


        /*public int Aprobar(string Estado, string Rol, string Estudiante, int nota1, string aprueba, string noAprueba)
        {
            if (Estado == this.Estado)
            {
                if (Rol == this.Rol)
                {
                    if (Estudiante == this.Estudiante)
                    {
                        if (nota1 == this.nota1)
                        {

                             _ = aprueba == this.aprueba;
                        }
                        else
                        {
                            _ = noAprueba == this.noAprueba;
                        }
                    }         
                }
            }
            return nota1;            
        }*/
    }
}
