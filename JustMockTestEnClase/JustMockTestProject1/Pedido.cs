using System;

namespace JustMockTestProject1
{
    internal class Pedido
    {
        private string producto;
        private int cantidad;

        public Pedido(string producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }

        public bool EstaLleno { get; internal set; }

        internal void Llenar(IBodega bodega)
        {
           if( bodega.HayStock(producto, cantidad))
            {
                bodega.Descargar(producto, cantidad);
                EstaLleno = true;
            }
        }
    }
}