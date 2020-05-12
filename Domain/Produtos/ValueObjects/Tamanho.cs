using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Produtos.ValueObjects
{
  public class Tamanho: IEquatable<Tamanho>
  {
    private readonly decimal tamanho;
    private readonly string unidadeDeMedida;

    public Tamanho(decimal tamanho, string unidadeDeMedida)
    {
      this.tamanho = tamanho;
      this.unidadeDeMedida = unidadeDeMedida ?? throw new ArgumentNullException(nameof(unidadeDeMedida));
    }

    private Tamanho() { }

    public override bool Equals(object obj)
    {
      if(obj is Tamanho)
      {
        return Equals(obj);
      }

      return false;
    }

    public bool Equals(Tamanho other)
    {
      return tamanho == other.tamanho;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(tamanho, unidadeDeMedida);
    }

    public override string ToString()
    {
      return string.Format("{0:0,00} {1}", tamanho, unidadeDeMedida);
    }
  }
}
