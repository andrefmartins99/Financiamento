using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
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

        public FinanciamentoDeCasa(decimal montante, int prazoPagamento, double taxaJurosAnualBruta) : base(montante, prazoPagamento, taxaJurosAnualBruta)
        {

        }

        /// <summary>
        /// Converter a taxa anual em taxa mensal
        /// </summary>
        /// <returns>Retorna o valor da taxa mensal</returns>
        public override double CalcularTaxaMensal()
        {
            return Math.Pow(1 + (TaxaJurosAnualBruta + Spread), 1 / Convert.ToDouble(12)) - 1;
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
            return Montante + CalcularValorJuros();
        }
    }
}
