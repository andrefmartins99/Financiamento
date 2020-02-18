using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Fiador
    {
        public string Nome { get; set; }

        public string Morada { get; set; }

        public string Telefone
        {
            get
            {
                return Telefone;
            }
            set
            {
                if (value.Length == 9)
                {
                    Telefone = value;
                }
                else
                {
                    Telefone = string.Empty;
                }
            }
        }

        public string NIF
        {
            get
            {
                return NIF;
            }
            set
            {
                if (value.Length == 9)
                {
                    NIF = value;
                }
                else
                {
                    NIF = string.Empty;
                }
            }
        }

        public decimal RendimentoAnualBruto
        {
            get
            {
                return RendimentoAnualBruto;
            }
            set
            {
                if (value > 0)
                {
                    RendimentoAnualBruto = value;
                }
                else
                {
                    RendimentoAnualBruto = 1;
                }
            }
        }
    }
}
