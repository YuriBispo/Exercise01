using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Produtos.ValueObjects
{
  public class CPF : IEquatable<CPF>
  {
    private readonly string cpf;

    public CPF(string cpf)
    {
      this.cpf = cpf;
    }

    private CPF() { }

    public override bool Equals(object obj)
    {
      if (obj is CPF)
      {
        return Equals(obj);
      }

      return false;
    }

    public bool Equals(CPF other)
    {
      return cpf == other.cpf;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(cpf);
    }

    public override string ToString()
    {
      return cpf;
    }

    public bool IsValid()
    {
      return cpf.Replace(".", "").Length == 11;
    }
  }
}
