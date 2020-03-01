using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
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

        /// <summary>
        /// Calcular comissão de abertura
        /// </summary>
        /// <returns>Retorna o valor da comissão de abertura</returns>
        public decimal CalcularComissaoAbertura()
        {
            return Montante * ComissaoAbertura;
        }

        /// <summary>
        /// Calcular valor residual
        /// </summary>
        /// <returns>Retorna o valor do valor residual</returns>
        public decimal CalcularValorResidual()
        {
            return Montante * ValorResidual;
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
            return (Montante - CalcularValorResidual()) * Convert.ToDecimal(CalcularCoeficienteFinanciamento());
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
            return CalcularPrestacoes() * PrazoPagamento - Montante + CalcularValorResidual();
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
