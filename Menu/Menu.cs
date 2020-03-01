using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Carro NovoCarro { get; set; }

        public Casa NovaCasa { get; set; }

        public Outros NovoOutros { get; set; }

        public Menu()
        {
            InitializeComponent();
        }

        //Abrir form financiamento carro
        private void btnCarro_Click(object sender, EventArgs e)
        {
            NovoCarro = new Carro(this);
            NovoCarro.Show();
            mudarEstadoButoesParaFalse();
        }

        /// <summary>
        /// Mudar estado dos botões, no menu, para false
        /// </summary>
        public void mudarEstadoButoesParaFalse()
        {
            btnCarro.Enabled = false;
            btnCasa.Enabled = false;
            btnOutros.Enabled = false;
            btnInfo.Enabled = false;
        }

        /// <summary>
        /// Mudar estado dos botões, no menu, para true
        /// </summary>
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
            NovaCasa = new Casa(this);
            NovaCasa.Show();
            mudarEstadoButoesParaFalse();
        }

        //Abrir form outros financiamnetos
        private void btnOutros_Click(object sender, EventArgs e)
        {
            NovoOutros = new Outros(this);
            NovoOutros.Show();
            mudarEstadoButoesParaFalse();
        }

        //Créditos
        private void lblInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Feito por André Martins{Environment.NewLine}Versão 1.3{Environment.NewLine}Data: 01/03/2020", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
