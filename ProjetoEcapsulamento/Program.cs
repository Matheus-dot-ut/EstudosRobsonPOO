
internal class Cliente
{
    public string NomeCliente { get; set; } 
    public string CPF { get; set; }
    public string Cidade { get; set; }

    public void DigitaValoresCliente()
    {
        Console.WriteLine("Digite o nome do Cliente:");
        NomeCliente = Console.ReadLine();

        Console.WriteLine("Digite o CPF:");
        CPF = Console.ReadLine();

        Console.WriteLine("Digite a cidade:");
        Cidade = Console.ReadLine();

    }

    public void MostraValoresCliente()
    {
        Console.WriteLine($"Nome: {NomeCliente}");
        Console.WriteLine(" ");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine(" ");
        Console.WriteLine($"Cidade: {Cidade}");
        Console.WriteLine(" ");
    }

    public string RetornaApresentacao()
    {
        return $"Cliente {NomeCliente}, CPF {CPF}, morador(a) da cidade {Cidade}. ";
        
    }
}

internal class Vendedor
{
    public string NomeVendedor { get; set; }
    public string Matricula { get; private set; }
    public double PercentualComissao { get; set; }

    public double valorPedido {get; private set;}

    public void DigitarValoresVendedor()
    {
        Console.Write("Digite o nome do vendedor: ");
        NomeVendedor = Console.ReadLine();

        Console.WriteLine("Digite a matrícula: ");
        Matricula = Console.ReadLine();

        Console.WriteLine("Digite o percentual da comissão: ");
        PercentualComissao = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor Pedido: ");
        valorPedido = double.Parse(Console.ReadLine());
        
    }

    public void PercentualCondicaoVendedor()
    {
        if (PercentualComissao < 0)
        {
            Console.WriteLine("Percentual de comissão não pode ser menor que zero");
        }
    }

    public double CalcularComissao(double PercentualComissao = 0.05)
    {
       
        return valorPedido * PercentualComissao;

    }

    public void MostraValorVendedor()
    {
        
        Console.WriteLine($"Nome do Vendedor: {NomeVendedor}");
        Console.WriteLine(" ");
        Console.WriteLine($"Matrícula: {Matricula}+{"10"}");
        Console.WriteLine(" ");
        Console.WriteLine($"Percentual da Comissão: {PercentualComissao}");
        Console.WriteLine(" ");
        double comissao = CalcularComissao(valorPedido);
        Console.Write($"Comissão {comissao}");
        Console.WriteLine(" ");
        
    }



}
internal class Produto
{
    public string descricao {get;set;}
    public int precoUnitario {get;set;}
    public int quantidade {get;set;}

    public void DigitaValoresProduto()
    {
        Console.WriteLine("Digite o a descrição do produto: ");
        this.descricao = Console.ReadLine();
        Console.WriteLine("Digite o valor do precoUnitario:  ");
        this.precoUnitario = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade: ");
        this.quantidade = int.Parse(Console.ReadLine());
    }

    public void CondicaoProduto()
    {
        if(precoUnitario < 0)
        {
            Console.WriteLine("Não pode ter numeros negatvos");
            return;
        }
         if(quantidade < 0)
        {
            Console.WriteLine("Não pode ter numeros negatvos");
            return;
        }
        
    
    }
    public int CalcularSubtotalProduto()
    {
            return precoUnitario * quantidade;
    }
    public void ExibirDadosProduto()
    {
        
        Console.WriteLine($"Descrição do produto: {descricao}");
        Console.WriteLine("");
        Console.WriteLine($"Preço Unitario do Produto: {precoUnitario}");
        Console.WriteLine("");
        Console.WriteLine($"Quantidade Produto: {quantidade}");
        Console.WriteLine("");
        int subtotal = CalcularSubtotalProduto();
        Console.WriteLine($"Resultado do calculo: {subtotal}");
        Console.WriteLine("");

    }
}
internal class Pagamento
{
    public string FormaPagamento {set;get;}
    public decimal Parcelas {get;set;}

    public double ValorBase {get;private set;}

    

