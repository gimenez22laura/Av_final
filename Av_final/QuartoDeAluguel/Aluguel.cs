namespace QuartoDeAluguel
{
    class Quarto
    {
        public double ValorDaDiaria;
        public int PeriodoDaHospedagem;
        public double Valor()
        {
            return ValorDaDiaria * PeriodoDaHospedagem;
        }

    }
}