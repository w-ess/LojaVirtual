using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaVirtual.Dominio.Entidade;
using System.Linq;

namespace LojaVirtual.UnitTest
{
    [TestClass]
    public class TesteCarrinho_
    {
        [TestMethod]
        public void AdicionarItensAoCarrinho()
        {
            //Arragne - criação dos produtos
            Produto produto1 = new Produto
            {
                ProdutoId = 1,
                Nome = "Teste 1"
            };

            Produto produto2 = new Produto
            {
                ProdutoId = 2,
                Nome = "Teste 2"
            };

            //Arrange
            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarItem(produto1, 2);
            carrinho.AdicionarItem(produto2, 3);

            //Act
            ItemCarrinho[] itens = carrinho.ItensCarrinho.ToArray();

            //Assert
            Assert.AreEqual(itens.Length, 2);

        }
    }
}
