using System;

namespace Menu
{
    public class OutrosFinanciamentos : Financiamento
    {
        private decimal _valorAAmortizar;

        public decimal ValorAAmortizar
        {
            get
            {
                return _valorAAmortizar;
            }
            set
            {
                if (value <= Montante)
                {
                    _valorAAmortizar = value;
                }
                else
                {
                    _valorAAmortizar = Montante;
                }

            }
        }

        public decimal ComissaoAbertura
        {
            get
            {
                return 0.01m;
            }
        }

        public decimal TaxaAmortizacaoAntecipada
        {
            get
            {
                return 0.0005m;
            }
        }

        public OutrosFinanciamentos(decimal montante, int prazoPagamento, double taxaJurosAnualBruta) : base(montante, prazoPagamento, taxaJurosAnualBruta)
        {

        }

        //Calcular comissão de abertura
        public decimal CalcularComissaoAbertura()
        {
            return Montante * ComissaoAbertura;
        }

        //Calcular o valor a pagar se se pretender amortizar x do montante a financiar
        public decimal CalcularValorAAmortizarComTaxaAmortizacao(decimal ValorAAmortizar)
        {
            return ValorAAmortizar + (ValorAAmortizar * TaxaAmortizacaoAntecipada);
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
            return Montante * Convert.ToDecimal(CalcularCoeficienteFinanciamento());
        }

        //Calcular o valor da primeira prestação
        public decimal CalcularPrimeiraPrestacao()
        {
            return CalcularPrestacoes() + CalcularComissaoAbertura();
        }

        //Calcular o valor de juros a pagar
        public override decimal CalcularValorJuros()
        {
            return CalcularPrestacoes() * PrazoPagamento - Montante;
        }

        //Calcular o valor total a pagar
        public override decimal CalcularValorTotal()
        {
            return Montante + CalcularComissaoAbertura() + CalcularValorJuros();
        }
    }
}
