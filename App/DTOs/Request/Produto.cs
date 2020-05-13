using Domain.Produtos;
using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Entity = Domain.Produtos;

namespace App.DTOs.Request
{
  public class Produto
  {
    public Guid Id { get; private set; }
    public Fabricacao Fabricacao { get; private set; }
    public Tamanho Tamanho { get; private set; }
    public Dinheiro Valor { get; private set; }

    public Entity.Produto ConvertToDomain()
    {
      //TODO: Refactor. Reason: This line break OCP;
      //Should be added a IoC container, maybe or some auto
      Entity.Produto produto = Fabricacao == Fabricacao.Nacional
        ? ProdutoFactory.CriarProdutoNacional(Id,
            Tamanho,
            Fabricacao,
            Valor)
        : ProdutoFactory.CriarProdutoInternacional(Id,
            Tamanho,
            Fabricacao,
            Valor);

      return produto;
    }
  }
}
