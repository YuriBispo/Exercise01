using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Produtos
{
  public class Produto : IEntity
  {
    public Produto(Guid id, 
      Tamanho tamanho, 
      Fabricacao fabricacao, 
      Dinheiro valor)
    {
      Id = id;
      Fabricacao = fabricacao;
      Tamanho = tamanho ?? throw new ArgumentNullException(nameof(tamanho));
      Valor = valor ?? throw new ArgumentNullException(nameof(valor));
    }

    public Guid Id { get; private set; }
    public Tamanho Tamanho { get; private set; }
    public Fabricacao Fabricacao { get; private set; }
    public Dinheiro Valor { get; private set; }

  }
}
