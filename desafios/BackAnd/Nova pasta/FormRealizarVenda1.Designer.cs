namespace desafioWFBD_Vendas
{
    partial class FormRealizarVenda1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRealizarVenda1));
            this.lbListaClientes = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btRealizarVenda = new System.Windows.Forms.Button();
            this.label_ProgamaControle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nUpDQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lbQuantidadeVenda = new System.Windows.Forms.Label();
            this.lbProdutoVenda = new System.Windows.Forms.Label();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClienteVenda = new System.Windows.Forms.ComboBox();
            this.desafiovendas_dbDataSetCorreto = new desafioWFBD_Vendas.desafiovendas_dbDataSetCorreto();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new desafioWFBD_Vendas.desafiovendas_dbDataSetCorretoTableAdapters.ClienteTableAdapter();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desafiovendasdbDataSetCorretoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new desafioWFBD_Vendas.desafiovendas_dbDataSetCorretoTableAdapters.VendaTableAdapter();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new desafioWFBD_Vendas.desafiovendas_dbDataSetCorretoTableAdapters.ProdutoTableAdapter();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafiovendas_dbDataSetCorreto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafiovendasdbDataSetCorretoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListaClientes
            // 
            this.lbListaClientes.AutoSize = true;
            this.lbListaClientes.Location = new System.Drawing.Point(539, 161);
            this.lbListaClientes.Name = "lbListaClientes";
            this.lbListaClientes.Size = new System.Drawing.Size(83, 13);
            this.lbListaClientes.TabIndex = 28;
            this.lbListaClientes.Text = "Lista de clientes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.clienteBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(457, 174);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(245, 150);
            this.dataGridView2.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valorTotalDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 127);
            this.dataGridView1.TabIndex = 26;
            // 
            // btRealizarVenda
            // 
            this.btRealizarVenda.Location = new System.Drawing.Point(293, 174);
            this.btRealizarVenda.Name = "btRealizarVenda";
            this.btRealizarVenda.Size = new System.Drawing.Size(94, 90);
            this.btRealizarVenda.TabIndex = 25;
            this.btRealizarVenda.Text = "Realizar Venda";
            this.btRealizarVenda.UseVisualStyleBackColor = true;
            // 
            // label_ProgamaControle
            // 
            this.label_ProgamaControle.AutoSize = true;
            this.label_ProgamaControle.BackColor = System.Drawing.Color.White;
            this.label_ProgamaControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_ProgamaControle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_ProgamaControle.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProgamaControle.Location = new System.Drawing.Point(457, 9);
            this.label_ProgamaControle.Name = "label_ProgamaControle";
            this.label_ProgamaControle.Size = new System.Drawing.Size(306, 47);
            this.label_ProgamaControle.TabIndex = 24;
            this.label_ProgamaControle.Text = "Bilbo\'s WareHouse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 80);
            this.label4.TabIndex = 23;
            this.label4.Text = "Realizar Venda";
            // 
            // nUpDQuantidade
            // 
            this.nUpDQuantidade.Location = new System.Drawing.Point(205, 244);
            this.nUpDQuantidade.Name = "nUpDQuantidade";
            this.nUpDQuantidade.Size = new System.Drawing.Size(82, 20);
            this.nUpDQuantidade.TabIndex = 22;
            // 
            // lbQuantidadeVenda
            // 
            this.lbQuantidadeVenda.AutoSize = true;
            this.lbQuantidadeVenda.Location = new System.Drawing.Point(113, 246);
            this.lbQuantidadeVenda.Name = "lbQuantidadeVenda";
            this.lbQuantidadeVenda.Size = new System.Drawing.Size(65, 13);
            this.lbQuantidadeVenda.TabIndex = 21;
            this.lbQuantidadeVenda.Text = "Quantidade:";
            // 
            // lbProdutoVenda
            // 
            this.lbProdutoVenda.AutoSize = true;
            this.lbProdutoVenda.Location = new System.Drawing.Point(113, 213);
            this.lbProdutoVenda.Name = "lbProdutoVenda";
            this.lbProdutoVenda.Size = new System.Drawing.Size(47, 13);
            this.lbProdutoVenda.TabIndex = 20;
            this.lbProdutoVenda.Text = "Produto:";
            // 
            // cbProduto
            // 
            this.cbProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource1, "nome", true));
            this.cbProduto.DataSource = this.produtoBindingSource;
            this.cbProduto.DisplayMember = "nome";
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(166, 210);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(121, 21);
            this.cbProduto.TabIndex = 19;
            this.cbProduto.ValueMember = "idProduto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cliente:";
            // 
            // cbClienteVenda
            // 
            this.cbClienteVenda.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource2, "nomeCompleto", true));
            this.cbClienteVenda.DataSource = this.clienteBindingSource1;
            this.cbClienteVenda.DisplayMember = "nomeCompleto";
            this.cbClienteVenda.FormattingEnabled = true;
            this.cbClienteVenda.Location = new System.Drawing.Point(166, 174);
            this.cbClienteVenda.Name = "cbClienteVenda";
            this.cbClienteVenda.Size = new System.Drawing.Size(121, 21);
            this.cbClienteVenda.TabIndex = 17;
            this.cbClienteVenda.ValueMember = "idCliente";
            // 
            // desafiovendas_dbDataSetCorreto
            // 
            this.desafiovendas_dbDataSetCorreto.DataSetName = "desafiovendas_dbDataSetCorreto";
            this.desafiovendas_dbDataSetCorreto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.desafiovendas_dbDataSetCorreto;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "nomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "nomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // desafiovendasdbDataSetCorretoBindingSource
            // 
            this.desafiovendasdbDataSetCorretoBindingSource.DataSource = this.desafiovendas_dbDataSetCorreto;
            this.desafiovendasdbDataSetCorretoBindingSource.Position = 0;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.desafiovendasdbDataSetCorretoBindingSource;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "nomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "nomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.desafiovendasdbDataSetCorretoBindingSource;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "Cliente";
            this.clienteBindingSource2.DataSource = this.desafiovendas_dbDataSetCorreto;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.desafiovendas_dbDataSetCorreto;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.desafiovendas_dbDataSetCorreto;
            // 
            // FormRealizarVenda1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 501);
            this.Controls.Add(this.lbListaClientes);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btRealizarVenda);
            this.Controls.Add(this.label_ProgamaControle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nUpDQuantidade);
            this.Controls.Add(this.lbQuantidadeVenda);
            this.Controls.Add(this.lbProdutoVenda);
            this.Controls.Add(this.cbProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClienteVenda);
            this.Name = "FormRealizarVenda1";
            this.Load += new System.EventHandler(this.FormRealizarVenda1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafiovendas_dbDataSetCorreto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafiovendasdbDataSetCorretoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbListaClientes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btRealizarVenda;
        private System.Windows.Forms.Label label_ProgamaControle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUpDQuantidade;
        private System.Windows.Forms.Label lbQuantidadeVenda;
        private System.Windows.Forms.Label lbProdutoVenda;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClienteVenda;
        private desafiovendas_dbDataSetCorreto desafiovendas_dbDataSetCorreto;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private desafiovendas_dbDataSetCorretoTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource desafiovendasdbDataSetCorretoBindingSource;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private desafiovendas_dbDataSetCorretoTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private desafiovendas_dbDataSetCorretoTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
    }
}