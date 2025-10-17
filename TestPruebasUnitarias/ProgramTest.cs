namespace TestPruebasUnitarias
{
    [TestClass]
    public sealed class ProgramTest
    {
        [TestMethod]
        public void esMenorQueCero()
        {
            bool resulto = Program.CalcularFactorial(-1);
            Assert.IsTrue(resulto);
        }
    }
}
