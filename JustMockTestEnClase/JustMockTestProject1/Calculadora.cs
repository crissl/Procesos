using System;

namespace JustMockTestProject1
{
    internal class Calculadora
    {
        internal int Suma( int numero1,  int numero2)
        {
            return numero1 + numero2;
        }

        internal object AddTo(int v, ref int refArg)
        {
            throw new NotImplementedException();
        }

        public delegate void RefAction<T1, T2>(T1 arg1, ref T2 arg2);
    }
}