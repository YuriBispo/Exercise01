using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Response = App.DTOs.Response;
using Request = App.DTOs.Request;
namespace App.IServices
{
  public interface IPedidoAppService : IService
  {
    Response.Pedido Get();
    Response.Pedido Get(Guid id);
    Task<Response.Pedido> Add(Request.Pedido entity);
    Task<Response.Pedido> Update(Request.Pedido entity, Guid id);
    Task<Response.Pedido> Remove(Guid id);
    Task<Response.Pedido> EnviarEmail();
  }
}
