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

        /// <summary>
        /// Calcular comissão de abertura
        /// </summary>
        /// <returns>Retorna o valor da comissão de abertura</returns>
        public decimal CalcularComissaoAbertura()
        {
            return Montante * ComissaoAbertura;
        }

        /// <summary>
        /// Calcular o valor a pagar se se pretender amortizar x do montante a financiar
        /// </summary>
        /// <param name="ValorAAmortizar">Valor que se pretende amortizar</param>
        /// <returns>Retorna o valor a pagar se se pretender amortizar x do montante a financiar</returns>
        public decimal CalcularValorAAmortizarComTaxaAmortizacao(decimal ValorAAmortizar)
        {
            return ValorAAmortizar + (ValorAAmortizar * TaxaAmortizacaoAntecipada);
        }

        /// <summary>
        /// Converter a taxa anual em taxa mensal
        /// </summary>
        /// <returns>Retorna o valor da taxa mensal</returns>
        public override double CalcularTaxaMensal()
        {
            return Math.Pow(1 + TaxaJurosAnualBruta, 1 / Convert.ToDouble(12)) - 1;
        }

        /// <summary>
        /// Calcular o coeficiente de financiamento
        /// </summary>
        /// <returns>Retorna o valor do coeficiente de financiamento</returns>
        public override double CalcularCoeficienteFinanciamento()
        {
            double taxaMensal = CalcularTaxaMensal();

            return taxaMensal / (1 - (1 / (Math.Pow(1 + taxaMensal, PrazoPagamento))));
        }

        /// <summary>
        /// Calcular as prestações mensais
        /// </summary>
        /// <returns>Retorna o valor das prestações mensais</returns>
        public override decimal CalcularPrestacoes()
        {
            return Montante * Convert.ToDecimal(CalcularCoeficienteFinanciamento());
        }

        /// <summary>
        /// Calcular o valor da primeira prestação
        /// </summary>
        /// <returns>Retorna o valor da primeira prestações</returns>
        public decimal CalcularPrimeiraPrestacao()
        {
            return CalcularPrestacoes() + CalcularComissaoAbertura();
        }

        /// <summary>
        /// Calcular o valor de juros a pagar
        /// </summary>
        /// <returns>Retorna o valor de juros a pagar</returns>
        public override decimal CalcularValorJuros()
        {
            return CalcularPrestacoes() * PrazoPagamento - Montante;
        }

        /// <summary>
        /// Calcular o valor total a pagar
        /// </summary>
        /// <returns>Retorna o valor total a pagar</returns>
        public override decimal CalcularValorTotal()
        {
            return Montante + CalcularComissaoAbertura() + CalcularValorJuros();
        }
    }
}
