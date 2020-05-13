using App.DTOs.Request;
using App.DTOs.Response;
using App.IServices;
using Infra.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
  public class ProdutoAppService : IProdutoAppService
  {
    private readonly IProdutoRepository produtoRepository;
    public ProdutoAppService(IProdutoRepository produtoRepository)
    {
      this.produtoRepository = produtoRepository;
    }

    public Task<DTOs.Response.Produto> Add(DTOs.Request.Produto entity)
    {
      throw new NotImplementedException();
    }

    public DTOs.Response.Produto Get(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task<DTOs.Response.Produto> Remove(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task Salvar()
    {
      throw new NotImplementedException();
    }

    public Task<DTOs.Response.Produto> Update(DTOs.Request.Produto entity)
    {
      throw new NotImplementedException();
    }
  }
}
