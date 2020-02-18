namespace Menu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnCasa = new System.Windows.Forms.Button();
            this.btnOutros = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarro
            // 
            this.btnCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarro.Location = new System.Drawing.Point(188, 50);
            this.btnCarro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(309, 90);
            this.btnCarro.TabIndex = 0;
            this.btnCarro.Text = "Financiamento Carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // btnCasa
            // 
            this.btnCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasa.Location = new System.Drawing.Point(188, 180);
            this.btnCasa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCasa.Name = "btnCasa";
            this.btnCasa.Size = new System.Drawing.Size(309, 90);
            this.btnCasa.TabIndex = 1;
            this.btnCasa.Text = "Financiamento Casa";
            this.btnCasa.UseVisualStyleBackColor = true;
            this.btnCasa.Click += new System.EventHandler(this.btnCasa_Click);
            // 
            // btnOutros
            // 
            this.btnOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutros.Location = new System.Drawing.Point(188, 314);
            this.btnOutros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOutros.Name = "btnOutros";
            this.btnOutros.Size = new System.Drawing.Size(309, 90);
            this.btnOutros.TabIndex = 2;
            this.btnOutros.Text = "Outros Financiamentos";
            this.btnOutros.UseVisualStyleBackColor = true;
            this.btnOutros.Click += new System.EventHandler(this.btnOutros_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(587, 430);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(100, 28);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 463);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnOutros);
            this.Controls.Add(this.btnCasa);
            this.Controls.Add(this.btnCarro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(718, 510);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button btnCasa;
        private System.Windows.Forms.Button btnOutros;
        private System.Windows.Forms.Button btnInfo;
    }
}

