using System;

public class Program
{
    public static void Main()
    {
        // Exemplo de uso do sistema de hospedagem
        Pessoa hospede = new Pessoa { Nome = "Fulano", Idade = 25 };
        Suite suite = new Suite { Numero = 101, ValorDiaria = 150.0 };
        DateTime dataInicio = new DateTime(2023, 5, 1);
        DateTime dataFim = new DateTime(2023, 5, 10);

        Reserva reserva = new Reserva
        {
            Hospede = hospede,
            Suite = suite,
            DataInicio = dataInicio,
            DataFim = dataFim
        };

        Console.WriteLine($"Reserva para {reserva.QuantidadeHospedes} hóspede(s)");
        Console.WriteLine($"Valor total da reserva: R$ {reserva.ValorTotal}");
    }
}