    public void DigitaValoresPagamento()
    {
        Console.WriteLine("Digite a sua forama de pagamento: ");
        this.FormaPagamento = Console.ReadLine();
        Console.WriteLine("Digite quantas parcelas (Em numeros): ");
        this.Parcelas = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor base: ");
        this.ValorBase = double.Parse(Console.ReadLine());
    }
    public bool ValidaPagamento()
    {
        if(string.IsNullOrEmpty(FormaPagamento))
        {
            return false;
        }
        if(Parcelas<=0)
        {
            Console.Write("Pagamento não valido");
            return false;

        }
        Console.Write("Pagamento Valido");
        return true;
    }
    const double TaxaJurosPagamento = 0.05;
    public double CalculoAcrecimoPagamento()
    {
        double acrecimo = TaxaJurosPagamento*ValorBase;
        return ValorBase + acrecimo;
    }

    public void CondicaoPagamento()
    {
        if(this.Parcelas<0)
        {
            Console.Write("Valor não pode ser negativo");
            return;
        }
    }
    public void ExibirPagamentos()
    {
        Console.WriteLine($"Forma de pagamento: {FormaPagamento}");
        Console.WriteLine("");
        Console.WriteLine($"Parcelas: {Parcelas}");
        Console.WriteLine("");
        bool validoPagamento = ValidaPagamento();
        Console.WriteLine("");
        double calculoAcrecimo = CalculoAcrecimoPagamento();
        Console.WriteLine("");
        Console.WriteLine($"Acrecimo: {calculoAcrecimo} ");
        Console.WriteLine("");
    }

}
internal class Entrega
{
    public string Endereco {get;set;}
    public double distanciaKM {get;set;}
    public string TipoEntrega {get;set;}

    public void DigitarValoresEntrega()
    {
        Console.WriteLine("Escreva o endereço: ");
        this.Endereco = Console.ReadLine();
        Console.WriteLine("Escreva a distancia em KM:");
        this.distanciaKM = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o tipo de entrega");
        this.TipoEntrega = Console.ReadLine();
    }
    const double TaxaEntrega = 2.50;
    public double CalculoTaxaEntrega()
    {
        return distanciaKM*TaxaEntrega;
    }

    public void CondicaoEntrega()
    {
        if(distanciaKM<0)
        {
            Console.Write("Não pode ter dados negativos");
            return;
        }
    }

    public void ExibirDadosEntrega()
    {
        Console.WriteLine($"Descrição do produto: {Endereco}");
        Console.WriteLine("");
        Console.WriteLine($"Preço Unitario do Produto: {distanciaKM}");
        Console.WriteLine("");
        Console.WriteLine($"Quantidade Produto: {TipoEntrega}");
        Console.WriteLine("");
        double valorTaxa = CalculoTaxaEntrega();
        Console.WriteLine($"O valor das taxa de entrega foi de R$ {valorTaxa}");
        
    }

}
internal class Pedido
{
    public int Numero { get; set; }
    public Cliente Cliente { get; set; }     
    public Vendedor Vendedor { get; set; }   
    public Produto Produto { get; set; }     
    public Pagamento Pagamento { get; set; } 
    public Entrega Entrega { get; set; } 

    public void ValoresPedido()
    {
        Cliente cliente = new Cliente();
        Vendedor vendedor = new Vendedor();
        Produto produto = new Produto();
        Pagamento pagamento = new Pagamento();
        Entrega entrega = new Entrega();
for(int i =0;i<2;i++)
{
        Console.WriteLine($"Escreva o valor do numero pedido {i}: ");
        Numero = int.Parse(Console.ReadLine());
        cliente.DigitaValoresCliente();
        cliente.RetornaApresentacao();
        vendedor.DigitarValoresVendedor();
        produto.DigitaValoresProduto();
        pagamento.DigitaValoresPagamento();
        entrega.DigitarValoresEntrega();

        
        vendedor.PercentualCondicaoVendedor();
        produto.CondicaoProduto();
        pagamento.CondicaoPagamento();
        entrega.CondicaoEntrega();

        vendedor.CalcularComissao();
        produto.CalcularSubtotalProduto();
        pagamento.CalculoAcrecimoPagamento();
        entrega.CalculoTaxaEntrega();

        cliente.MostraValoresCliente();
        vendedor.MostraValorVendedor();
        produto.ExibirDadosProduto();
        pagamento.ExibirPagamentos();
        entrega.ExibirDadosEntrega();
        Console.WriteLine(" ");
Console.WriteLine("===Calculo Final---");
double resultadoCalculoFinal = produto.CalcularSubtotalProduto() 
                 + entrega.CalculoTaxaEntrega() 
                 + pagamento.CalculoAcrecimoPagamento();
Console.WriteLine($"Resultado do calculoi final: {resultadoCalculoFinal}");
Console.Write(" ");
}


    }
}