using System;
using System.Threading;

namespace Hilos.Consola.App
{
    class EjemploHilos
    {
        public static void ProcesoHilo(object id)
        {
            int identificador = (int)id;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hilo secundario{identificador}: Iteración{i}");
                Thread.Sleep(0);
            }


        }
        public static void Main()
        {
            Console.WriteLine("Hilo pricipal : Este hilo inicia un 2do hilo");
            Thread[] hilos = new Thread[1000];
            for (int i = 0; i < 1000; i++)
            {
                hilos[0] = new Thread(ProcesoHilo);


            }
            //Thread t = new Thread(new ThreadStart(ProcesoHilo));
            Console.WriteLine("Cuantos hilos hay?");
            Console.ReadLine();
            for (int i = 0; i < 1000; i++)
            {
                hilos[0].Start();


            }

            Thread.Sleep(0);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hilo Principal: Me estoy ejecutando");
                Thread.Sleep(0);
            }


            for (int i = 0; i < 1000; i++)
            {
                hilos[i]?.Join();
            }
            Console.WriteLine("Hilo principal: Llamo a la funcion de union ( Join() ), para esperar al hilo secundario ");
            Console.WriteLine("El hilo secundario ha regresado. Presione cualquier tecla para continuar");
            Console.ReadLine();



        }
    }
}

