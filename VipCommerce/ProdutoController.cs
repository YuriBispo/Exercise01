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
    public ActionResult Get()
    {
      return Ok();
    }

    [HttpPost]
    public async Task<ActionResult> Add([FromBody] Requests.Produto produto)
    {
      return Ok(await produtoAppService.Add(produto));
    }

    [HttpPut]
    public ActionResult Update()
    {
      return Ok();
    }

    [HttpDelete]
    public ActionResult Delete()
    {
      return Ok();
    }
  }
}
