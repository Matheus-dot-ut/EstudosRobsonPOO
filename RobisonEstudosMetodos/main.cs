using System.Runtime.CompilerServices;

Aluno aluno = new Aluno();
aluno.ReceberDadosAluno();
aluno.CalcularMedia();
aluno.ImprimirResultado();

ContaBancaria conta = new ContaBancaria();
conta.ReceberDadosConta();
conta.Depositar();
conta.Sacar();
conta.MostrarSaldo();

Produto produto = new Produto();
produto.ReceberDadosProduto();
produto.AdicionarProdutoEstoque();
produto.RemoverProdutoEstoque();
produto.MostrarProduto();

CalculadoraDeSalarioFuncionario F = new CalculadoraDeSalarioFuncionario();
F.ReceberDadosFuncionario;
F.CalculaAumento;
F.CalculoDescontoFuncionario;
F.ImprimirDadosFuncionalSalarial;

Hospede hospede = new Hospede();
hospede.ReceberDadosHospede;
hospede.MostraDaodsHospede;
Console.WriteLine("Dejesa troca o telefone do hospede (s/n): ");
string opcao = Console.ReadLine();
if(opcao.ToLower()=="s");
{
       Console.WriteLine("Digite o novo telefone:");
       string TrocaTelefone = Console.ReadLine();
       hospede.AtualizaTelefone(TrocaTelefone);
}

hospede.MostraDaodsHospede;

Reservas reserva = new Reservas();
reserva.ReceberDadosReserva;
reserva.MostrarDadosReserva;
Console.WriteLine("Deseja aplica o desconto (s/n): ");
string opc = Console.ReadLine();
if(opc.ToLower()=="s");
{
       Console.WriteLine("DIgite o desconto a ser aplicado: ");
       string AdicionaDesconto = Console.ReadLine();
       reserva.CalcularDescontoReserva(AdicionaDesconto);
}
reserva.MostrarDadosReserva;
Console.WriteLine("Termino Codigo");

