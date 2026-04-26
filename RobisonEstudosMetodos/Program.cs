using System.Data;
using System.Dynamic;
using System.Globalization;
using System.Security.Cryptography;

internal class Aluno
{
    public int Ra { get; set; }
    public string Nome { get; set; }
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double NotaFinal { get; set; }

    public void ReceberDadosAluno()
    {
        Console.WriteLine("Digite o seu Nome: ");
        Nome = Console.ReadLine();

        Console.WriteLine("Digite o RA: ");
        Ra = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota da prova: ");
        NotaProva = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota do trabalho: ");
        NotaTrabalho = double.Parse(Console.ReadLine());
    }

    public void CalcularMedia()
    {
        NotaFinal = (NotaProva + NotaTrabalho) / 2;
    }

    public bool Aprovado()
    {
        return NotaFinal >= 7;
    }

    public void ImprimirResultado()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"RA: {Ra}");
        Console.WriteLine($"Média: {NotaFinal}");

        if (Aprovado())
            Console.WriteLine("Aprovado");
        else
            Console.WriteLine("Reprovado");
    }
}

internal class ContaBancaria
{
    public int NumeroConta { get; set; }
    public string NomeTitular { get; set; }
    public double Saldo { get; set; }

    public void ReceberDadosConta()
    {
        Console.WriteLine("Digite o número da conta:");
        NumeroConta = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do titular:");
        NomeTitular = Console.ReadLine();

        Console.WriteLine("Digite o saldo (use vírgula):");
        Saldo = double.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
    }

    public void Depositar()
    {
        Console.WriteLine("Digite o valor para depósito:");
        double valor = double.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

        Saldo += valor;
        Console.WriteLine("Depósito realizado.");
    }

    public void Sacar()
    {
        Console.WriteLine("Digite o valor para saque:");
        double valor = double.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine("Saque realizado.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Conta: {NumeroConta}");
        Console.WriteLine($"Titular: {NomeTitular}");
        Console.WriteLine($"Saldo: {Saldo.ToString("F2", new CultureInfo("pt-BR"))}");
    }
}

internal class Produto
{
    public string CodigoProduto { get; set; }
    public string NomeProduto { get; set; }
    public decimal PrecoProduto { get; set; }
    public double QuantidadeEstoque { get; set; }

    public void ReceberDadosProduto()
    {
        Console.WriteLine("Digite o código do produto:");
        CodigoProduto = Console.ReadLine();

        Console.WriteLine("Digite o nome do produto:");
        NomeProduto = Console.ReadLine();

        Console.WriteLine("Digite o preço do produto:");
        PrecoProduto = decimal.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

        Console.WriteLine("Digite a quantidade em estoque:");
        QuantidadeEstoque = double.Parse(Console.ReadLine());
    }

    public void AdicionarProdutoEstoque()
    {
        Console.WriteLine("Digite a quantidade para adicionar:");
        double quantidade = double.Parse(Console.ReadLine());

        QuantidadeEstoque += quantidade;

        Console.WriteLine("Estoque atualizado.");
    }

    public void RemoverProdutoEstoque()
    {
        Console.WriteLine("Digite a quantidade para remover:");
        double quantidade = double.Parse(Console.ReadLine());

        if (quantidade <= QuantidadeEstoque)
        {
            QuantidadeEstoque -= quantidade;
            Console.WriteLine("Produto removido.");
        }
        else
        {
            Console.WriteLine("Quantidade maior que o estoque.");
        }
    }

    public void MostrarProduto()
    {
        Console.WriteLine($"Código: {CodigoProduto}");
        Console.WriteLine($"Nome: {NomeProduto}");
        Console.WriteLine($"Preço: {PrecoProduto.ToString("F2", new CultureInfo("pt-BR"))}");
        Console.WriteLine($"Estoque: {QuantidadeEstoque}");
    }
}

internal class CalculadoraDeSalarioFuncionario()
{
    public string NomeFuncionario {get;set;}
    public decimal SalarioBaseFuncionario {get;set;}
    public decimal SalarioFinalFuncionario {get;set;}


    public void ReceberDadosFuncionario()
    {
        Console.WriteLine("Diigite seu nome: ");
        this.NomeFuncionario = Console.ReadLine();
        Console.WriteLine("Digite o seu salrio Base: ");
        this.SalarioBaseFuncionario = decimal.Parse(Console.ReadLine());
        SalarioBaseFuncionario = SalarioFinalFuncionario;

    }
    public void CalculaAumento()
    {
        Console.WriteLine($"Digite o percentual que deseja ao aumento salarial: ");
        double PercentualAumentoFuncionario = double.Parse(Console.ReadLine());
        double AumentoFuncionario = SalarioFinalFuncionario*(percentual/100);
        SalarioFinalFuncionario += AumentoFuncionario;

    }
    public void CalculoDescontoFuncionario()
    {
        Console.WriteLine($"Digite o percentual que deseja ao desconto salarial: ");
        double PercentualDescontoFuncionario = double.Parese(Console.ReadLine);
        double DescontoFuncionario = SalarioFinalFuncionario * (PercentualDescontoFuncionario/100);
        SalarioFinalFuncionario -= DescontoFuncionario;

    }
    public void ImprimirDadosFuncionalSalarial()
    {
        Console.WriteLine($"{NomeFuncionario}");
        Console.WriteLine($"O salario atual de {NomeFuncionario} é {SalarioFinalFuncionario:F2}", new CultureInfo("pt-BR"));

    }
    
}
public class Hospede
{
    public string NomeHospede {get;set;}
    public string CpfHospede {get;set;}
    public string TelefoneHospede {get;set;}

    public void ReceberDadosHospede()
    {
        Console.WriteLine("Digita o nome do Hospede: ");
        this.NomeHospede = Console.ReadLine();
        Console.WriteLine("Digite o CPF do hospede: ");
        this.CpfHospede = Console.ReadLine();
        Console.WriteLine("Digite o telefone do Hospede: ");
        this.TelefoneHospede = Console.ReadLine();
    }
    public void MostraDaodsHospede()
    {
        Console.WriteLine($"Nome do hospede: {NomeHospede}");
        Console.WriteLine($"CPF do hospede: {CpfHospede}");
        Console.WriteLine($"Telefone do hospede: {TelefoneHospede}");

    }
    public void AtualizaTelefone(string NovoTelefone)
    {
        NovoTelefone=TelefoneHospede;
    }
}

internal class Reservas
{
    public int NumeroReservas {get;set;}
    public int QuantidadeReservas {get;set;}
    public double ValorDiariaReserva {get;set;}
    public double ValorTotalReserva {get;set;}

    public void ReceberDadosReserva()
    {
        Console.WriteLine("Digite o numero de reservas: ");
        this.NumeroReservas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de reservas: ");
        this.QuantidadeReservas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da diaria: ");
        this.ValorDiariaReserva = double.Parse(Console.ReadLine());
    }
    public void CalcularTotalReserva()
    {
        ValorTotalReserva = QuantidadeReservas*ValorDiariaReserva;
    }
    public void CalcularDescontoReserva(double percentualReserva)
    {
        ValorTotalReserva -= ValorTotalReserva*(percentualReserva/100);
    }
    public void MostrarDadosReserva()
    {
        Console.WriteLine($"Número da Reserva: {NumeroReserva}");
        Console.WriteLine($"Quantidade de Diárias: {QuantidadeDiarias}");
        Console.WriteLine($"Valor da Diária: R$ {ValorDiaria:F2}");
        Console.WriteLine($"Valor Total: R$ {ValorTotal:F2}");
    }

}
