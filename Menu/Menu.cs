using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Abrir form financiamento carro
        private void btnCarro_Click(object sender, EventArgs e)
        {
            Carro novoCarro = new Carro(this);
            novoCarro.Show();
            mudarEstadoButoesParaFalse();
        }

        //Mudar estado dos botões, no menu, para false
        public void mudarEstadoButoesParaFalse()
        {
            btnCarro.Enabled = false;
            btnCasa.Enabled = false;
            btnOutros.Enabled = false;
            btnInfo.Enabled = false;
        }

        //Mudar estado dos botões, no menu, para true
        public void mudarEstadoButoesParaTrue()
        {
            btnCarro.Enabled = true;
            btnCasa.Enabled = true;
            btnOutros.Enabled = true;
            btnInfo.Enabled = true;
        }

        //Abrir form financiamento casa
        private void btnCasa_Click(object sender, EventArgs e)
        {
            Casa novaCasa = new Casa(this);
            novaCasa.Show();
            mudarEstadoButoesParaFalse();
        }

        //Abrir form outros financiamnetos
        private void btnOutros_Click(object sender, EventArgs e)
        {
            Outros novoOutros = new Outros(this);
            novoOutros.Show();
            mudarEstadoButoesParaFalse();
        }

        //Versão
        private void lblInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Feito por André Martins{Environment.NewLine}Versão 1.3{Environment.NewLine}Data: 15/02/2020", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
