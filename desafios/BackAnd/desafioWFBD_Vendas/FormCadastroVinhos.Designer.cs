namespace desafioWFBD_Vendas
{
    partial class FormCadastroVinhos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroVinhos));
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbNotaFiscal = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.tbNomeProduto = new System.Windows.Forms.TextBox();
            this.tbCodEAN = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.lbEstoque = new System.Windows.Forms.Label();
            this.label_ProgamaControle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.mtbEstoque = new System.Windows.Forms.MaskedTextBox();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Location = new System.Drawing.Point(275, 199);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(83, 13);
            this.lbNomeProduto.TabIndex = 0;
            this.lbNomeProduto.Text = "Nome do Vinho:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(303, 235);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(55, 13);
            this.lbCategoria.TabIndex = 1;
            this.lbCategoria.Text = "Categoria:";
            // 
            // lbNotaFiscal
            // 
            this.lbNotaFiscal.AutoSize = true;
            this.lbNotaFiscal.Location = new System.Drawing.Point(295, 271);
            this.lbNotaFiscal.Name = "lbNotaFiscal";
            this.lbNotaFiscal.Size = new System.Drawing.Size(63, 13);
            this.lbNotaFiscal.TabIndex = 2;
            this.lbNotaFiscal.Text = "Nota Fiscal:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(320, 306);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(38, 13);
            this.lbPreco.TabIndex = 3;
            this.lbPreco.Text = "Preço:";
            // 
            // tbNomeProduto
            // 
            this.tbNomeProduto.Location = new System.Drawing.Point(364, 196);
            this.tbNomeProduto.Name = "tbNomeProduto";
            this.tbNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.tbNomeProduto.TabIndex = 4;
            // 
            // tbCodEAN
            // 
            this.tbCodEAN.Location = new System.Drawing.Point(364, 268);
            this.tbCodEAN.Name = "tbCodEAN";
            this.tbCodEAN.Size = new System.Drawing.Size(100, 20);
            this.tbCodEAN.TabIndex = 6;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(364, 232);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbCategoria.TabIndex = 5;
            // 
            // lbEstoque
            // 
            this.lbEstoque.AutoSize = true;
            this.lbEstoque.Location = new System.Drawing.Point(309, 340);
            this.lbEstoque.Name = "lbEstoque";
            this.lbEstoque.Size = new System.Drawing.Size(49, 13);
            this.lbEstoque.TabIndex = 8;
            this.lbEstoque.Text = "Estoque:";
            // 
            // label_ProgamaControle
            // 
            this.label_ProgamaControle.AutoSize = true;
            this.label_ProgamaControle.BackColor = System.Drawing.Color.White;
            this.label_ProgamaControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ProgamaControle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_ProgamaControle.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProgamaControle.Location = new System.Drawing.Point(466, 9);
            this.label_ProgamaControle.Name = "label_ProgamaControle";
            this.label_ProgamaControle.Size = new System.Drawing.Size(306, 47);
            this.label_ProgamaControle.TabIndex = 10;
            this.label_ProgamaControle.Text = "Bilbo\'s WareHouse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(597, 80);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cadastro de Produtos";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(270, 368);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(113, 42);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(389, 368);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(113, 41);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // mtbEstoque
            // 
            this.mtbEstoque.Location = new System.Drawing.Point(364, 337);
            this.mtbEstoque.Mask = "999";
            this.mtbEstoque.Name = "mtbEstoque";
            this.mtbEstoque.Size = new System.Drawing.Size(100, 20);
            this.mtbEstoque.TabIndex = 8;
            // 
            // mtbPreco
            // 
            this.mtbPreco.Location = new System.Drawing.Point(364, 303);
            this.mtbPreco.Mask = "$999,999.00";
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(100, 20);
            this.mtbPreco.TabIndex = 7;
            this.mtbPreco.ValidatingType = typeof(int);
            // 
            // FormCadastroVinhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.mtbPreco);
            this.Controls.Add(this.mtbEstoque);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_ProgamaControle);
            this.Controls.Add(this.lbEstoque);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbCodEAN);
            this.Controls.Add(this.tbNomeProduto);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbNotaFiscal);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbNomeProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCadastroVinhos";
            this.Text = "Cadastro de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeProduto;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbNotaFiscal;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.TextBox tbNomeProduto;
        private System.Windows.Forms.TextBox tbCodEAN;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Label lbEstoque;
        private System.Windows.Forms.Label label_ProgamaControle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.MaskedTextBox mtbEstoque;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
    }
}