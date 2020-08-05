using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Informatica.Negocio.Test
{
    [TestClass]
    public class OrdenamientoPersonasTest
    {
        [TestMethod]
        public void TresElementosABC()
        {
            //Triple A => A
            //Arrange-- Act, Organizar
            var tercero = 20;//C

            var primero = 80;//A
            var segundo = 40;//B

            var esperdo1 = 20;//A
            var esperdo2 = 40;//B  C=80

            //Act--Ejecutar
            Ordenador ordenador = new Ordenador();
            List<int> esperados = ordenador.Ordenar(primero, segundo, tercero);

            //Assert--Comprobar
            Assert.AreEqual(esperdo1, esperados[0]);
            Assert.AreEqual(esperdo2, esperados[1]);
        }
        public void OrdenamientoBurbujaInt()
        {
            var primerLugar = 1;
            var segundoLugar = 2;
            var tercerLugar = 3;
            var cuartoLugar = 4;
            var quintoLugar = 5;
            
            var esperado1 = 1;
            var esperado2 = 2;
            var esperado3 = 3;
            var esperado4 = 4;
            var esperado5 = 5;

            Ordenador ordenador = new Ordenador();
            List<int> esperados = ordenador.OrdenarBurbujaInt(cuartoLugar, segundoLugar, tercerLugar, quintoLugar, primerLugar);

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);
            Assert.AreEqual(esperado3, esperados[2]);
            Assert.AreEqual(esperado4, esperados[3]);
            Assert.AreEqual(esperado5, esperados[4]);
        }
        public void OrdenamientoBurbujaDouble()
        {
            var puntaje1 = 1.2;
            var puntaje2 = 2.5;
            var puntaje3 = 3.4;
            var puntaje4 = 4.5;
            var puntaje5 = 5.5;

            var esperado1 = 1.2;
            var esperado2 = 2.5;
            var esperado3 = 3.4;
            var esperado4 = 4.5;
            var esperado5 = 2.5;

            Ordenador ordenador = new Ordenador();
            List<double> esperados = ordenador.OrdenarBurbujaDouble(puntaje5, puntaje3, puntaje1, puntaje2, puntaje4);

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);
            Assert.AreEqual(esperado3, esperados[2]);
            Assert.AreEqual(esperado4, esperados[3]);
            Assert.AreEqual(esperado5, esperados[4]);
        }
        public void OrdenamientoShellInt()
        {
            var boleto1 = 1;
            var boleto2 = 2;
            var boleto3 = 3;
            var boleto4 = 4;
            var boleto5 = 5;

            var esperado1 = 1;
            var esperado2 = 2;
            var esperado3 = 3;
            var esperado4 = 4;
            

            Ordenador ordenador = new Ordenador();
            List<int> esperados = ordenador.OrdenamientoShellInt(boleto1, boleto5, boleto2, boleto4, boleto3);

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);
            Assert.AreEqual(esperado3, esperados[2]);
            Assert.AreEqual(esperado4, esperados[3]);
        }
        public void OrdenamientoShellDouble()
        {
            var precio1 = 350.50;
            var precio2 = 420.50;
            var precio3 = 500.75;
            var precio4 = 600.99;
            var precio5 = 750.90;

            var esperado1 = 350.50;
            var esperado2 = 420.50;
            var esperado3 = 500.75;
            var esperado4 = 600.99;

            Ordenador ordenador = new Ordenador();
            List<double> esperados = ordenador.OrdenamientoShellDouble(precio1, precio2, precio5, precio4, precio3);

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);
            Assert.AreEqual(esperado3, esperados[2]);
            Assert.AreEqual(esperado4, esperados[3]);

        }
        public void OrdenamientoHeapSortInt()
        {
            var bola1 = 1;
            var bola2 = 2;
            var bola3 = 3;
            var bola4 = 4;
            var bola5 = 5;
            var bola6 = 6;
            var bola7 = 7;
            var bola8 = 8;

            var esperado1 = 1;
            var esperado2 = 2;
            var esperado3 = 3;
            var esperado4 = 4;
            var esperado5 = 5;
            var esperado6 = 6;
            var esperado7 = 7;

            Ordenador ordenador = new Ordenador();
            List<int> esperados = ordenador.OrdenamientoHeapSortInt(bola2, bola1, bola4, bola5, bola3, bola6, bola8, bola7);

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);
            Assert.AreEqual(esperado3, esperados[2]);
            Assert.AreEqual(esperado4, esperados[3]);
            Assert.AreEqual(esperado5, esperados[4]);
            Assert.AreEqual(esperado6, esperados[5]);
            Assert.AreEqual(esperado7, esperados[6]);
            


        }
        public void OrdenamientoHeapSortDouble()
        {
            var peso1 = 52.02;
            var peso2 = 60.33;
            var peso3 = 62.00;
            var peso4 = 70.05;

            var esperado1 = 52.02;
            var esperado2 = 60.33;
            var esperado3 = 62.00;

            Ordenador ordenador = new Ordenador();
            List<double> esperados = ordenador.OrdenamientoHeapSortDouble(peso2, peso1, peso4, peso3);

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);
            Assert.AreEqual(esperado3, esperados[2]);




        }
        public void OrdenamientoHeapQuickSortInt()
        {
            var turno1 = 20;
            var turno2 = 25;
            var turno3 = 37;
            var turno4 = 40;

            var esperado1 = 20;
            var esperado2 = 25;
            var esperado3 = 37;

            Ordenador ordenador = new Ordenador();
            List<int> esperados = ordenador.OrdenamientoHeapQuickSortInt(turno1, turno3, turno2, turno4);

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);
            Assert.AreEqual(esperado3, esperados[2]);

        }
        public void OrdenamientoHeapQuickSortDouble()
        {
            var botella1 = 0.50;
            var botella2 = 1.20;
            var botella3 = 2.00;
            var botella4 = 3.20;

            var esperado1 = 0.50;
            var esperado2 = 1.20;
            var esperado3 = 3.20;

            Ordenador ordenador = new Ordenador();
            List<double> esperados = ordenador.OrdenamientoHeapQuickSortDouble(botella2, botella1, botella3, botella4);

            Assert.AreEqual(esperado1, esperados[0]);
            Assert.AreEqual(esperado2, esperados[1]);
            Assert.AreEqual(esperado3, esperados[2]);
        }

    }
}
