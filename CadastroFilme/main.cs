
internal class CadastroFilme
{
       public string titulo {get;private set;}
       public string genero {get; private set;}
       public int duracaoMinuto {get;private set;}
       public int classificacao {get;private set;}
       public void ReceberValores()
       {
              Console.Write("Escreva o titulo: ");
              this.titulo = Console.ReadLine();
              if(string.IsNullOrWhiteSpace(titulo))
              {
                     Console.Write("Não pode esta vazio");
              }
              Console.Write("Escreva o genero: ");
              this.genero = Console.ReadLine();

              if(string.IsNullOrWhiteSpace(genero))
              {
                     Console.Write("Não informado");
              }
              Console.Write("Digite a duracaio em minutos do filme: ");
              this.duracaoMinuto = int.Parse(Console.ReadLine());
              int DuracaoFinal;
              if(duracaoMinuto<=0)
              {
                     DuracaoFinal = 1;
              }
              else
              {
                     DuracaoFinal = duracaoMinuto;
              }
              Console.Write("Escreva a classificação de idade do filme: ");
              this.classificacao = int.Parse(Console.ReadLine());
              int classifcarFinal;
              if(classificacao<0)
              {
                     classifcarFinal = 0;
              }
              else
              {
                     classifcarFinal = classificacao;
              }
       
       }
       public void ExibirResumo()
       {
              Console.WriteLine($"Titulo do filme {titulo}");
              Console.WriteLine($"Genero do filme {genero}");
              Console.WriteLine($"Duracao do filme {duracaoMinuto}");
              Console.WriteLine($"Genero do filme {classificacao}");
       }
       public bool IdadeMaior(int idade)
       {
              return idade >= classificacao;
       }
       public int AlteraDuracao(int novaDuracao)
       {
              if(novaDuracao>0)
              
              novaDuracao = duracaoMinuto;
              return novaDuracao;
       }

       
       
}
