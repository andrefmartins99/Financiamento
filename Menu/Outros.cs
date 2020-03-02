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
    public partial class Outros : Form
    {
        public OutrosFinanciamentos OutrosFinanciamentos { get; set; }

        public Menu Menu { get; set; }

        public Outros(Menu menu)
        {
            InitializeComponent();
            Menu = menu;
        }

        private void Outros_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu.mudarEstadoButoesParaTrue();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu.mudarEstadoButoesParaTrue();
            this.Close();
        }

        //Verificar se caracteres inseridos são apenas números
        private void txtValorAAmortizar_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtValorAAmortizar.TextLength; i++)
            {
                if (!(char.IsDigit(txtValorAAmortizar.Text[i])))
                {
                    txtValorAAmortizar.Text = string.Empty;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Verificar se os campos a preencher estão vazios
            if (string.IsNullOrEmpty(txtMontante.Text) || (string.IsNullOrEmpty(txtPrazo.Text)) || string.IsNullOrEmpty(txtTaxa.Text))
            {
                MessageBox.Show("Todos os campos têm de estar preenchidos!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Verificar se o prazo de pagamento é igual a 0
            if (Convert.ToInt32(txtPrazo.Text) == 0)
            {
                MessageBox.Show("O valor mínimo para o prazo é 1 mês!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal montante = Convert.ToDecimal(txtMontante.Text);
            int prazo = Convert.ToInt32(txtPrazo.Text);
            double taxa = Convert.ToDouble(txtTaxa.Text);

            OutrosFinanciamentos = new OutrosFinanciamentos(montante, prazo, taxa);

            //Cálculos
            txtPrimeiraPrestacao.Text = Math.Round(OutrosFinanciamentos.CalcularPrimeiraPrestacao(), 2).ToString() + " €";
            txtPrestacoes.Text = Math.Round(OutrosFinanciamentos.CalcularPrestacoes(), 2).ToString() + " €";
            txtComissaoAbertura.Text = Math.Round(OutrosFinanciamentos.CalcularComissaoAbertura(), 2).ToString() + " €";
            txtValorJuros.Text = Math.Round(OutrosFinanciamentos.CalcularValorJuros(), 2).ToString() + " €";
            txtTotalComJuros.Text = Math.Round(OutrosFinanciamentos.CalcularValorTotal(), 2).ToString() + " €";

            btnAmortizar.Enabled = true;
            txtValorAAmortizar.Enabled = true;
        }

        private void btnAmortizar_Click(object sender, EventArgs e)
        {
            //Verificar se o campo a preencher está vazio
            if (string.IsNullOrEmpty(txtValorAAmortizar.Text))
            {
                MessageBox.Show("Todos os campos têm de estar preenchidos!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Verificar se o valor a amortizar é menor do que o montante a financiar
            if (Convert.ToInt32(txtValorAAmortizar.Text) > Convert.ToInt32(txtMontante.Text))
            {
                MessageBox.Show("O valor a amortizar tem de ser inferior ao montante a financiar!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal valorAAmortizar = Convert.ToDecimal(txtValorAAmortizar.Text);

            //Cálculos
            MessageBox.Show($"Para amortizar {txtValorAAmortizar.Text} € do montante pedido deve pagar {Math.Round(OutrosFinanciamentos.CalcularValorAAmortizarComTaxaAmortizacao(valorAAmortizar), 2)} €.", "Amortizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
