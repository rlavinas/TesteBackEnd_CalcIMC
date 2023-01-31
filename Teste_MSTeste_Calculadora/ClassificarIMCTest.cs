using Calculadora_IMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC_MSTeste
{
    [TestClass]
    public class ClassificarIMCTest
    {
        [TestMethod]
        public void ClassificarIMC()
        {
            double imc = 28.34;

            var classIMC = Operacoes.ClassificarIMC(imc);

            Assert.AreEqual("Sobrepeso", classIMC);
        }

        [TestMethod]
        [DataRow(28.34, "Sobrepeso")]
        [DataRow(23.67, "Peso Normal")]
        [DataRow(31.58, "Obesidade Grau I")]
        public void CalcularIMCLista(double imc, string imcEsperado)
        {
            var imcCalculado = Operacoes.ClassificarIMC(imc);

            Assert.AreEqual(imcEsperado, imcCalculado);
        }
    }
}
