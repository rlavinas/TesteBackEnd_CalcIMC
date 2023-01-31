using Calculadora_IMC;

namespace TesteIMC_MSTeste
{
    [TestClass]
    public class CalculoIMCTest
    {
        [TestMethod]
        public void CalcularIMC()
        {
            // Arrange
            double peso = 80;
            double altura = 1.68;

            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            Assert.AreEqual(28.34, resultadoIMC);
        }

        [TestMethod]
        [DataRow(80, 1.68, 28.34)]
        [DataRow(75, 1.78, 23.67)]
        [DataRow(114, 1.90, 31.58)]
        public void CalcularIMCLista(double peso, double altura, double resultadoEsperado)
        {
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            Assert.AreEqual(resultadoEsperado, resultadoIMC);
        }
    }
}