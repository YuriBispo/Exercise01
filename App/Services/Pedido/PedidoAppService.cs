using App.Exceptions;
using App.IServices;
using Infra.EntityFramework.Repositories.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Request = App.DTOs.Request;
using Response = App.DTOs.Response;

namespace App.Services.Pedido
{
  public class PedidoAppService : IPedidoAppService
  {
    private readonly IPedidoRepository pedidoRepository;
    public PedidoAppService(IPedidoRepository pedidoRepository)
    {
      this.pedidoRepository = pedidoRepository;
    }

    public async Task<Response.Pedido> Add(Request.Pedido entity)
    {
      if (!IsParameterValid(entity))
        throw new InvalidParametersException<IPedidoAppService>();

      var pedido = await pedidoRepository.Add(entity.ConvertToData());

      await Salvar();

      return new Response.Pedido();
    }

    public Task<Response.Pedido> EnviarEmail()
    {
      throw new NotImplementedException();
    }

    public Response.Pedido Get(Guid id)
    {
      if (!IsParameterValid(id))
        throw new InvalidParametersException<IPedidoAppService>();

      var prod = pedidoRepository.Get(x => x.Id == id)
        .FirstOrDefault();

      return new Response.Pedido();
    }

    public Response.Pedido Get()
    {
      throw new NotImplementedException();
    }

    public async Task<Response.Pedido> Remove(Guid id)
    {
      if (!IsParameterValid(id))
        throw new InvalidParametersException<IPedidoAppService>();

      var pedido = pedidoRepository.Get(x => x.Id == id)
        .FirstOrDefault();

      var result = await pedidoRepository.Remove(pedido);

      await Salvar();
      return new Response.Pedido();
    }

    public async Task Salvar()
    {
      await pedidoRepository.CommitChangesAsync();
    }

    public void SalvarSynchronously()
    {
      pedidoRepository.CommitChanges();
    }

    public async Task<Response.Pedido> Update(DTOs.Request.Pedido entity, Guid id)
    {
      if (!IsParameterValid(entity))
        throw new InvalidParametersException<IPedidoAppService>();

      var pedido = pedidoRepository.Get(x => x.Id == id)
        .FirstOrDefault();

      var domain = entity.ConvertToData();

      var result = await pedidoRepository.Update(pedido);

      SalvarSynchronously();
      return new Response.Pedido();
    }

    private bool IsParameterValid(DTOs.Request.Pedido cliente)
    {
      var result = cliente != null;
      result = result && cliente.Id != Guid.Empty;
      result = result && cliente.Data != new DateTime();

      return result;
    }

    private bool IsParameterValid(Guid id)
    {
      return id != Guid.Empty;
    }
  }
}
