using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Entity = Domain.Produtos;

namespace App.DTOs.Response
{
  public class Produto
  {
    public Guid Id { get; private set; }
    public Tamanho Tamanho { get; private set; }
    public Fabricacao Fabricacao { get; private set; }
    public Dinheiro Valor { get; private set; }

    public Produto(Entity.Produto entity)
    {
      Id = entity.Id;
      Tamanho = entity.Tamanho;
      Fabricacao = entity.Fabricacao;
      Valor = entity.Valor;
    }
  }
}
