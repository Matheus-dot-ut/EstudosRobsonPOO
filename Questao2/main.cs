
class Pagamento {
    protected string NomeCliente;
    protected double Valor;

    public void ReceberDados()
    {
        Console.Write("Nome do cliente: ");
        NomeCliente = Console.ReadLine();

        Console.Write("Valor do pagamento: ");
        Valor = double.Parse(Console.ReadLine());
    }

    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento processado.");
    }

    public virtual void MostrarPagamento()
    {
        Console.WriteLine($"Cliente: {NomeCliente}");
        Console.WriteLine($"Valor: R$ {Valor:F2}");
    }
}

// ─────────────────────────────────────────────
// CLASSE FILHA 1 — Pix
// ─────────────────────────────────────────────
class PagamentoPix : Pagamento
{
    private string ChavePix;
    private string Status;

    public void ReceberDadosPix()
    {
        base.ReceberDados();

        Console.Write("Chave Pix: ");
        ChavePix = Console.ReadLine();
    }

    public override void ProcessarPagamento()
    {
        Status = "Aprovado instantaneamente";
        Console.WriteLine("Pagamento via Pix aprovado instantaneamente!");
    }

    public override void MostrarPagamento()
    {
        Console.WriteLine("\n=== Pagamento Pix ===");
        base.MostrarPagamento();
        Console.WriteLine($"Chave Pix: {ChavePix}");
        Console.WriteLine($"Status: {Status}");
    }
}

// ─────────────────────────────────────────────
// CLASSE FILHA 2 — Cartão de Crédito
// ─────────────────────────────────────────────
class PagamentoCartaoCredito : Pagamento
{
    private int QuantidadeParcelas;
    private double ValorParcela;

    public void ReceberDadosCartao()
    {
        base.ReceberDados();

        Console.Write("Quantidade de parcelas: ");
        QuantidadeParcelas = int.Parse(Console.ReadLine());

        // Validação: parcelas inválidas viram 1
        if (QuantidadeParcelas <= 0)
            QuantidadeParcelas = 1;
    }

    public override void ProcessarPagamento()
    {
        ValorParcela = Valor / QuantidadeParcelas;
        Console.WriteLine($"Pagamento no cartão aprovado! {QuantidadeParcelas}x de R$ {ValorParcela:F2}");
    }

    public override void MostrarPagamento()
    {
        Console.WriteLine("\n=== Pagamento Cartão de Crédito ===");
        base.MostrarPagamento();
        Console.WriteLine($"Parcelas: {QuantidadeParcelas}x");
        Console.WriteLine($"Valor por parcela: R$ {ValorParcela:F2}");
    }
}

