//using System.ComponentModel.DataAnnotations;
using PF02_A1;

namespace TestPruebasUnitarias2
{
    [TestClass]
    public sealed class ValidadorTest
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
            [TestMethod]
            public void EsContrasenyaValida_InputEsNull_DebeDevolverFalse()
            {
                Assert.IsFalse(Validador.EsContrasenyaValida(null));
            }

            [TestMethod]
            public void EsContrasenyaValida_InputEstaVacio_DebeDevolverFalse()
            {
                Assert.IsFalse(Validador.EsContrasenyaValida(""));
            }

            [TestMethod]
            public void EsContrasenyaValida_LongitudMenorA8_DebeDevolverFalse()
            {
                Assert.IsFalse(Validador.EsContrasenyaValida("pass#12")); // 7 chars
            }

            [TestMethod]
            public void EsContrasenyaValida_NoContieneHashtag_DebeDevolverFalse()
            {
                Assert.IsFalse(Validador.EsContrasenyaValida("Password12345")); // Larga, sin #
            }

            [TestMethod]
            public void EsContrasenyaValida_ContrasenyaValida_DebeDevolverTrue()
            {
                Assert.IsTrue(Validador.EsContrasenyaValida("MiPasswordValida#1"));
            }
        }
    }
//}
