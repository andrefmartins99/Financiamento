namespace Menu
{
    partial class Outros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Outros));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.txtPrazo = new System.Windows.Forms.TextBox();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.txtMontante = new System.Windows.Forms.TextBox();
            this.lblMontante = new System.Windows.Forms.Label();
            this.txtComissaoAbertura = new System.Windows.Forms.TextBox();
            this.lblComissaoAbertura = new System.Windows.Forms.Label();
            this.txtPrestacoes = new System.Windows.Forms.TextBox();
            this.lblPrestacoes = new System.Windows.Forms.Label();
            this.txtPrimeiraPrestacao = new System.Windows.Forms.TextBox();
            this.lblPrimeiraPrestacao = new System.Windows.Forms.Label();
            this.txtTotalComJuros = new System.Windows.Forms.TextBox();
            this.lblTotalComJuros = new System.Windows.Forms.Label();
            this.txtValorJuros = new System.Windows.Forms.TextBox();
            this.lblValorJuros = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorAAmortizar = new System.Windows.Forms.TextBox();
            this.btnAmortizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(560, 58);
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
            this.txtTaxa.Location = new System.Drawing.Point(339, 118);
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
            this.lblTaxa.Location = new System.Drawing.Point(25, 121);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(293, 25);
            this.lblTaxa.TabIndex = 12;
            this.lblTaxa.Text = "Taxa de Juros Anual Bruta (%) :";
            // 
            // txtPrazo
            // 
            this.txtPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrazo.Location = new System.Drawing.Point(339, 76);
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
            this.lblPrazo.Location = new System.Drawing.Point(37, 80);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(278, 25);
            this.lblPrazo.TabIndex = 10;
            this.lblPrazo.Text = "Prazo de Pagamento (meses):";
            // 
            // txtMontante
            // 
            this.txtMontante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontante.Location = new System.Drawing.Point(339, 36);
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
            this.lblMontante.Location = new System.Drawing.Point(124, 38);
            this.lblMontante.Name = "lblMontante";
            this.lblMontante.Size = new System.Drawing.Size(194, 25);
            this.lblMontante.TabIndex = 8;
            this.lblMontante.Text = "Montante a financiar:";
            // 
            // txtComissaoAbertura
            // 
            this.txtComissaoAbertura.Enabled = false;
            this.txtComissaoAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissaoAbertura.Location = new System.Drawing.Point(236, 336);
            this.txtComissaoAbertura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComissaoAbertura.Name = "txtComissaoAbertura";
            this.txtComissaoAbertura.Size = new System.Drawing.Size(161, 30);
            this.txtComissaoAbertura.TabIndex = 20;
            // 
            // lblComissaoAbertura
            // 
            this.lblComissaoAbertura.AutoSize = true;
            this.lblComissaoAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissaoAbertura.Location = new System.Drawing.Point(15, 340);
            this.lblComissaoAbertura.Name = "lblComissaoAbertura";
            this.lblComissaoAbertura.Size = new System.Drawing.Size(210, 25);
            this.lblComissaoAbertura.TabIndex = 19;
            this.lblComissaoAbertura.Text = "Comissão de abertura:";
            // 
            // txtPrestacoes
            // 
            this.txtPrestacoes.Enabled = false;
            this.txtPrestacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrestacoes.Location = new System.Drawing.Point(236, 294);
            this.txtPrestacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrestacoes.Name = "txtPrestacoes";
            this.txtPrestacoes.Size = new System.Drawing.Size(161, 30);
            this.txtPrestacoes.TabIndex = 18;
            // 
            // lblPrestacoes
            // 
            this.lblPrestacoes.AutoSize = true;
            this.lblPrestacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestacoes.Location = new System.Drawing.Point(113, 297);
            this.lblPrestacoes.Name = "lblPrestacoes";
            this.lblPrestacoes.Size = new System.Drawing.Size(116, 25);
            this.lblPrestacoes.TabIndex = 17;
            this.lblPrestacoes.Text = "Prestações:";
            // 
            // txtPrimeiraPrestacao
            // 
            this.txtPrimeiraPrestacao.Enabled = false;
            this.txtPrimeiraPrestacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeiraPrestacao.Location = new System.Drawing.Point(236, 249);
            this.txtPrimeiraPrestacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrimeiraPrestacao.Name = "txtPrimeiraPrestacao";
            this.txtPrimeiraPrestacao.Size = new System.Drawing.Size(161, 30);
            this.txtPrimeiraPrestacao.TabIndex = 16;
            // 
            // lblPrimeiraPrestacao
            // 
            this.lblPrimeiraPrestacao.AutoSize = true;
            this.lblPrimeiraPrestacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiraPrestacao.Location = new System.Drawing.Point(43, 252);
            this.lblPrimeiraPrestacao.Name = "lblPrimeiraPrestacao";
            this.lblPrimeiraPrestacao.Size = new System.Drawing.Size(182, 25);
            this.lblPrimeiraPrestacao.TabIndex = 15;
            this.lblPrimeiraPrestacao.Text = "Primeira Prestação:";
            // 
            // txtTotalComJuros
            // 
            this.txtTotalComJuros.Enabled = false;
            this.txtTotalComJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalComJuros.Location = new System.Drawing.Point(573, 297);
            this.txtTotalComJuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalComJuros.Name = "txtTotalComJuros";
            this.txtTotalComJuros.Size = new System.Drawing.Size(167, 30);
            this.txtTotalComJuros.TabIndex = 24;
            // 
            // lblTotalComJuros
            // 
            this.lblTotalComJuros.AutoSize = true;
            this.lblTotalComJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComJuros.Location = new System.Drawing.Point(409, 300);
            this.lblTotalComJuros.Name = "lblTotalComJuros";
            this.lblTotalComJuros.Size = new System.Drawing.Size(158, 25);
            this.lblTotalComJuros.TabIndex = 23;
            this.lblTotalComJuros.Text = "Total com Juros:";
            // 
            // txtValorJuros
            // 
            this.txtValorJuros.Enabled = false;
            this.txtValorJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorJuros.Location = new System.Drawing.Point(573, 252);
            this.txtValorJuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorJuros.Name = "txtValorJuros";
            this.txtValorJuros.Size = new System.Drawing.Size(167, 30);
            this.txtValorJuros.TabIndex = 22;
            // 
            // lblValorJuros
            // 
            this.lblValorJuros.AutoSize = true;
            this.lblValorJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorJuros.Location = new System.Drawing.Point(449, 256);
            this.lblValorJuros.Name = "lblValorJuros";
            this.lblValorJuros.Size = new System.Drawing.Size(118, 25);
            this.lblValorJuros.TabIndex = 21;
            this.lblValorJuros.Text = "Valor Juros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Comissão de abertura (1%), Taxa de amortização antecipada (0,05%)";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(615, 453);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(137, 62);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Valor a amortizar:";
            // 
            // txtValorAAmortizar
            // 
            this.txtValorAAmortizar.Enabled = false;
            this.txtValorAAmortizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAAmortizar.Location = new System.Drawing.Point(585, 336);
            this.txtValorAAmortizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorAAmortizar.Name = "txtValorAAmortizar";
            this.txtValorAAmortizar.Size = new System.Drawing.Size(165, 30);
            this.txtValorAAmortizar.TabIndex = 28;
            this.txtValorAAmortizar.TextChanged += new System.EventHandler(this.txtValorAAmortizar_TextChanged);
            // 
            // btnAmortizar
            // 
            this.btnAmortizar.Enabled = false;
            this.btnAmortizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmortizar.Location = new System.Drawing.Point(415, 384);
            this.btnAmortizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAmortizar.Name = "btnAmortizar";
            this.btnAmortizar.Size = new System.Drawing.Size(241, 38);
            this.btnAmortizar.TabIndex = 29;
            this.btnAmortizar.Text = "Simular amortização";
            this.btnAmortizar.UseVisualStyleBackColor = true;
            this.btnAmortizar.Click += new System.EventHandler(this.btnAmortizar_Click);
            // 
            // Outros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 528);
            this.Controls.Add(this.btnAmortizar);
            this.Controls.Add(this.txtValorAAmortizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalComJuros);
            this.Controls.Add(this.lblTotalComJuros);
            this.Controls.Add(this.txtValorJuros);
            this.Controls.Add(this.lblValorJuros);
            this.Controls.Add(this.txtComissaoAbertura);
            this.Controls.Add(this.lblComissaoAbertura);
            this.Controls.Add(this.txtPrestacoes);
            this.Controls.Add(this.lblPrestacoes);
            this.Controls.Add(this.txtPrimeiraPrestacao);
            this.Controls.Add(this.lblPrimeiraPrestacao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.txtMontante);
            this.Controls.Add(this.lblMontante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(785, 575);
            this.Name = "Outros";
            this.Text = "Outros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Outros_FormClosing);
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
        private System.Windows.Forms.TextBox txtComissaoAbertura;
        private System.Windows.Forms.Label lblComissaoAbertura;
        private System.Windows.Forms.TextBox txtPrestacoes;
        private System.Windows.Forms.Label lblPrestacoes;
        private System.Windows.Forms.TextBox txtPrimeiraPrestacao;
        private System.Windows.Forms.Label lblPrimeiraPrestacao;
        private System.Windows.Forms.TextBox txtTotalComJuros;
        private System.Windows.Forms.Label lblTotalComJuros;
        private System.Windows.Forms.TextBox txtValorJuros;
        private System.Windows.Forms.Label lblValorJuros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorAAmortizar;
        private System.Windows.Forms.Button btnAmortizar;
    }
}