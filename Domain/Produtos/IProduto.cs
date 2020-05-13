namespace Domain.Produtos
{
	public interface IProduto : IEntity
	{
    decimal CalcularImposto();
  }
}