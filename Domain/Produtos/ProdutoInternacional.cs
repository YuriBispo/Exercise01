using System;
using System.Collections.Generic;
using System.Text;
using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;

namespace Domain.Produtos
{
  public class ProdutoInternacional : Produto
  {
    public ProdutoInternacional(Guid id, Tamanho tamanho, Fabricacao fabricacao, Dinheiro valor) 
      : base(id, tamanho, fabricacao, valor)
    {
    }    

    public override decimal CalcularImposto()
    {
      return Valor.ToDecimal() * 0.15M;
    }
  }
}