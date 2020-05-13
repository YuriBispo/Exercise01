using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Produtos
{
  public static class ProdutoFactory
  {
    public static Produto CriarProdutoNacional(Guid id,
      Tamanho tamanho,
      Fabricacao fabricacao,
      Dinheiro valor)
    {
      return new ProdutoNacional(id,
            tamanho,
            fabricacao,
            valor);
    }

    public static Produto CriarProdutoInternacional(Guid id,
      Tamanho tamanho,
      Fabricacao fabricacao,
      Dinheiro valor)
    {
      return new ProdutoInternacional(id,
            tamanho,
            fabricacao,
            valor);
    }
  }
}
