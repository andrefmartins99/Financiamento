using System;

namespace Menu
{
    public class FinanciamentoDeCarro : Financiamento
    {
        public decimal ComissaoAbertura
        {
            get
            {
                return 0.0001m;
            }
        }

        public decimal ValorResidual
        {
            get
            {
                return 0.01m;
            }
        }

        public FinanciamentoDeCarro(decimal montante, int prazoPagamento, double taxaJurosAnualBruta) : base(montante, prazoPagamento, taxaJurosAnualBruta)
        {

        }

        //Calcular comissão de abertura
        public decimal CalcularComissaoAbertura()
        {
            return Montante * ComissaoAbertura;
        }

        //Calcular valor residual
        public decimal CalcularValorResidual()
        {
            return Montante * ValorResidual;
        }

        //Converter a taxa anual em taxa mensal
        public override double CalcularTaxaMensal()
        {
            return Math.Pow(1 + TaxaJurosAnualBruta, 1 / Convert.ToDouble(12)) - 1;
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
            return (Montante - CalcularValorResidual()) * Convert.ToDecimal(CalcularCoeficienteFinanciamento());
        }

        //Calcular o valor da primeira prestação
        public decimal CalcularPrimeiraPrestacao()
        {
            return CalcularPrestacoes() + CalcularComissaoAbertura();
        }

        //Calcular o valor de juros a pagar
        public override decimal CalcularValorJuros()
        {
            return CalcularPrestacoes() * PrazoPagamento - Montante + CalcularValorResidual();
        }

        //Calcular o valor total a pagar
        public override decimal CalcularValorTotal()
        {
            return Montante + CalcularComissaoAbertura() + CalcularValorJuros();
        }
    }
}
