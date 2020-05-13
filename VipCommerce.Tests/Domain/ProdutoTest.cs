using Domain.Produtos;
using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace VipCommerce.Tests.Domain
{
  [TestFixture]
  public class ProdutoTest
  {
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void Deve_Receber_Params_E_Retornar_Produto()
    {
      var id = Guid.NewGuid();
      var tamanho = new Tamanho(122.53M, "KG");
      var fabricacao = Fabricacao.Importado;
      var valor = new Dinheiro(25.95M);

      var result = new Produto(id, tamanho, fabricacao, valor);
      Assert.IsNotNull(result, "Objeto não deve ser nulo");
    }

    [Test]
    public void Deve_Receber_Params_E_Retornar_Nulo()
    {
      var id = Guid.NewGuid();
      var tamanho = new Tamanho(122.53M, "KG");
      var fabricacao = Fabricacao.Importado;
      var valor = new Dinheiro(25.95M);

      var result = new Produto(id, tamanho, fabricacao, valor);
      Assert.IsNull(result, "Objeto deve ser nulo");
    }

    //public void Criar_Produto_Completamente()
    //{
    //  new Produto()
    //}
  }
}
