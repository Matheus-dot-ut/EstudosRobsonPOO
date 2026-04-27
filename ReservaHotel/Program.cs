public class ReservaHotel
{
    public string NomeHospede;
    public int NumeroQuarto;
    public int QuantidadeDiarias;
    public double ValorDiaria;
    public string Status;

    public ReservaHotel(string nome, int quarto)
    {
        if (nome == "")
            NomeHospede = "Hóspede não informado";
        else
            NomeHospede = nome;

        if (quarto <= 0)
            NumeroQuarto = 1;
        else
            NumeroQuarto = quarto;

        QuantidadeDiarias = 1;
        ValorDiaria = 50;
        Status = "Ativa";
    }

    public ReservaHotel(string nome, int quarto, int diarias, double valorDiaria)
    {
        if (nome == "")
            NomeHospede = "Hóspede não informado";
        else
            NomeHospede = nome;

        if (quarto <= 0)
            NumeroQuarto = 1;
        else
            NumeroQuarto = quarto;

        if (diarias <= 0)
            QuantidadeDiarias = 1;
        else
            QuantidadeDiarias = diarias;

        if (valorDiaria <= 0)
            ValorDiaria = 50;
        else
            ValorDiaria = valorDiaria;

        Status = "Ativa";
    }

    public double CalcularTotal()
    {
        return QuantidadeDiarias * ValorDiaria;
    }

    public void ExibirReserva()
    {
        Console.WriteLine("Hóspede: " + NomeHospede);
        Console.WriteLine("Quarto: " + NumeroQuarto);
        Console.WriteLine("Diárias: " + QuantidadeDiarias);
        Console.WriteLine("Valor da diária: R$" + ValorDiaria);
        Console.WriteLine("Total: R$" + CalcularTotal());
        Console.WriteLine("Status: " + Status);
    }

    public void AdicionarDiarias(int quantidade)
    {
        if (quantidade > 0)
            QuantidadeDiarias += quantidade;
    }

    public void CancelarReserva()
    {
        Status = "Cancelada";
    }

    public void ReativarReserva()
    {
        Status = "Ativa";
    }
}
