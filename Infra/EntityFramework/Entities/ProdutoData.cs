using Domain.Produtos;
using Domain.Produtos.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EntityFramework.Entities
{
  public class ProdutoData
  {
    public Guid Id { get; private set; }
    public string Tamanho { get; private set; }
    public Fabricacao Fabricacao { get; private set; }
    public decimal Valor { get; private set; }

    protected ProdutoData()
    {

    }

    public ProdutoData(Produto produto)
    {
      Id = produto.Id;
      Tamanho = produto.Tamanho.ToString();
      Fabricacao = produto.Fabricacao;
      Valor = produto.Valor.ToDecimal();
    }    
  }
}
