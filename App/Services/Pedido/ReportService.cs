using Infra.EntityFramework.Repositories.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Pedido
{
  public class ReportService
  {
    private readonly IPedidoRepository pedidoRepository;
    public ReportService(IPedidoRepository pedidoRepository)
    {
      this.pedidoRepository = pedidoRepository;
    }
  }
}
