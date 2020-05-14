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
    private Guid Id;
    private Tamanho Tamanho;
    private Fabricacao Fabricacao;
    private Dinheiro Valor;

    [SetUp]
    protected void SetUp()
    {
      Id = Guid.NewGuid();
      Tamanho = new Tamanho(122.53M, "KG");
      Fabricacao = Fabricacao.Importado;
      Valor = new Dinheiro(100M);
    }

    #region [ Testando exceções no constructor ]    
    
    [Test]
    public void Produto_Internacional_Deve_Receber_Params_Corretos_E_Nao_Retornar_Exception()
    {
      Assert.DoesNotThrow(() =>
      {
        new ProdutoInternacional(Id, Tamanho, Fabricacao, Valor);
      });
    }

    [Test]
    public void Produto_InternacionalDeve_Receber_Params_Incorretos_E_Retornar_Exception()
    {
      Assert.Throws<ArgumentNullException>(() => 
      {
        new ProdutoInternacional(Id, null, Fabricacao, Valor);
      });
    }

    [Test]
    public void Produto_Nacional_Deve_Receber_Params_Corretos_E_Nao_Retornar_Exception()
    {
      Assert.DoesNotThrow(() =>
      {
        new ProdutoNacional(Id, Tamanho, Fabricacao, Valor);
      });
    }

    [Test]
    public void Produto_Nacional_Deve_Receber_Params_Incorretos_E_Retornar_Exception()
    {
      Assert.Throws<ArgumentNullException>(() =>
      {
        new ProdutoNacional(Id, null, Fabricacao, Valor);
      });
    }

    #endregion

    #region [ Testando CalcularImposto ]
    [Test]
    public void Produto_Nacional_Deve_Retonar_Um_Decimal_Maior_Ou_Igual_Zero()
    {
      var produto = new ProdutoNacional(Id, Tamanho, Fabricacao, Valor);
      var result = produto.CalcularImposto();

      Assert.True(result >= 0);
    }

    [Test]
    public void Produto_Internacional_Deve_Retonar_Um_Decimal_Maior_Ou_Igual_Zero()
    {
      var produto = new ProdutoInternacional(Id, Tamanho, Fabricacao, Valor);
      var result = produto.CalcularImposto();

      Assert.True(result >= 0);
    }

    [Test]
    public void Deve_Retonar_10_Porcento_Do_Valor_Se_Nacional_Maior_Que_100()
    {
      var porcentagem = 0.1M; //O mesmo de 10/100;
      var fabricacao = Fabricacao.Nacional;
      var valor = 101M;
      var expected = valor * porcentagem;

      var produto = new ProdutoNacional(Id, Tamanho, fabricacao, new Dinheiro(valor));

      var result = produto.CalcularImposto();
      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Deve_Retonar_0_Se_Nacional_Menor_Ou_Igual_A_100()
    {      
      var fabricacao = Fabricacao.Nacional;
      var valor = 100M;
      var expected = 0;

      var produto = new ProdutoNacional(Id, Tamanho, fabricacao, new Dinheiro(valor));

      var result = produto.CalcularImposto();
      Assert.AreEqual(expected, result);
    }

    [Test]
    public void Deve_Retonar_15_Porcento_Do_Valor_Se_Importado()
    {
      var porcentagem = 0.15M; //O mesmo de 15/100;
      var fabricacao = Fabricacao.Importado;
      var valor = 100M;
      var expected = valor * porcentagem;

      var produto = new ProdutoInternacional(Id, Tamanho, fabricacao, new Dinheiro(valor));
      var result = produto.CalcularImposto();

      Assert.AreEqual(expected, result);
    }

    #endregion
  }
}
