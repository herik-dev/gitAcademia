namespace desafioWFBD_Vendas
{
    partial class FormTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaPrincipal));
            this.label_ProgamaControle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btRealizarVendas = new System.Windows.Forms.Button();
            this.btCadastarProdutos = new System.Windows.Forms.Button();
            this.btCadastrarCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ProgamaControle
            // 
            this.label_ProgamaControle.AutoSize = true;
            this.label_ProgamaControle.BackColor = System.Drawing.Color.White;
            this.label_ProgamaControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ProgamaControle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_ProgamaControle.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProgamaControle.Location = new System.Drawing.Point(466, 12);
            this.label_ProgamaControle.Name = "label_ProgamaControle";
            this.label_ProgamaControle.Size = new System.Drawing.Size(306, 47);
            this.label_ProgamaControle.TabIndex = 0;
            this.label_ProgamaControle.Text = "Bilbo\'s WareHouse";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btRealizarVendas);
            this.panel1.Controls.Add(this.btCadastarProdutos);
            this.panel1.Controls.Add(this.btCadastrarCliente);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 456);
            this.panel1.TabIndex = 1;
            // 
            // btRealizarVendas
            // 
            this.btRealizarVendas.BackColor = System.Drawing.Color.White;
            this.btRealizarVendas.Location = new System.Drawing.Point(2, 260);
            this.btRealizarVendas.Name = "btRealizarVendas";
            this.btRealizarVendas.Size = new System.Drawing.Size(196, 58);
            this.btRealizarVendas.TabIndex = 4;
            this.btRealizarVendas.Text = "Realizar vendas";
            this.btRealizarVendas.UseVisualStyleBackColor = false;
            this.btRealizarVendas.Click += new System.EventHandler(this.btRealizarVendas_Click);
            // 
            // btCadastarProdutos
            // 
            this.btCadastarProdutos.BackColor = System.Drawing.Color.White;
            this.btCadastarProdutos.Location = new System.Drawing.Point(2, 170);
            this.btCadastarProdutos.Name = "btCadastarProdutos";
            this.btCadastarProdutos.Size = new System.Drawing.Size(196, 58);
            this.btCadastarProdutos.TabIndex = 3;
            this.btCadastarProdutos.Text = "Cadastrar produtos";
            this.btCadastarProdutos.UseVisualStyleBackColor = false;
            this.btCadastarProdutos.Click += new System.EventHandler(this.btCadastarProdutos_Click);
            // 
            // btCadastrarCliente
            // 
            this.btCadastrarCliente.BackColor = System.Drawing.Color.White;
            this.btCadastrarCliente.Location = new System.Drawing.Point(2, 80);
            this.btCadastrarCliente.Name = "btCadastrarCliente";
            this.btCadastrarCliente.Size = new System.Drawing.Size(196, 58);
            this.btCadastrarCliente.TabIndex = 2;
            this.btCadastrarCliente.Text = "Cadastrar clientes";
            this.btCadastrarCliente.UseVisualStyleBackColor = false;
            this.btCadastrarCliente.Click += new System.EventHandler(this.btCadastrarCliente_Click);
            // 
            // FormTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_ProgamaControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTelaPrincipal";
            this.Text = "Bilbo\'s Warehouse";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ProgamaControle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRealizarVendas;
        private System.Windows.Forms.Button btCadastarProdutos;
        private System.Windows.Forms.Button btCadastrarCliente;
    }
}

