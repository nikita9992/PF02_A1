using PF02_A1;

namespace TestPruebasUnitarias
{
    [TestClass]
    public sealed class FactorialTest
    {
        [TestMethod]
        public void esMenorQueCero()
        {
            long resulto = Factorial.CalcularFactorial(-1);
            Assert.AreEqual(-1,resulto);
        }

        [TestMethod]
        public void esMayorQueCero()
        {
            long resulto = Factorial.CalcularFactorial(5);
            Assert.AreEqual(120, resulto);
        }
        [TestMethod]
        public void igualQueCero()
        {
            long resulto = Factorial.CalcularFactorial(0);
            Assert.AreEqual(1, resulto);
        }
    }
}
