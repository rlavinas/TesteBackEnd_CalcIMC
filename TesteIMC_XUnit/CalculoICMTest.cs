using Calculadora_IMC;

namespace TesteIMC_XUnit
{
    public class CalculoICMTest
    {
        [Fact]
        public void CalcularIMC()
        {
            // Arrange
            double peso = 80;
            double altura = 1.68;

            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            Assert.Equal(28.34, resultadoIMC);
        }

        [Theory]
        [InlineData(80,1.68,28.34)]
        [InlineData(75,1.78,23.67)]
        [InlineData(114,1.90,31.58)]
        public void CalcularIMCLista(double peso, double altura, double resultadoEsperado)
        {
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            Assert.Equal(resultadoEsperado, resultadoIMC);
        }

    }
}