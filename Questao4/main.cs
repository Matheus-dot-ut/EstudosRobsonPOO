
int op = 0;
List<Aluno> CadastroAluno = new List<Aluno>();
 
do
{
    Console.WriteLine("\n===Sistema de Cadastração===");
    Console.WriteLine(" ");
    Console.WriteLine("1 . Cadastrar um aluno (com RA único)");
    Console.WriteLine("2 . Listar todos os alunos cadastrados");
    Console.WriteLine("3 . Alterar dados de um aluno existente (localizado pelo RA)");
    Console.WriteLine("4 . Remover um aluno pelo RA");
    Console.WriteLine("5 . Encerrar o programa");
    Console.Write("Digite o numero que queira: 'Se quiser sair do programa digite 0': ");
    op = int.Parse(Console.ReadLine());
 
    switch (op)
    {
        case 1:
            CadastraAluno();
            break;
        case 2:
            ListarAlunos();
            break;
        case 3:
            AlterarAluno();
            break;
        case 4:
            RemoverAluno();
            break;
        case 5:
            Console.WriteLine("Encerrando...");
            op = 0;
            break;
        default:
            Console.WriteLine("Erro");
            break;
    }
 
} while (op != 0);
 
void CadastraAluno()
{
    Aluno _aluno = new Aluno();
    _aluno.AlunoNovo();
 
    bool RaExistente = false;
 
    foreach (Aluno a in CadastroAluno)
    {
        if (a.RA == _aluno.RA)
        {
            RaExistente = true;
            break;
        }
    }
 
    if (RaExistente)
    {
        Console.WriteLine("Já existe um aluno com esse RA.");
    }
    else
    {
        CadastroAluno.Add(_aluno);
        Console.WriteLine("Aluno cadastrado com sucesso!");
    }
}
 
void ListarAlunos()
{
    if (CadastroAluno.Count == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado.");
        return;
    }
 
    Console.WriteLine("\n--- LISTA DE ALUNOS ---");
    foreach (Aluno a in CadastroAluno)
    {
        Console.WriteLine($"RA: {a.RA} | Nome: {a.Nome} | Idade: {a.Idade}");
    }
}
 
void AlterarAluno()
{
    Console.Write("Digite o RA do aluno a alterar: ");
    string ra = Console.ReadLine();
 
    Aluno _aluno = null;
 
    foreach (Aluno a in CadastroAluno)
    {
        if (a.RA == ra)
        {
            _aluno = a;
            break;
        }
    }
 
    if (_aluno == null)
    {
        Console.WriteLine("Aluno não encontrado.");
        return;
    }
 
    Console.Write("Novo nome: ");
    _aluno.Nome = Console.ReadLine();
 
    Console.Write("Nova idade: ");
    _aluno.Idade = int.Parse(Console.ReadLine());
 
    Console.WriteLine("Dados alterados com sucesso!");
}
 
void RemoverAluno()
{
    Console.Write("Digite o RA do aluno a remover: ");
    string ra = Console.ReadLine();
 
    Aluno _aluno = null;
 
    foreach (Aluno a in CadastroAluno)
    {
        if (a.RA == ra)
        {
            _aluno = a;
            break;
        }
    }
 
    if (_aluno == null)
    {
        Console.WriteLine("Aluno não encontrado.");
        return;
    }
 
    CadastroAluno.Remove(_aluno);
    Console.WriteLine("Aluno removido com sucesso!");
}




