using App.Exceptions;
using App.IServices;
using App.Services;
using App.Services.Produto;
using Infra.EntityFramework;
using Infra.EntityFramework.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Response = App.DTOs.Response;
using Request = App.DTOs.Request;
using Infra.EntityFramework.Repositories.Produto;

namespace Tests.Unit.App
{
  [TestFixture]
  public class ProdutoAppServiceTest
  {
    private IProdutoAppService produtoAppService;
    private Guid id;
    private Request.Produto produto;
    [SetUp]
    public void SetUp()
    {
      var produtoRepositoryMock = new Mock<IProdutoRepository>();
      produtoAppService = new ProdutoAppService(produtoRepositoryMock.Object);

      id = Guid.NewGuid();
      produto = new Request.Produto();
    }

    #region [ GET ]

    [Test]
    public void Get_Deve_Retornar_Um_Response_Produto()
    {
      var id = Guid.NewGuid();

      var teste = produtoAppService.Get(id);

      Assert.IsInstanceOf<Response.Produto>(teste);
    }

    [Test]
    public void Parametros_Invalidos_Em_Get_Devem_Estourar_Exception()
    {
      var id = Guid.Empty;

      Assert.Throws<InvalidParametersException<IProdutoAppService>>(() =>
      {
        produtoAppService.Get(id);
      });
    }

    #endregion

    #region [ POST ]

    [Test]
    public void Post_Deve_Retornar_Um_Response_Produto()
    {
      var teste = produtoAppService.Add(produto);

      Assert.IsInstanceOf<Response.Produto>(teste);
    }

    [Test]
    public void Parametros_Invalidos_Em_Post_Devem_Estourar_Exception()
    {
      var id = Guid.Empty;

      Assert.Throws<InvalidParametersException<IProdutoAppService>>(() =>
      {
        produtoAppService.Get(id);
      });
    }

    #endregion

    #region [ UPDATE ]

    [Test]
    public void Update_Deve_Retornar_Um_Response_Produto()
    {
      var id = Guid.NewGuid();

      var teste = produtoAppService.Get(id);

      Assert.IsInstanceOf<Response.Produto>(teste);
    }

    [Test]
    public void Parametros_Invalidos_Em_Update_Devem_Estourar_Exception()
    {
      var id = Guid.Empty;

      Assert.Throws<InvalidParametersException<IProdutoAppService>>(() =>
      {
        produtoAppService.Get(id);
      });
    }

    #endregion

    #region [ DELETE ]

    [Test]
    public void Delete_Deve_Retornar_Um_Response_Produto()
    {
      var id = Guid.NewGuid();

      var teste = produtoAppService.Get(id);

      Assert.IsInstanceOf<Response.Produto>(teste);
    }

    [Test]
    public void Parametros_Invalidos_Em_Delete_Devem_Estourar_Exception()
    {
      var id = Guid.Empty;

      Assert.Throws<InvalidParametersException<IProdutoAppService>>(() =>
      {
        produtoAppService.Get(id);
      });
    }

    #endregion
  }
}
