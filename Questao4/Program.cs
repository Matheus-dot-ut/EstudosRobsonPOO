internal class Aluno
{
    public string Nome  { get; set; }
    public string RA    { get; set; }
    public int    Idade { get; set; }

    public void AlunoNovo() // public aqui!
    {
        Console.WriteLine("Digite o nome: ");
        this.Nome  = Console.ReadLine();

        Console.WriteLine("Digite o RA: ");
        this.RA    = Console.ReadLine();

        Console.WriteLine("Digite a idade: ");
        this.Idade = int.Parse(Console.ReadLine());
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome} | RA: {RA} | Idade: {Idade}");
    }
}