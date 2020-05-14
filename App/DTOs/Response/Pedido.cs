using Domain.Pedidos.Enums;
using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Entity = Domain.Pedidos;

namespace App.DTOs.Response
{
  public class Pedido
  {
    public Guid Id { get; set; }
    public DateTime Data { get; set; }
    public string Observacao { get; set; }
    public FormaPagamento FormaPagamento { get; set; }
    public Cliente Cliente { get; set; }
    public ICollection<Produto> Produtos { get; set; }

    public Pedido()
    {

    }

    public Pedido(Entity.Pedido entity)
    {
      Id = entity.Id;
      Data = entity.Data;
      FormaPagamento = entity.FormaPagamento;
      Cliente = new Cliente(entity.Cliente);

      if (Produtos == null)
        Produtos = new List<Produto>();

      foreach (var produto in entity.Produtos)
      {
        Produtos.Add(new Produto(produto));
      }
    }
  }
}
