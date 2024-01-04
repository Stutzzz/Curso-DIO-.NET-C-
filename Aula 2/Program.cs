int quantidadeEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0){
    Console.WriteLine("Venda invalida");

}else if(possivelVenda){
    Console.WriteLine("Venda realizada");

}else{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");

}