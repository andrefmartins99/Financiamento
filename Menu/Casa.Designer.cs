namespace Menu
{
    partial class Casa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Casa));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.lblMontante = new System.Windows.Forms.Label();
            this.lblNomeFiador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblMorada = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.txtRendimento = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtTotalComJuros = new System.Windows.Forms.TextBox();
            this.lblTotalComJuros = new System.Windows.Forms.Label();
            this.txtPrestacoes = new System.Windows.Forms.TextBox();
            this.lblPrestacoes = new System.Windows.Forms.Label();
            this.txtValorJuros = new System.Windows.Forms.TextBox();
            this.lblValorJuros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(543, 55);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(168, 69);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTaxa
            // 
            this.txtTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxa.Location = new System.Drawing.Point(321, 116);
            this.txtTaxa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(171, 30);
            this.txtTaxa.TabIndex = 13;
            this.txtTaxa.TextChanged += new System.EventHandler(this.txtTaxa_TextChanged);
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxa.Location = new System.Drawing.Point(8, 118);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(293, 25);
            this.lblTaxa.TabIndex = 12;
            this.lblTaxa.Text = "Taxa de Juros Anual Bruta (%) :";
            // 
            // txtPrazo
            // 
            this.txtPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrazo.Location = new System.Drawing.Point(321, 74);
            this.txtPrazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(171, 30);
            this.txtPrazo.TabIndex = 11;
            this.txtPrazo.TextChanged += new System.EventHandler(this.txtPrazo_TextChanged);
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo.Location = new System.Drawing.Point(20, 78);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(278, 25);
            this.lblPrazo.TabIndex = 10;
            this.lblPrazo.Text = "Prazo de Pagamento (meses):";
            // 
            // txtMontante
            // 
            this.txtMontante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontante.Location = new System.Drawing.Point(321, 33);
            this.txtMontante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontante.Name = "txtMontante";
            this.txtMontante.Size = new System.Drawing.Size(171, 30);
            this.txtMontante.TabIndex = 9;
            this.txtMontante.TextChanged += new System.EventHandler(this.txtMontante_TextChanged);
            // 
            // lblMontante
            // 
            this.lblMontante.AutoSize = true;
            this.lblMontante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontante.Location = new System.Drawing.Point(107, 36);
            this.lblMontante.Name = "lblMontante";
            this.lblMontante.Size = new System.Drawing.Size(194, 25);
            this.lblMontante.TabIndex = 8;
            this.lblMontante.Text = "Montante a financiar:";
            // 
            // lblNomeFiador
            // 
            this.lblNomeFiador.AutoSize = true;
            this.lblNomeFiador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFiador.Location = new System.Drawing.Point(791, 55);
            this.lblNomeFiador.Name = "lblNomeFiador";
            this.lblNomeFiador.Size = new System.Drawing.Size(70, 25);
            this.lblNomeFiador.TabIndex = 15;
            this.lblNomeFiador.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(951, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Registar Fiador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(869, 52);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(356, 30);
            this.txtNome.TabIndex = 17;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorada.Location = new System.Drawing.Point(775, 100);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(85, 25);
            this.lblMorada.TabIndex = 18;
            this.lblMorada.Text = "Morada:";
            // 
            // txtMorada
            // 
            this.txtMorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorada.Location = new System.Drawing.Point(869, 96);
            this.txtMorada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(356, 30);
            this.txtMorada.TabIndex = 19;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(764, 139);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(95, 25);
            this.lblTelefone.TabIndex = 20;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(869, 135);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefone.MaxLength = 9;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(167, 30);
            this.txtTelefone.TabIndex = 21;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(869, 172);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(167, 30);
            this.txtNIF.TabIndex = 23;
            this.txtNIF.TextChanged += new System.EventHandler(this.txtNIF_TextChanged);
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(812, 176);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(49, 25);
            this.lblNIF.TabIndex = 22;
            this.lblNIF.Text = "NIF:";
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendimento.Location = new System.Drawing.Point(613, 215);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(229, 25);
            this.lblRendimento.TabIndex = 24;
            this.lblRendimento.Text = "Rendimento Anual Bruto:";
            // 
            // txtRendimento
            // 
            this.txtRendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRendimento.Location = new System.Drawing.Point(869, 212);
            this.txtRendimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.Size = new System.Drawing.Size(167, 30);
            this.txtRendimento.TabIndex = 25;
            this.txtRendimento.TextChanged += new System.EventHandler(this.txtRendimento_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(1175, 370);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(137, 62);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtTotalComJuros
            // 
            this.txtTotalComJuros.Enabled = false;
            this.txtTotalComJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalComJuros.Location = new System.Drawing.Point(780, 294);
            this.txtTotalComJuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalComJuros.Name = "txtTotalComJuros";
            this.txtTotalComJuros.Size = new System.Drawing.Size(167, 30);
            this.txtTotalComJuros.TabIndex = 30;
            // 
            // lblTotalComJuros
            // 
            this.lblTotalComJuros.AutoSize = true;
            this.lblTotalComJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComJuros.Location = new System.Drawing.Point(608, 299);
            this.lblTotalComJuros.Name = "lblTotalComJuros";
            this.lblTotalComJuros.Size = new System.Drawing.Size(158, 25);
            this.lblTotalComJuros.TabIndex = 29;
            this.lblTotalComJuros.Text = "Total com Juros:";
            // 
            // txtPrestacoes
            // 
            this.txtPrestacoes.Enabled = false;
            this.txtPrestacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrestacoes.Location = new System.Drawing.Point(424, 294);
            this.txtPrestacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrestacoes.Name = "txtPrestacoes";
            this.txtPrestacoes.Size = new System.Drawing.Size(161, 30);
            this.txtPrestacoes.TabIndex = 28;
            // 
            // lblPrestacoes
            // 
            this.lblPrestacoes.AutoSize = true;
            this.lblPrestacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestacoes.Location = new System.Drawing.Point(301, 298);
            this.lblPrestacoes.Name = "lblPrestacoes";
            this.lblPrestacoes.Size = new System.Drawing.Size(116, 25);
            this.lblPrestacoes.TabIndex = 27;
            this.lblPrestacoes.Text = "Prestações:";
            // 
            // txtValorJuros
            // 
            this.txtValorJuros.Enabled = false;
            this.txtValorJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorJuros.Location = new System.Drawing.Point(587, 358);
            this.txtValorJuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorJuros.Name = "txtValorJuros";
            this.txtValorJuros.Size = new System.Drawing.Size(167, 30);
            this.txtValorJuros.TabIndex = 32;
            // 
            // lblValorJuros
            // 
            this.lblValorJuros.AutoSize = true;
            this.lblValorJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorJuros.Location = new System.Drawing.Point(463, 362);
            this.lblValorJuros.Name = "lblValorJuros";
            this.lblValorJuros.Size = new System.Drawing.Size(118, 25);
            this.lblValorJuros.TabIndex = 31;
            this.lblValorJuros.Text = "Valor Juros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Spread (1,5%)";
            // 
            // Casa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorJuros);
            this.Controls.Add(this.lblValorJuros);
            this.Controls.Add(this.txtTotalComJuros);
            this.Controls.Add(this.lblTotalComJuros);
            this.Controls.Add(this.txtPrestacoes);
            this.Controls.Add(this.lblPrestacoes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtRendimento);
            this.Controls.Add(this.lblRendimento);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomeFiador);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.txtMontante);
            this.Controls.Add(this.lblMontante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1342, 479);
            this.Name = "Casa";
            this.Text = "Casa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Casa_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.TextBox txtPrazo;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.TextBox txtMontante;
        private System.Windows.Forms.Label lblMontante;
        private System.Windows.Forms.Label lblNomeFiador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label lblRendimento;
        private System.Windows.Forms.TextBox txtRendimento;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtTotalComJuros;
        private System.Windows.Forms.Label lblTotalComJuros;
        private System.Windows.Forms.TextBox txtPrestacoes;
        private System.Windows.Forms.Label lblPrestacoes;
        private System.Windows.Forms.TextBox txtValorJuros;
        private System.Windows.Forms.Label lblValorJuros;
        private System.Windows.Forms.Label label3;
    }
}