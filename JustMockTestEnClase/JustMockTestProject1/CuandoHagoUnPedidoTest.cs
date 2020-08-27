using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Telerik.JustMock;

namespace JustMockTestProject1
{
    [TestClass]
     public class CuandoHagoUnPedidoTest
    {
        [TestMethod]
        public void SiHayInventarioSeDescarga()
        {
            IBodega bodega = new BodegaChevere();
            bodega.Add("Boleto", 20);

            Pedido pedido = new Pedido("Boleto", 20);

            pedido.Llenar(bodega);

            Assert.IsTrue(pedido.EstaLleno);
            Assert.AreEqual(0, bodega.Inventario("Boleto"));
        }


        [TestMethod]
        public void SiHayInventarioSeDescargaMock()
        {
            var bodega = Mock.Create<IBodega>();
           

            Mock.Arrange(() => bodega.HayStock("Boleto",20)).Returns(true);

            Mock.Arrange(() => bodega.Descargar("Boleto", 20)).Returns(true);
 
            Pedido pedido = new Pedido("Boleto", 20);

            pedido.Llenar(bodega);

            Assert.IsTrue(pedido.EstaLleno);
            //To Do Como verifico el mock
            
        }
    }
}
