using Domain.Produtos;
using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using Infra.EntityFramework.Data;
using System;
using Entity = Domain.Clientes;

namespace App.DTOs.Request
{
  public class Cliente
  {
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Sexo { get; set; }
    public string Email { get; set; }

    public ClienteData ConvertToData()
    {
      var cliente = new Entity.Cliente(Id,
        Nome,
        new CPF(CPF),
        Sexo,
        Email);

      return new ClienteData(cliente);
    }
  }
}
