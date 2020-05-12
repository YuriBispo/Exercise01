using Infra.EntityFramework;
using Infra.EntityFramework.Repositories;
using NUnit.Framework;

namespace VipCommerce.Tests.DataPersistence
{
  [TestFixture]
  public class ProdutoRepositoryTest
  {
    private readonly MySqlContext context;
    private IProdutoRepository produtoRepository;
    [SetUp]
    protected void SetUp()
    {
      produtoRepository = new ProdutoRepository(context);
    }

    [Test]
    public void DeveBuscarUmProduto()
    {
      
    }

    [Test]
    public void DeveAdicionarUmProduto()
    {

    }

    [Test]
    public void DeveAtualizarUmProduto()
    {

    }

    [Test]
    public void DeveDeletarUmProduto()
    {

    }
  }
}