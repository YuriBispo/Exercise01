CRUD
Clientes:
 CodigoCliente,
 Nome,
 Cpf,
 Sexo,
 Email

CRUD
Produtos:
 CódigoProduto
 Fabricação(nacional, importado)
 Tamanho,
 Valor

CRUD
Pedidos:
 CódigoPedido,
 Data,
 Observação,
 FormaDePagamento(dinheiro, cartão, cheque);

GET
Relatório
 Nacional > 100 == imposto de 10% do valor do produto;
 Nacional <= 100 == isento;
 Internacional == 15% do valor do produto;
 Total/mês == soma de todos os impostos de cada produto nos pedidos;