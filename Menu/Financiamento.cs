namespace Menu
{
    public abstract class Financiamento
    {
        private decimal _montante;
        private int _prazoPagamento;
        private double _taxaJurosAnualBruta;

        public decimal Montante
        {
            get
            {
                return _montante;
            }
            set
            {
                if (value > 0)
                {
                    _montante = value;
                }
                else
                {
                    _montante = 1;
                }
            }
        }

        public int PrazoPagamento
        {
            get
            {
                return _prazoPagamento;
            }
            set
            {
                if (value > 0)
                {
                    _prazoPagamento = value;
                }
                else
                {
                    _prazoPagamento = 1;
                }
            }
        }

        public double TaxaJurosAnualBruta
        {
            get
            {
                return _taxaJurosAnualBruta;
            }
            set
            {
                if (value > 0)
                {
                    _taxaJurosAnualBruta = value / 100;
                }
                else
                {
                    _taxaJurosAnualBruta = 1 / 100;
                }
            }
        }

        public Financiamento(decimal montante, int prazoPagamento, double taxaJurosAnualBruta)
        {
            Montante = montante;
            PrazoPagamento = prazoPagamento;
            TaxaJurosAnualBruta = taxaJurosAnualBruta;
        }

        public abstract double CalcularTaxaMensal();

        public abstract double CalcularCoeficienteFinanciamento();

        public abstract decimal CalcularPrestacoes();

        public abstract decimal CalcularValorJuros();

        public abstract decimal CalcularValorTotal();
    }
}
