using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Produtos.ValueObjects
{
  public class Dinheiro : IEquatable<Dinheiro>
  {
    private readonly decimal dinheiro;

    public Dinheiro(decimal dinheiro)
    {
      this.dinheiro = dinheiro;
    }

    private Dinheiro(){}

    public bool Equals(Dinheiro other)
    {
      return dinheiro == other.dinheiro;
    }

    public override bool Equals(object obj)
    {
      if(obj is Dinheiro)
      {
        return base.Equals(obj);
      }

      return false;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(dinheiro);
    }

    public decimal ToDecimal()
    {
      return dinheiro;
    }

    public override string ToString()
    {
      return string.Format("R$ {0:0,00}", dinheiro);
    }

    public bool MaiorQue(Dinheiro right)
    {
      return dinheiro > right.dinheiro;
    }

    public bool MenorQue(Dinheiro right)
    {
      return dinheiro < right.dinheiro;
    }

    public bool MaiorOuIgualA(Dinheiro right)
    {
      return dinheiro >= right.dinheiro;
    }

    public bool MenorOuIgualA(Dinheiro right)
    {
      return dinheiro <= right.dinheiro;
    }
  }
}
