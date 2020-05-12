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

    public override string ToString()
    {
      return string.Format("R$ {0:0,00}", dinheiro);
    }
  }
}
