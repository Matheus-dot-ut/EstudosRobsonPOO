internal class Aluno
{
     public int Ra {get;set;}
     public string Nome {get;set;}
     public double NotaProva {get;set;}
     public double NotaTrabalho  {get;set;}
     public double NotaFinal {get;set;}

     public void CalcularMedia()
    {
        NotaProva = (NotaProva+NotaTrabalho)/2;
    }
    public bool CalcularNotaFinal()
    {
       if(NotaProva>=7)
       {
       NotaFinal=0;
       return true;
       }

       NotaFinal = 14 - NotaProva;
       return false;
    }

    public void ImprimirNotaFinal()
    {
        Console.Write($"Nome:{Nome}");
        Console.Write($"O Ra do {Nome} e {Ra} ");
        Console.Write($"A nota da prova foi de {NotaProva}");
        if(NotaProva>=7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine($"Não Aprovado pois nota foi menor de 7 sendo a sua nota essa: {NotaFinal}");
        }
    }
    public void ReceberDados()
    {
        Console.WriteLine("Digite o seu Nome: ");
        this.Nome = Console.ReadLine();
        Console.WriteLine("Digite o Ra: ");
        this.Ra = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a sua Nota da Prova");
        this.NotaProva = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a sua Nota do trabalho: ");
        this.NotaTrabalho = double.Parse(Console.ReadLine());
    }

     

}


