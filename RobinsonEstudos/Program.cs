internal class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string Categoria { get; set; }
    public double Peso { get; set; }
}

internal class Cliente
{
    public string Nome { get; set; }
    public string Cidade { get; set; }
    public int Idade { get; set; }
}

internal class Pedido
{
    public int NumeroPedido { get; set; }
    public double Quantidade { get; set; }
    public double DescontoPercentual { get; set; }
}

internal class Loja
{
    public string Nome { get; set; }
    public string Cidade { get; set; }
    public double TaxaEntrega { get; set; }
}
