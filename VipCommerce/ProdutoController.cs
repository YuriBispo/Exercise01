using App.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Requests = App.DTOs.Request;

namespace WebApi
{
  [Route("/api/produtos")]
  public class ProdutoController : Controller
  {
    private readonly IProdutoAppService produtoAppService;
    public ProdutoController(IProdutoAppService produtoAppService)
    {
      this.produtoAppService = produtoAppService;
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult Get(Guid id)
    {
      return Ok(produtoAppService.Get(id));
    }

    [HttpPost]
    public async Task<ActionResult> Add([FromBody] Requests.Produto produto)
    {
      return Ok(await produtoAppService.Add(produto));
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] Requests.Produto produto)
    {
      return Ok(await produtoAppService.Update(produto, produto.Id));
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<ActionResult> Delete(Guid id)
    {
      return Ok(await produtoAppService.Remove(id));
    }
  }
}
