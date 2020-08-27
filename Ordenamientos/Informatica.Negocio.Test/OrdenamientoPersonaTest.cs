using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Informatica.Negocio.Test
{
    [TestClass]
    public class OrdenamientoPersonaTest
    {
        [TestMethod]
        public void OrdenarTresPersonas()
        {
            string nombre = "Christian";
            string apellido = "Lopez";
            var primeraPersona = new Persona(nombre, apellido);

            nombre = "Carlos";
            apellido = "Lara";
            var segundaPersona = new Persona(nombre, apellido);

            nombre = "Camila";
            apellido = "Morales";
            var terceraPersona = new Persona(nombre, apellido);

            var primerApellidoEsperado = "Lara";
            var segundoApellidoEsperado = "Lopez";
            var terceroApellidoEsperado = "Morales";

            Ordenador ordenador = new Ordenador();
            List<Persona> esperados = ordenador.Ordenar(primeraPersona, segundaPersona, terceraPersona);

            Assert.AreEqual(primerApellidoEsperado, esperados[0].Apellido);
            Assert.AreEqual(segundoApellidoEsperado, esperados[1].Apellido);
            Assert.AreEqual(terceroApellidoEsperado, esperados[2].Apellido);
        }        
    }
}
