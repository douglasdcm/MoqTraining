using Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnit.Moq.Produtos;

namespace XUnitTestProject1
{
    
    public class UnitTestProduto
    {
        [Fact]
        public void ValidaVerificadorPrecoProduto()
        {
            //arrange
            Produto produtoBarato = new Produto()
            {
                Preco = 35
            };

            Mock<IVerificadorPrecoProduto> mock = new Mock<IVerificadorPrecoProduto>();
            mock.Setup(m => m.VerificaPrecoProduto(produtoBarato))
                .Returns("Produto barato!");
            VerificadorPrecoProduto verif = new VerificadorPrecoProduto();

            //act
            var resultadoEsperado = mock.Object.VerificaPrecoProduto(produtoBarato);
            var resultado = verif.VerificaPrecoProduto(produtoBarato);

            //assert
            Assert.Equal(resultadoEsperado, resultado);



        }
    }
}
