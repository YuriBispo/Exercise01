using Domain.Produtos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Clientes
{
  public class Cliente
  {
    public Cliente(Guid id, string nome, CPF CPF, string sexo, string email)
    {
      Id = id;
      Nome = nome ?? throw new ArgumentNullException(nameof(nome));
      CPF = CPF ?? throw new ArgumentNullException(nameof(CPF));
      Sexo = sexo ?? throw new ArgumentNullException(nameof(sexo));
      Email = email ?? throw new ArgumentNullException(nameof(email));
    }

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public CPF CPF { get; set; }
    public string Sexo { get; set; }
    public string Email { get; set; }    
  }
}
