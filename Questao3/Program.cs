class Veiculo
{
    protected string Modelo;
    protected int Ano;
    protected double ValorBaseManutencao;
 
    public void ReceberDados()
    {
        Console.Write("Modelo: ");
        Modelo = Console.ReadLine();
 
        Console.Write("Ano: ");
        Ano = int.Parse(Console.ReadLine());
 
        Console.Write("Valor base de manutenção: R$ ");
        ValorBaseManutencao = double.Parse(Console.ReadLine());
    }
 
    public virtual double CalcularCustoManutencao()
    {
        return ValorBaseManutencao;
    }
 
    public virtual void MostrarDados()
    {
        Console.WriteLine($"  Modelo : {Modelo}");
        Console.WriteLine($"  Ano    : {Ano}");
        Console.WriteLine($"  Custo  : R$ {CalcularCustoManutencao():F2}");
    }
}
 
class Carro : Veiculo
{
    private int QuantidadePortas;
 
    public void ReceberDadosCarro()
    {
        ReceberDados();
 
        Console.Write("Quantidade de portas: ");
        QuantidadePortas = int.Parse(Console.ReadLine());
    }
 
    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 200;
    }
 
    public override void MostrarDados()
    {
        Console.WriteLine($"  Modelo           : {Modelo}");
        Console.WriteLine($"  Ano              : {Ano}");
        Console.WriteLine($"  Qtd. Portas      : {QuantidadePortas}");
        Console.WriteLine($"  Custo Manutenção : R$ {CalcularCustoManutencao():F2}");
    }
}
 
class Moto : Veiculo
{
    private int Cilindradas;
 
    public void ReceberDadosMoto()
    {
        ReceberDados();
 
        Console.Write("Cilindradas (cc): ");
        Cilindradas = int.Parse(Console.ReadLine());
    }
 
    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 100;
    }
 
    public override void MostrarDados()
    {
        Console.WriteLine($"  Modelo           : {Modelo}");
        Console.WriteLine($"  Ano              : {Ano}");
        Console.WriteLine($"  Cilindradas      : {Cilindradas} cc");
        Console.WriteLine($"  Custo Manutenção : R$ {CalcularCustoManutencao():F2}");
    }
}
 
class Caminhao : Veiculo
{
    private double CapacidadeCarga;
 
    public void ReceberDadosCaminhao()
    {
        ReceberDados();
 
        Console.Write("Capacidade de carga (toneladas): ");
        CapacidadeCarga = double.Parse(Console.ReadLine());
    }
 
    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 500;
    }
 
    public override void MostrarDados()
    {
        Console.WriteLine($"  Modelo           : {Modelo}");
        Console.WriteLine($"  Ano              : {Ano}");
        Console.WriteLine($"  Cap. Carga       : {CapacidadeCarga} ton");
        Console.WriteLine($"  Custo Manutenção : R$ {CalcularCustoManutencao():F2}");
    }
}
