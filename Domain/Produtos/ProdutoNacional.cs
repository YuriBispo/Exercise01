using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Produtos
{
  public class ProdutoNacional : Produto
  {
    public ProdutoNacional(Guid id, Tamanho tamanho, Fabricacao fabricacao, Dinheiro valor) 
      : base(id, tamanho, fabricacao, valor)
    {
    }

    public override decimal CalcularImposto()
    {
      if (Valor.MaiorQue(new Dinheiro(100)))
        return Valor.ToDecimal() * 0.1M;

      return 0M;
    }
  }
}
