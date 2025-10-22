using System.ComponentModel.DataAnnotations;

namespace TestPruebasUnitarias2
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod]
            public void EsContrasenyaValida_InputEsNull_DebeDevolverFalse()
            {
                Assert.IsFalse(_validador.EsContrasenyaValida(null));
            }

            [TestMethod]
            public void EsContrasenyaValida_InputEstaVacio_DebeDevolverFalse()
            {
                Assert.IsFalse(_validador.EsContrasenyaValida(""));
            }

            [TestMethod]
            public void EsContrasenyaValida_LongitudMenorA8_DebeDevolverFalse()
            {
                Assert.IsFalse(_validador.EsContrasenyaValida("pass#12")); // 7 chars
            }

            [TestMethod]
            public void EsContrasenyaValida_NoContieneHashtag_DebeDevolverFalse()
            {
                Assert.IsFalse(_validador.EsContrasenyaValida("Password12345")); // Larga, sin #
            }

            [TestMethod]
            public void EsContrasenyaValida_ContrasenyaValida_DebeDevolverTrue()
            {
                Assert.IsTrue(_validador.EsContrasenyaValida("MiPasswordValida#1"));
            }
        }
    }
}
