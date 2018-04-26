using LojaVirtual.Dominio.Entidade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.UnitTest
{
    [TestClass]
    class TesteCarrinho
    {

        //Teste adiciona Itens ao Carrinho
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
            Assert.AreEqual(itens.Length, 3);

        }

    }
}
