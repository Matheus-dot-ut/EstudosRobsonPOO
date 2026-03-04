Produto produto = new Produto();
Cliente cliente = new Cliente();
Pedido pedido = new Pedido();
Loja loja = new Loja();

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Produto");
    Console.Write("Digite o nome do Produto: ");
    produto.Nome = Console.ReadLine();
    Console.Write("Digite a Categoria: ");
    produto.Categoria = Console.ReadLine();
    Console.Write("Digite o Preço: ");
    produto.Preco = double.Parse(Console.ReadLine());
    Console.Write("Digite o Peso: ");
    produto.Peso = double.Parse(Console.ReadLine());

    Console.WriteLine("Cliente");
    Console.Write("Digite o nome do Cliente: ");
    cliente.Nome = Console.ReadLine();
    Console.Write("Digite a Cidade do Cliente: ");
    cliente.Cidade = Console.ReadLine();
    Console.Write("Digite a Idade do Cliente: ");
    cliente.Idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Pedido");
    Console.Write("Digite o Número do Pedido: ");
    pedido.NumeroPedido = int.Parse(Console.ReadLine());
    Console.Write("Digite a Quantidade: ");
    pedido.Quantidade = double.Parse(Console.ReadLine());
    Console.Write("Digite o Desconto Percentual: ");
    pedido.DescontoPercentual = double.Parse(Console.ReadLine());

    Console.WriteLine("Loja");
    Console.Write("Digite o nome da Loja: ");
    loja.Nome = Console.ReadLine();
    Console.Write("Digite a Cidade da Loja: ");
    loja.Cidade = Console.ReadLine();
    Console.Write("Digite a Taxa de Entrega: ");
    loja.TaxaEntrega = double.Parse(Console.ReadLine());

    double valorBruto = produto.Preco * pedido.Quantidade;
    double valorDesconto = valorBruto * (pedido.DescontoPercentual / 100);
    double valorFinal = valorBruto - valorDesconto;
    double pesoTotal = produto.Peso * pedido.Quantidade;

    if (cliente.Idade < 18)
    {
        double descontoExtra = valorBruto * 0.05;
        valorFinal -= descontoExtra;
    }

    if (pesoTotal > 10)
    {
        loja.TaxaEntrega += 20;
    }

    double valorTotal = valorFinal + loja.TaxaEntrega;

    Console.WriteLine("\nParte do Cálculo");
    Console.WriteLine($"Valor Bruto: {valorBruto}");
    Console.WriteLine($"Valor com Desconto: {valorFinal}");
    Console.WriteLine($"Taxa de Entrega: {loja.TaxaEntrega}");
    Console.WriteLine($"Valor Total: {valorTotal}");
}