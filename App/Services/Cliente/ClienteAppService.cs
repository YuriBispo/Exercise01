using App.Exceptions;
using App.IServices;
using Infra.EntityFramework.Repositories.Cliente;
using System;
using System.Linq;
using System.Threading.Tasks;
using Request = App.DTOs.Request;
using Response = App.DTOs.Response;

namespace App.Services.Cliente
{
  public class ClienteAppService : IClienteAppService
  {
    private readonly IClienteRepository clienteRepository;
    public ClienteAppService(IClienteRepository clienteRepository)
    {      
      this.clienteRepository = clienteRepository;
    }

    public async Task<Response.Cliente> Add(Request.Cliente entity)
    {
      if (!IsParameterValid(entity))
        throw new InvalidParametersException<IClienteAppService>();

      var cliente = await clienteRepository.Add(entity.ConvertToData());

      await Salvar();

      return new Response.Cliente();
    }

    public Response.Cliente Get(Guid id)
    {
      if (!IsParameterValid(id))
        throw new InvalidParametersException<IClienteAppService>();

      var prod = clienteRepository.Get(x => x.Id == id)
        .FirstOrDefault();

      return new Response.Cliente();
    }

    public Response.Cliente Get()
    {
      throw new NotImplementedException();
    }

    public async Task<Response.Cliente> Remove(Guid id)
    {
      if (!IsParameterValid(id))
        throw new InvalidParametersException<IClienteAppService>();

      var cliente = clienteRepository.Get(x => x.Id == id)
        .FirstOrDefault();

      var result = await clienteRepository.Remove(cliente);

      await Salvar();
      return new Response.Cliente();
    }

    public async Task Salvar()
    {
      await clienteRepository.CommitChangesAsync();      
    }

    public void SalvarSynchronously()
    {
      clienteRepository.CommitChanges();
    }

    public async Task<Response.Cliente> Update(DTOs.Request.Cliente entity, Guid id)
    {
      if (!IsParameterValid(entity))
        throw new InvalidParametersException<IClienteAppService>();

      var cliente = clienteRepository.Get(x => x.Id == id)
        .FirstOrDefault();

      var domain = entity.ConvertToData();

      var result = await clienteRepository.Update(cliente);

      SalvarSynchronously();
      return new Response.Cliente();
    }

    private bool IsParameterValid(DTOs.Request.Cliente cliente)
    {
      var result = cliente != null;
      result = result && !string.IsNullOrWhiteSpace(cliente.CPF);
      result = result && !string.IsNullOrWhiteSpace(cliente.Email);
      result = result && !string.IsNullOrWhiteSpace(cliente.Nome);
      result = result && !string.IsNullOrWhiteSpace(cliente.Sexo);

      return result;
    }

    private bool IsParameterValid(Guid id)
    {
      return id != Guid.Empty;
    }
  }
}
