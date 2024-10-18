using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nova_pasta.Models;
using Xunit;

namespace Tests
{
    public class CalculadoraTestes
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void SomarInteirosTestes(int num1, int num2, int resul)
        {
            Calculadora calc = new();

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(resul, resultado);
        }

        [Theory]
        [InlineData(1, 3, 2)]
        [InlineData(4, 5, 1)]
        public void SubtrairInteirosTestes(int num1, int num2, int resul)
        {
            Calculadora calc = new();

            int resultado = calc.Subtrair(num1, num2);

            Assert.Equal(resul, resultado);
        }

        [Theory]
        [InlineData(1, 3, 3)]
        [InlineData(4, 5, 20)]
        public void MultiplicarInteirosTestes(int num1, int num2, int resul)
        {
            Calculadora calc = new();

            int resultado = calc.Multiplicar(num1, num2);

            Assert.Equal(resul, resultado);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 2, 5)]
        public void DividirInteirosTestes(int num1, int num2, int resul)
        {
            Calculadora calc = new();

            int resultado = calc.Dividir(num1, num2);

            Assert.Equal(resul, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new();

            Assert.Throws<Exception>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new();

            calc.Somar(1, 5);
            calc.Somar(9, 5);
            calc.Somar(7, 2);
            calc.Somar(3, 2);

            var listaHistorico = calc.Historico();

            Assert.NotEmpty(listaHistorico);
            Assert.Equal(3, listaHistorico.Count);
        }
    }
}