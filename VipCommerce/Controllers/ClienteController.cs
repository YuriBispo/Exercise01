using App.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Requests = App.DTOs.Request;

namespace WebApi.Controllers
{
  public class ClienteController: Controller
  {
    private readonly IClienteAppService clienteAppService;

    public ClienteController(IClienteAppService clienteAppService)
    {
      this.clienteAppService = clienteAppService;
    }

    [HttpGet]
    public ActionResult GetAll(Guid id)
    {
      return Ok(clienteAppService.Get(id));
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult Get(Guid id)
    {
      return Ok(clienteAppService.Get(id));
    }

    [HttpPost]
    public async Task<ActionResult> Add([FromBody] Requests.Cliente cliente)
    {
      return Ok(await clienteAppService.Add(cliente));
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromBody] Requests.Cliente cliente)
    {
      return Ok(await clienteAppService.Update(cliente, cliente.Id));
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<ActionResult> Delete(Guid id)
    {
      return Ok(await clienteAppService.Remove(id));
    }
  }
}
