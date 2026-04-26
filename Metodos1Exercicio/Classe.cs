using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

internal class AlunoNotas
{
       public int Ra {get;set;}
       public string nome {get;set;}
       public double NotaProva {get;set;}
       public double NotaTrabalho {get;set;}
       public double NotaFinal {get;set;}
       public void ReceberValores()
       {
              Console.WriteLine("Ra: ");
              this.Ra = int.Parse(Console.ReadLine());
              Console.WriteLine("Nome: ");
              this.nome = Console.ReadLine();
              Console.WriteLine("Nota Prova: ");
              this.NotaProva = double.Parse(Console.ReadLine());
              Console.WriteLine("Nota Trabalho: ");
              this.NotaTrabalho = double.Parse(Console.ReadLine());
             
       }
       public double CalculaMediaNota()
       {
              return this.NotaFinal = (NotaProva+NotaTrabalho)/2;
       }  
       public bool AlunoCondicaoNotaFinal()
       {
              if(NotaFinal>=7)
                     
                     return true;
              else
                     Console.WriteLine("Reprovado");
                     return false;
                     
       }
                   
       public void MostraValorNota()
       {
              Console.Write("Valor da nota final: "+NotaFinal);
       }
}
