using Domain.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.EntityFramework.Data
{
  public class ClienteData
  {
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string CPF { get; private set; }
    public string Sexo { get; private set; }
    public string Email { get; private set; }

    protected ClienteData()
    {

    }

    public ClienteData(Cliente cliente)
    {
      Id = cliente.Id;
      Nome = cliente.Nome;
      CPF = cliente.CPF.ToString();
      Sexo = cliente.Sexo;
      Email = cliente.Email;
    }
  }
}
