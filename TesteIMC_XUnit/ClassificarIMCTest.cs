﻿using Calculadora_IMC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC_XUnit
{
    public class ClassificarIMCTest
    {
        [Fact]
        public void ClassificarIMC()
        {
            double imc = 28.34;

            var classIMC = Operacoes.ClassificarIMC(imc);

            Assert.Equal("Sobrepeso", classIMC);
        }

        [Theory]
        [InlineData(28.34, "Sobrepeso")]
        [InlineData(23.67, "Peso Normal")]
        [InlineData(31.58, "Obesidade Grau I")]
        public void ClassificarIMCLista(double imc, string resultadoEsperado)
        {
            var resultadoIMC = Operacoes.ClassificarIMC(imc);

            Assert.Equal(resultadoEsperado, resultadoIMC);
        }
    }
}
