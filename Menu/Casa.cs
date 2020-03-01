using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Menu
{
    public partial class Casa : Form
    {
        public FinanciamentoDeCasa FinanciamentoDeCasa { get; set; }

        public Fiador Fiador { get; set; }

        public Menu Menu { get; set; }

        public Casa(Menu menu)
        {
            InitializeComponent();
            Menu = menu;
        }

        private void Casa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu.mudarEstadoButoesParaTrue();
        }

        //Verificar se caracteres inseridos são apenas números
        private void txtMontante_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtMontante.TextLength; i++)
            {
                if (!(char.IsDigit(txtMontante.Text[i])))
                {
                    txtMontante.Text = string.Empty;
                }
            }
        }

        //Verificar se caracteres inseridos são apenas números
        private void txtPrazo_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtPrazo.TextLength; i++)
            {
                if (!(char.IsDigit(txtPrazo.Text[i])))
                {
                    txtPrazo.Text = string.Empty;
                }
            }
        }

        //Verificar se caracteres inseridos são apenas números
        private void txtTaxa_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtTaxa.TextLength; i++)
            {
                if (!(char.IsDigit(txtTaxa.Text[i])))
                {
                    txtTaxa.Text = string.Empty;
                }
            }
        }

        //Verificar se caracteres inseridos são apenas letras ou espaços
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtNome.TextLength; i++)
            {
                if (!(char.IsLetter(txtNome.Text[i]) || txtNome.Text[i] == 32))
                {
                    txtNome.Text = string.Empty;
                }
            }
        }

        //Verificar se caracteres inseridos são apenas números
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtTelefone.TextLength; i++)
            {
                if (!(char.IsDigit(txtTelefone.Text[i])))
                {
                    txtTelefone.Text = string.Empty;
                }
            }
        }

        //Verificar se caracteres inseridos são apenas números
        private void txtNIF_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtNIF.TextLength; i++)
            {
                if (!(char.IsDigit(txtNIF.Text[i])))
                {
                    txtNIF.Text = string.Empty;
                }
            }
        }

        //Verificar se caracteres inseridos são apenas números
        private void txtRendimento_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtRendimento.TextLength; i++)
            {
                if (!(char.IsDigit(txtRendimento.Text[i])))
                {
                    txtRendimento.Text = string.Empty;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Verificar se os campos a preencher estão vazios
            if (string.IsNullOrEmpty(txtMontante.Text) || (string.IsNullOrEmpty(txtPrazo.Text)) || string.IsNullOrEmpty(txtTaxa.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtMorada.Text) || string.IsNullOrEmpty(txtTelefone.Text) || string.IsNullOrEmpty(txtNIF.Text) || string.IsNullOrEmpty(txtRendimento.Text))
            {
                MessageBox.Show("Todos os campos têm de estar preenchidos!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Verificar se as caixas de texto do telefone e NIF têm apenas 9 caracteres
            if (txtTelefone.Text.Length != 9 || txtNIF.Text.Length != 9)
            {
                MessageBox.Show("Ambos os campos do telefone e do NIF devem ter 9 carateres!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNome.Text;
            string morada = txtMorada.Text;
            string telefone = txtTelefone.Text;
            string nif = txtNIF.Text;
            decimal rendimento = Convert.ToDecimal(txtRendimento.Text);

            Fiador = new Fiador(nome, morada, telefone, nif, rendimento);

            decimal montante = Convert.ToDecimal(txtMontante.Text);
            int prazo = Convert.ToInt32(txtPrazo.Text);
            double taxa = Convert.ToDouble(txtTaxa.Text);

            FinanciamentoDeCasa = new FinanciamentoDeCasa(montante, prazo, taxa);

            //Cálculos
            txtPrestacoes.Text = Math.Round(FinanciamentoDeCasa.CalcularPrestacoes(), 2).ToString() + " €";
            txtValorJuros.Text = Math.Round(FinanciamentoDeCasa.CalcularValorJuros(), 2).ToString() + " €";
            txtTotalComJuros.Text = Math.Round(FinanciamentoDeCasa.CalcularValorTotal(), 2).ToString() + " €";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu.mudarEstadoButoesParaTrue();
            this.Close();
        }
    }
}
