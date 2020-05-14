using Domain.Clientes;
using Domain.Pedidos.Enums;
using Domain.Produtos;
using System;
using System.Collections.Generic;
using System.Text;
using Entity = Domain.Pedidos;

namespace Infra.EntityFramework.Entities
{
  public class PedidoData
  {
    public Guid Id { get; private set; }
    public DateTime Data { get; private set; }
    public string Observacao { get; private set; }
    public FormaPagamento FormaPagamento { get; private set; }
    public Cliente Cliente { get; set; }
    public ICollection<Produto> Produtos { get; set; }

    public PedidoData(Entity.Pedido pedido)
    {
      Id = pedido.Id;
      Data = pedido.Data;
      Observacao = pedido.Observacao;
    }
  }
}
