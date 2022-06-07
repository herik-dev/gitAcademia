namespace exemplo0306Friday
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lblModeloCarro = new System.Windows.Forms.Label();
            this.tbModeloCarro = new System.Windows.Forms.TextBox();
            this.lblFabricanteCarro = new System.Windows.Forms.Label();
            this.tbFabricanteCarro = new System.Windows.Forms.TextBox();
            this.lbOpcionais = new System.Windows.Forms.CheckedListBox();
            this.lblOpcionais = new System.Windows.Forms.Label();
            this.cbPortas = new System.Windows.Forms.ComboBox();
            this.lblPortas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(607, 398);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(181, 40);
            this.btLimpar.TabIndex = 0;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(409, 398);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(181, 40);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // lblModeloCarro
            // 
            this.lblModeloCarro.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.lblModeloCarro.AutoSize = true;
            this.lblModeloCarro.Location = new System.Drawing.Point(12, 32);
            this.lblModeloCarro.Name = "lblModeloCarro";
            this.lblModeloCarro.Size = new System.Drawing.Size(88, 13);
            this.lblModeloCarro.TabIndex = 2;
            this.lblModeloCarro.Text = "Modelo do Carro:";
            // 
            // tbModeloCarro
            // 
            this.tbModeloCarro.Location = new System.Drawing.Point(159, 29);
            this.tbModeloCarro.Name = "tbModeloCarro";
            this.tbModeloCarro.Size = new System.Drawing.Size(259, 20);
            this.tbModeloCarro.TabIndex = 3;
            // 
            // lblFabricanteCarro
            // 
            this.lblFabricanteCarro.AutoSize = true;
            this.lblFabricanteCarro.Location = new System.Drawing.Point(12, 71);
            this.lblFabricanteCarro.Name = "lblFabricanteCarro";
            this.lblFabricanteCarro.Size = new System.Drawing.Size(102, 13);
            this.lblFabricanteCarro.TabIndex = 4;
            this.lblFabricanteCarro.Text = "Fabricante do carro:";
            // 
            // tbFabricanteCarro
            // 
            this.tbFabricanteCarro.Location = new System.Drawing.Point(159, 68);
            this.tbFabricanteCarro.Name = "tbFabricanteCarro";
            this.tbFabricanteCarro.Size = new System.Drawing.Size(259, 20);
            this.tbFabricanteCarro.TabIndex = 5;
            // 
            // lbOpcionais
            // 
            this.lbOpcionais.FormattingEnabled = true;
            this.lbOpcionais.Items.AddRange(new object[] {
            "Ar condicionado",
            "Direção hidráulica",
            "Freios ABS",
            "Air bag",
            "Vidros elétricos"});
            this.lbOpcionais.Location = new System.Drawing.Point(159, 127);
            this.lbOpcionais.Name = "lbOpcionais";
            this.lbOpcionais.Size = new System.Drawing.Size(220, 79);
            this.lbOpcionais.TabIndex = 6;
            // 
            // lblOpcionais
            // 
            this.lblOpcionais.AutoSize = true;
            this.lblOpcionais.Location = new System.Drawing.Point(12, 127);
            this.lblOpcionais.Name = "lblOpcionais";
            this.lblOpcionais.Size = new System.Drawing.Size(54, 13);
            this.lblOpcionais.TabIndex = 7;
            this.lblOpcionais.Text = "Opcionais";
            this.lblOpcionais.Click += new System.EventHandler(this.lblOpcionais_Click);
            // 
            // cbPortas
            // 
            this.cbPortas.FormattingEnabled = true;
            this.cbPortas.Items.AddRange(new object[] {
            "2 portas",
            "3 portas",
            "4 portas",
            "5 portas"});
            this.cbPortas.Location = new System.Drawing.Point(159, 231);
            this.cbPortas.Name = "cbPortas";
            this.cbPortas.Size = new System.Drawing.Size(120, 21);
            this.cbPortas.TabIndex = 8;
            // 
            // lblPortas
            // 
            this.lblPortas.AutoSize = true;
            this.lblPortas.Location = new System.Drawing.Point(12, 234);
            this.lblPortas.Name = "lblPortas";
            this.lblPortas.Size = new System.Drawing.Size(59, 13);
            this.lblPortas.TabIndex = 9;
            this.lblPortas.Text = "Qtd portas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPortas);
            this.Controls.Add(this.cbPortas);
            this.Controls.Add(this.lblOpcionais);
            this.Controls.Add(this.lbOpcionais);
            this.Controls.Add(this.tbFabricanteCarro);
            this.Controls.Add(this.lblFabricanteCarro);
            this.Controls.Add(this.tbModeloCarro);
            this.Controls.Add(this.lblModeloCarro);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btLimpar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lblModeloCarro;
        private System.Windows.Forms.TextBox tbModeloCarro;
        private System.Windows.Forms.Label lblFabricanteCarro;
        private System.Windows.Forms.TextBox tbFabricanteCarro;
        private System.Windows.Forms.CheckedListBox lbOpcionais;
        private System.Windows.Forms.Label lblOpcionais;
        private System.Windows.Forms.ComboBox cbPortas;
        private System.Windows.Forms.Label lblPortas;
    }
}

