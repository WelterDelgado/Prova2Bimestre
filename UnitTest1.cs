using System;
using Xunit;

namespace Prova2Bimestre
{
    public class UnitTest1
    {
        [Fact]
        public void teste1Prova2BrimestreAlteracao()
        {
            public void Calculadora_Somar_RetornarValorSoma()
            {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(2, 2);
            //Assert
            Assert.Equal(4, resultado);
            }
            [Theory]
            [InlineData(1, 1, 2)]
            [InlineData(3, 2, 5)]
            [InlineData(4, 2, 6)]
        }
    }
}
