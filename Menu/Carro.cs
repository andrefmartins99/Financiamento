using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Biblioteca;

namespace Menu
{
    public partial class Carro : Form
    {
        public FinanciamentoDeCarro FinanciamentoDeCarro { get; set; }

        public Menu Menu { get; set; }

        public Carro(Menu menu)
        {
            InitializeComponent();
            Menu = menu;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu.mudarEstadoButoesParaTrue();
            this.Close();
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

            //Verificar se o prazo de pagamento é menor de 60 meses
            if (Convert.ToInt32(txtPrazo.Text) > 60)
            {
                MessageBox.Show("O valor máximo para o prazo é 60 meses!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal montante = Convert.ToDecimal(txtMontante.Text);
            int prazo = Convert.ToInt32(txtPrazo.Text);
            double taxa = Convert.ToDouble(txtTaxa.Text);

            FinanciamentoDeCarro = new FinanciamentoDeCarro(montante, prazo, taxa);

            //Cálculos
            txtPrimeiraPrestacao.Text = Math.Round(FinanciamentoDeCarro.CalcularPrimeiraPrestacao(), 2).ToString() + " €";
            txtPrestacoes.Text = Math.Round(FinanciamentoDeCarro.CalcularPrestacoes(), 2).ToString() + " €";
            txtComissaoAbertura.Text = Math.Round(FinanciamentoDeCarro.CalcularComissaoAbertura(), 2).ToString() + " €";
            txtValorJuros.Text = Math.Round(FinanciamentoDeCarro.CalcularValorJuros(), 2).ToString() + " €";
            txtTotalComJuros.Text = Math.Round(FinanciamentoDeCarro.CalcularValorTotal(), 2).ToString() + " €";
            txtValorResidual.Text = Math.Round(FinanciamentoDeCarro.CalcularValorResidual(), 2).ToString() + " €";
        }

        private void Carro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu.mudarEstadoButoesParaTrue();
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
