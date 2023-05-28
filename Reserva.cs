using System;

public class Reserva
{
    public Pessoa Hospede { get; set; }
    public Suite Suite { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public int QuantidadeHospedes => CalcularQuantidadeHospedes();
    public double ValorTotal => CalcularValorTotal();

    private int CalcularQuantidadeHospedes()
    {
        if (Hospede != null && Hospede.Idade >= 18)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }


    private double CalcularValorTotal()
    {
        int diasReserva = (int)(DataFim - DataInicio).TotalDays;
        double valorDiaria = Suite.ValorDiaria;

        double valorTotal = diasReserva * valorDiaria;

        if (diasReserva > 10)
        {
            valorTotal *= 0.9; // Aplicar desconto de 10% para reservas com mais de 10 dias
        }

        return valorTotal;
    }
}
