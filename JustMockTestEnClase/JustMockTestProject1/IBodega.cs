namespace JustMockTestProject1
{
    internal interface IBodega
    {


        void Add(string producto, int cantidad);



         int Inventario(string producto);


        bool HayStock(string producto, int cantidad);



         bool Descargar(string producto, int cantidad);
        
    }
}