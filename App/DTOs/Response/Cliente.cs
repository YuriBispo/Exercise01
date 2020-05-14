using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Entity = Domain.Clientes;

namespace App.DTOs.Response
{
  public class Cliente
  {
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Sexo { get; set; }
    public string Email { get; set; }

    public Cliente()
    {

    }

    public Cliente(Entity.Cliente entity)
    {
      Id = entity.Id;
      Nome = entity.Nome.ToString();
      CPF = entity.CPF.ToString();
      Sexo = entity.Sexo;
      Email = entity.Email;
    }
  }
}
