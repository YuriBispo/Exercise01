using App.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    public ActionResult Add()
    {
      return Ok();
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
