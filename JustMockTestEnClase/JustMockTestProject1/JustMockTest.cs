using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;

namespace JustMockTestProject1
{
  
    [TestClass]
    public class JustMockTest
    {
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ShouldCallOriginalForSpecificArgs()
        {
            // Arrange 
            var foo = Mock.Create<FooBase>();

            Mock.Arrange(() => foo.GetString("x")).CallOriginal();
            Mock.Arrange(() => foo.GetString("y")).Returns("z");

            // Act 
            var actualX = string.Empty;
            var actualY = string.Empty;
            actualX = (string)foo.GetString("x");
            actualY = (string)foo.GetString("y");

            var expectedX = "x";
            var expectedY = "z";

            // Assert 
            Assert.AreEqual(expectedX, actualX);
            Assert.AreEqual(expectedY, actualY);

        }

        //[TestMethod]
        //public void SumaDeDosNumeros()
        //{
        //    int numero1 = 3;
        //    int numero2 = 4;
        //    int esperado = 7;

        //    var Sumatoria = Mock.Create<Calculadora>();

        //    Mock.Arrange(() => Sumatoria.Suma(Arg.IsAny<int>(), numero2)).DoInstead<>;

        //    Assert.AreEqual(esperado,actual);

        //}


        //[TestMethod]
        //public void ShouldTakeOutValueFromDoInsteadWhenDefinedWithCustomDelegate()
        //{
        //    // Arrange 
        //    int refArg = 1;

        //    var mock = Mock.Create<Calculadora>();

        //    Mock.Arrange(() => mock.AddTo(10, ref refArg)).DoInstead(new RefAction<int, int>((int arg1, ref int arg2) =>
        //    {
        //        arg2 += arg1;
        //    }));

        //    // Act 
        //    mock.AddTo(10, ref refArg);

        //    // Assert 
        //    Assert.AreEqual(11, refArg);
        //}

    }
}
