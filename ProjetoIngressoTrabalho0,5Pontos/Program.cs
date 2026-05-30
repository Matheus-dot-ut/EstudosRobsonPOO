
class Ingresso
{
    public string NomeCliente { get; set; }
    public string Filme { get; set; }
    public int NumeroPoltrona { get; set; }
    public double Valor { get; set; }
    public bool MeiaEntrada { get; set; }
}

class Program
{
    static List<Ingresso> ingressos = new List<Ingresso>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== CINEMA =====");
            Console.WriteLine("1 - Cadastrar ingresso");
            Console.WriteLine("2 - Listar ingressos vendidos");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarIngresso();
                    break;
                case 2:
                    ListarIngressos();
                    break;
                case 3:
                    Console.WriteLine("Encerrando o sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 3);
    }

    static void CadastrarIngresso()
    {
        Ingresso novo = new Ingresso();

        Console.Write("Nome do cliente: ");
        novo.NomeCliente = Console.ReadLine();

        Console.Write("Nome do filme: ");
        novo.Filme = Console.ReadLine();

        Console.Write("Número da poltrona: ");
        novo.NumeroPoltrona = int.Parse(Console.ReadLine());

        // Verifica se a poltrona já foi vendida para o mesmo filme
        foreach (Ingresso i in ingressos)
        {
            if (i.NumeroPoltrona == novo.NumeroPoltrona &&
                i.Filme.Equals(novo.Filme, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Erro: essa poltrona já foi vendida para esse filme!");
                return;
            }
        }

        Console.Write("Valor do ingresso: R$ ");
        novo.Valor = double.Parse(Console.ReadLine());

        Console.Write("É meia entrada? (S/N): ");
        string resposta = Console.ReadLine().Trim().ToUpper();
        novo.MeiaEntrada = (resposta == "S");

        // Se for meia entrada, aplica o desconto de 50%
        if (novo.MeiaEntrada)
            novo.Valor = novo.Valor / 2;

        ingressos.Add(novo);
        Console.WriteLine("Ingresso cadastrado com sucesso!");
    }

    static void ListarIngressos()
    {
        if (ingressos.Count == 0)
        {
            Console.WriteLine("Nenhum ingresso cadastrado.");
            return;
        }

        double totalArrecadado = 0;

        Console.WriteLine("\n===== INGRESSOS VENDIDOS =====");

        foreach (Ingresso i in ingressos)
        {
            Console.WriteLine($"Cliente: {i.NomeCliente}");
            Console.WriteLine($"Filme: {i.Filme}");
            Console.WriteLine($"Poltrona: {i.NumeroPoltrona}");
            Console.WriteLine($"Valor: R$ {i.Valor:F2}");
            Console.WriteLine($"Tipo: {(i.MeiaEntrada ? "Meia Entrada" : "Inteira")}");
            Console.WriteLine("------------------------------");

            totalArrecadado += i.Valor;
        }

        Console.WriteLine($"Total arrecadado: R$ {totalArrecadado:F2}");
    }
} 

