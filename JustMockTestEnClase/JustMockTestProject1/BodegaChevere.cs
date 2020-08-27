using System;

namespace JustMockTestProject1
{
    internal class BodegaChevere : IBodega
    {
        public void Add(string producto, int cantidad)
        {
            throw new NotImplementedException();
        }

        public bool Descargar(string producto, int cantidad)
        {
            throw new NotImplementedException();
        }

        public bool HayStock(string producto, int cantidad)
        {
            throw new NotImplementedException();
        }

        public int Inventario(string producto)
        {
            throw new NotImplementedException();
        }
    }
}