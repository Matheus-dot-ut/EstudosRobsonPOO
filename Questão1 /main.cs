class Funcionario
{
    protected string nome;
    protected string cargo;
    protected double salarioBase;

    public void ReceberDados()
    {
        Console.WriteLine("Nome: ");
        this.nome = Console.ReadLine();
        Console.WriteLine("Cargo: ");
        this.cargo = Console.ReadLine();
        Console.WriteLine("Salario Base: ");
        this.salarioBase = double.Parse(Console.ReadLine());
    }

    public virtual double CalculoSalarioFinal()
    {
        return salarioBase;
    }
    
    public virtual void MostraDados()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salario Final: {CalculoSalarioFinal():F2}");
    }
}
class FuncionarioCLT : Funcionario
{
    private double bonus;

    public void ReceberDadosCLT()
    {
        base.ReceberDados();

        Console.WriteLine("Bonus:");
        this.bonus = double.Parse(Console.ReadLine());

    }

    public override double CalculoSalarioFinal()
    {
        return salarioBase + bonus;
    }

     public override void MostraDados()
    {
        Console.WriteLine("\n=== Funcionário CLT ===");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salário base: R$ {salarioBase:F2}");
        Console.WriteLine($"Bônus: R$ {bonus:F2}");
        Console.WriteLine($"Salário final: R$ {CalculoSalarioFinal():F2}");
    }


}
class FuncionarioComissao : Funcionario
{
    private double TotalVendas;
    private double PercentualComissao;

    public override double CalculoSalarioFinal()
    {
        return salarioBase + (TotalVendas * PercentualComissao / 100);
    }
    public override void MostraDados()
    {
        Console.WriteLine("\n=== Funcionário Comissionado ===");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salário base: R$ {salarioBase:F2}");
        Console.WriteLine($"Total de vendas: R$ {TotalVendas:F2}");
        Console.WriteLine($"Comissão ({PercentualComissao}%): R$ {TotalVendas * PercentualComissao / 100:F2}");
        Console.WriteLine($"Salário final: R$ {CalculoSalarioFinal():F2}");
    }
}

 