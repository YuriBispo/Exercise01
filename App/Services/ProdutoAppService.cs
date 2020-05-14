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

    public async Task<DTOs.Response.Produto> Add(DTOs.Request.Produto entity)
    {
      var a = await produtoRepository.Add(entity.ConvertToDomain());

      await produtoRepository.CommitChanges();

      return new DTOs.Response.Produto(a);
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

    private void ValidateParameters(DTOs.Request.Produto produto)
    {
      
    }
  }
}
