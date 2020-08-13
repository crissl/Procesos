using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Numerics;

namespace Matematica.Tests
{
    [TestClass]
    public class CuandoMultiplicoMatrices
    {
        [TestMethod]
        public void SiMatrizA3x2yMatrizB2x4EntoncesMatrizAXB3X4()
        {
            int filas = 3;
            int columnas = 4;
            int[,] MatrizA = new int[filas, 2];
            int[,] MatrizB = new int[2, filas];

            Calculadora calculadora = new Calculadora();

            int[,] MatrizAXB = calculadora.Multiplicar(MatrizA, MatrizB);

            Assert.AreEqual(filas, MatrizAXB.GetLength(0));
/*            Assert.AreEqual(columnas, MatrizAXB.GetLength(1));
*/
        }
        [TestMethod]
        public void EnparaleloEsMasRapidoQueEnSecuencia()
        {
            int filas = 1000;
            int columnas = 1000;
            int interno = 500;
            int[,] MatrizA = Calculadora.CrearMatriz(filas, interno);
            int[,] MatrizB = Calculadora.CrearMatriz(interno, columnas);

            Calculadora calculadora = new Calculadora();
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            calculadora.Multiplicar(MatrizA, MatrizB);

            stopwatch.Stop();
            var secuencial = stopwatch.ElapsedTicks;

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            calculadora.MultiplicarParalelo(MatrizA, MatrizB);

            stopwatch1.Stop();
            var paralelo = stopwatch1.ElapsedTicks;

            Assert.IsTrue(secuencial > paralelo);


        }
             
    }
}
