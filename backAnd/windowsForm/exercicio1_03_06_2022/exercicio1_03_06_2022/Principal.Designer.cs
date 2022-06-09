namespace exercicio1_03_06_2022
{
    partial class Principal
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
            this.btCadastroPessoa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wEindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCadastroPessoa
            // 
            this.btCadastroPessoa.Location = new System.Drawing.Point(275, 166);
            this.btCadastroPessoa.Name = "btCadastroPessoa";
            this.btCadastroPessoa.Size = new System.Drawing.Size(281, 23);
            this.btCadastroPessoa.TabIndex = 0;
            this.btCadastroPessoa.Text = "Cadastrar Pessoa";
            this.btCadastroPessoa.UseVisualStyleBackColor = true;
            this.btCadastroPessoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.wEindowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurePrintToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // configurePrintToolStripMenuItem
            // 
            this.configurePrintToolStripMenuItem.Name = "configurePrintToolStripMenuItem";
            this.configurePrintToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.configurePrintToolStripMenuItem.Text = "Configurar Impressora";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarPessoaToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // cadastrarPessoaToolStripMenuItem
            // 
            this.cadastrarPessoaToolStripMenuItem.Name = "cadastrarPessoaToolStripMenuItem";
            this.cadastrarPessoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarPessoaToolStripMenuItem.Text = "Cadastrar Pessoa";
            this.cadastrarPessoaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPessoaToolStripMenuItem_Click);
            // 
            // wEindowsToolStripMenuItem
            // 
            this.wEindowsToolStripMenuItem.Name = "wEindowsToolStripMenuItem";
            this.wEindowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.wEindowsToolStripMenuItem.Text = "Windows";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCadastroPessoa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Formulário de cadastro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastroPessoa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurePrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wEindowsToolStripMenuItem;
    }
}