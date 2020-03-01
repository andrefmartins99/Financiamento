using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Fiador
    {
        private string _telefone;
        private string _nif;
        private decimal _rendimentoAnualBruto;

        public string Nome { get; set; }

        public string Morada { get; set; }

        public string Telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                if (value.Length == 9)
                {
                    _telefone = value;
                }
                else
                {
                    _telefone = "111111111";
                }
            }
        }

        public string NIF
        {
            get
            {
                return _nif;
            }
            set
            {
                if (value.Length == 9)
                {
                    _nif = value;
                }
                else
                {
                    _nif = "111111111";
                }
            }
        }

        public decimal RendimentoAnualBruto
        {
            get
            {
                return _rendimentoAnualBruto;
            }
            set
            {
                if (value > 0)
                {
                    _rendimentoAnualBruto = value;
                }
                else
                {
                    _rendimentoAnualBruto = 1;
                }
            }
        }

        public Fiador(string nome, string morada, string telefone, string nif, decimal rendimentoAnualBruto)
        {
            Nome = nome;
            Morada = morada;
            Telefone = telefone;
            NIF = nif;
            RendimentoAnualBruto = rendimentoAnualBruto;
        }
    }
}
