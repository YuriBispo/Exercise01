using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Request = App.DTOs.Request;
using Response = App.DTOs.Response;

namespace App.IServices
{
  public interface IProdutoAppService : IService
  {
    Response.Produto Get(Guid id);
    Task<Response.Produto> Add(Request.Produto entity);
    Task<Response.Produto> Update(Request.Produto entity);
    Task<Response.Produto> Remove(Guid id);
  }
}
