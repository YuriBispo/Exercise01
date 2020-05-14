using Domain.Clientes;
using Domain.Pedidos.Enums;
using Domain.Produtos;
using Domain.Produtos.Enums;
using Domain.Produtos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Pedidos
{
  public class Pedido
  {
    public Pedido(Guid id, 
      DateTime data, 
      string observacao, 
      FormaPagamento formaPagamento)
    {
      Id = id;
      Data = data;
      Observacao = observacao ?? throw new ArgumentNullException(nameof(observacao));
      FormaPagamento = formaPagamento;
    }

    public Guid Id { get; private set; }
    public DateTime Data { get; private set; }
    public string Observacao { get; private set; }
    public FormaPagamento FormaPagamento { get; private set; }
    public Clientes.Cliente Cliente { get; set; }
    public ICollection<Produtos.Produto> Produtos { get; set; }

    public Pedido CriarPedido(Cliente cliente, ICollection<Produtos.Produto> produtos)
    {
      if (produtos.Count <= 1 || cliente == null)
        return null;

      Cliente = cliente;
      Produtos = produtos;

      return this;
    }
  }
}
