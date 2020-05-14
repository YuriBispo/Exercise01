using Request = App.DTOs.Request;
using Response = App.DTOs.Response;
using App.IServices;
using Infra.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infra.EntityFramework;
using Microsoft.EntityFrameworkCore;
using App.Exceptions;
using System.Linq;
using Domain.Produtos.ValueObjects;

namespace App.Services.Produto
{
  public class ProdutoAppService : IProdutoAppService
  {
    private readonly IProdutoRepository produtoRepository;
    public ProdutoAppService(IProdutoRepository produtoRepository)
    {      
      this.produtoRepository = produtoRepository;
    }

    public async Task<Response.Produto> Add(Request.Produto entity)
    {
      if (!IsParameterValid(entity))
        throw new InvalidParametersException<IProdutoAppService>();

      var produto = await produtoRepository.Add(entity.ConvertToDomain());

      await Salvar();

      return new Response.Produto(produto);
    }

    public Response.Produto Get(Guid id)
    {
      if (!IsParameterValid(id))
        throw new InvalidParametersException<IProdutoAppService>();

      var prod = produtoRepository.Get(x => x.Id == id)
        .FirstOrDefault();

      return new Response.Produto(prod);
    }

    public async Task<Response.Produto> Remove(Guid id)
    {
      if (!IsParameterValid(id))
        throw new InvalidParametersException<IProdutoAppService>();

      var produto = produtoRepository.Get(x => x.Id == id)
        .FirstOrDefault();

      var result = await produtoRepository.Remove(produto);

      await Salvar();
      return new Response.Produto(result);
    }

    public async Task Salvar()
    {
      await produtoRepository.CommitChangesAsync();      
    }

    public void SalvarSynchronously()
    {
      produtoRepository.CommitChanges();
    }

    public async Task<Response.Produto> Update(DTOs.Request.Produto entity, Guid id)
    {
      if (!IsParameterValid(entity))
        throw new InvalidParametersException<IProdutoAppService>();

      var produto = produtoRepository.Get(x => x.Id == id)
        .FirstOrDefault();

      var domain = entity.ConvertToDomain();

      produto.AtualizarValores(domain.Id, 
        domain.Tamanho,
        domain.Fabricacao, 
        domain.Valor);

      var result = await produtoRepository.Update(produto);

      SalvarSynchronously();
      return new Response.Produto(result);
    }

    private bool IsParameterValid(DTOs.Request.Produto produto)
    {
      var result = produto != null;
      result = result && !string.IsNullOrWhiteSpace(produto.Tamanho);
      result = result && produto.Valor > 0;

      return result;
    }

    private bool IsParameterValid(Guid id)
    {
      return id != Guid.Empty;
    }
  }
}
