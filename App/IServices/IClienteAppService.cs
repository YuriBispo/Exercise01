using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Response = App.DTOs.Response;
using Request = App.DTOs.Request;
namespace App.IServices
{
  public interface IClienteAppService : IService
  {
    Response.Cliente Get();
    Response.Cliente Get(Guid id);
    Task<Response.Cliente> Add(Request.Cliente entity);
    Task<Response.Cliente> Update(Request.Cliente entity, Guid id);
    Task<Response.Cliente> Remove(Guid id);
  }
}
