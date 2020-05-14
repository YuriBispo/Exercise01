using Domain.Pedidos.Enums;
using Infra.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Entity = Domain.Pedidos;

namespace App.DTOs.Request
{
  public class Pedido
  {
    public Guid Id { get; set; }
    public DateTime Data { get; set; }
    public string Observacao { get; set; }
    public FormaPagamento FormaPagamento { get; set; }
    public Cliente Cliente { get; set; }
    public ICollection<Produto> Produtos { get; set; }

    public PedidoData ConvertToData()
    {
      var pedido = new Entity.Pedido(Id, Data, Observacao, FormaPagamento);      

      return new PedidoData(pedido);
    }
    
  }
}
