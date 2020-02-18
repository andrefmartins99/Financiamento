using System;

namespace Menu
{
    public class FinanciamentoDeCasa : Financiamento
    {
        public double Spread
        {
            get
            {
                return 0.015;
            }
        }

        public Fiador Fiador { get; set; }

        public FinanciamentoDeCasa(decimal montante, int prazoPagamento, double taxaJurosAnualBruta) : base(montante, prazoPagamento, taxaJurosAnualBruta)
        {

        }

        //Converter a taxa anual em taxa mensal
        public override double CalcularTaxaMensal()
        {
            return Math.Pow(1 + (TaxaJurosAnualBruta + Spread), 1 / Convert.ToDouble(12)) - 1;
        }

        //Calcular o coeficiente de financiamento
        public override double CalcularCoeficienteFinanciamento()
        {
            double taxaMensal = CalcularTaxaMensal();

            return taxaMensal / (1 - (1 / (Math.Pow(1 + taxaMensal, PrazoPagamento))));
        }

        //Calcular as prestações
        public override decimal CalcularPrestacoes()
        {
            return Montante * Convert.ToDecimal(CalcularCoeficienteFinanciamento());
        }

        //Calcular o valor de juros a pagar
        public override decimal CalcularValorJuros()
        {
            return CalcularPrestacoes() * PrazoPagamento - Montante;
        }

        //Calcular o valor total a pagar
        public override decimal CalcularValorTotal()
        {
            return Montante + CalcularValorJuros();
        }

    }
}
