using System;
using System.Diagnostics;
using System.Threading;

namespace CarreraHilos
{
    class Program
    {

        public static void Coche1()
        {
            int numeroPasos = 0;
            while (numeroPasos <= 10)
            {
                Random random = new Random();
                Console.WriteLine("||  :[1]:  |       |         |         |         ||");

                numeroPasos += 1;
                Thread.Sleep(1000);//Para que duerma
            }


        }

        public static void Coche2()
        {

            int numeroPasos = 0;
            while (numeroPasos <= 10)
            {
                Random random = new Random();
                Console.WriteLine("||         | :[2]: |         |         |         ||");

                numeroPasos += 1;
                Thread.Sleep(1000);
            }


        }

        public static void Coche3()
        {

            int numeroPasos = 0;
            while (numeroPasos <= 10)
            {
                Random random = new Random();
                
                Console.WriteLine("||         |       |  :[3]:  |         |         ||");

                numeroPasos += 1;
                Thread.Sleep(1000);
            }


        }


        public static void Coche4()
        {

            int numeroPasos = 0;
            while (numeroPasos <= 10)
            {
                Random random = new Random();
                Console.WriteLine("||         |       |         |  :[4]:  |         ||");

                numeroPasos += 1;
                Thread.Sleep(1000);
            }


        }



        public static void Coche5()
        {

            int numeroPasos = 0;
            while (numeroPasos <= 10)
            {
                Random random = new Random();
                Console.WriteLine("||         |       |         |         |  :[5]:  ||");

                numeroPasos += 1;
                Thread.Sleep(1000);
            }




        }
 
        static void Main(string[] args)
        {
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Simulacion de Carrera de Hilos numerados");
            //Ejecucion de hilos como autos
            Thread conductor1 = new Thread(new ThreadStart(Coche1));
            Thread conductor2 = new Thread(new ThreadStart(Coche2));
            Thread conductor3 = new Thread(new ThreadStart(Coche3));
            Thread conductor4 = new Thread(new ThreadStart(Coche4));
            Thread conductor5 = new Thread(new ThreadStart(Coche5));



            conductor1.Start();
            conductor2.Start();
            conductor3.Start();
            conductor4.Start();
            conductor5.Start();

        }
    }
} 
