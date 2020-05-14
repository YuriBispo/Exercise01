using Domain.Produtos;
using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using Infra.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Entity = Domain.Produtos;

namespace App.DTOs.Request
{
  public class Produto
  {
    public Guid Id { get; set; }
    public Fabricacao Fabricacao { get; set; }
    public string Tamanho { get; set; }
    public decimal Valor { get; set; }

    public ProdutoData ConvertToData()
    {
      var tamanho = Tamanho.Split(' ');
      var novoTamanho = new Tamanho(Convert.ToDecimal(tamanho[0]), tamanho[1]);

      Entity.Produto produto = Fabricacao == Fabricacao.Nacional
        ? ProdutoFactory
          .CriarProdutoNacional(Id, novoTamanho, Fabricacao, new Dinheiro(Valor))
        : ProdutoFactory
          .CriarProdutoInternacional(Id, novoTamanho, Fabricacao, new Dinheiro(Valor));

      return new ProdutoData(produto);
    }
  }
}
