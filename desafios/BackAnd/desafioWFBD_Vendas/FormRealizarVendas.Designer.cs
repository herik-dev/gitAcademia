namespace desafioWFBD_Vendas
{
    partial class FormRealizarVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRealizarVendas));
            this.lbRealizarVenda = new System.Windows.Forms.Label();
            this.labelProgamaControle = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.desafiovendas_dbDataSet = new desafioWFBD_Vendas.desafiovendas_dbDataSet();
            this.clienteBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.desafiovendasdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbNome = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new desafioWFBD_Vendas.desafiovendas_dbDataSetTableAdapters.ClienteTableAdapter();
            this.produtoTableAdapter = new desafioWFBD_Vendas.desafiovendas_dbDataSetTableAdapters.ProdutoTableAdapter();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new desafioWFBD_Vendas.desafiovendas_dbDataSetTableAdapters.VendaTableAdapter();
            this.btRealizarVenda = new System.Windows.Forms.Button();
            this.produtoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafiovendas_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafiovendasdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource8)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRealizarVenda
            // 
            this.lbRealizarVenda.AutoSize = true;
            this.lbRealizarVenda.BackColor = System.Drawing.Color.Transparent;
            this.lbRealizarVenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbRealizarVenda.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRealizarVenda.ForeColor = System.Drawing.Color.White;
            this.lbRealizarVenda.Location = new System.Drawing.Point(12, 67);
            this.lbRealizarVenda.Name = "lbRealizarVenda";
            this.lbRealizarVenda.Size = new System.Drawing.Size(420, 80);
            this.lbRealizarVenda.TabIndex = 11;
            this.lbRealizarVenda.Text = "Realizar Venda";
            // 
            // labelProgamaControle
            // 
            this.labelProgamaControle.AutoSize = true;
            this.labelProgamaControle.BackColor = System.Drawing.Color.White;
            this.labelProgamaControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProgamaControle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelProgamaControle.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgamaControle.Location = new System.Drawing.Point(469, 12);
            this.labelProgamaControle.Name = "labelProgamaControle";
            this.labelProgamaControle.Size = new System.Drawing.Size(306, 47);
            this.labelProgamaControle.TabIndex = 10;
            this.labelProgamaControle.Text = "Bilbo\'s WareHouse";
            // 
            // cbCliente
            // 
            this.cbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource1, "nomeCompleto", true));
            this.cbCliente.DataSource = this.clienteBindingSource4;
            this.cbCliente.DisplayMember = "nomeCompleto";
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(33, 205);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 13;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            this.clienteBindingSource1.DataSource = this.desafiovendas_dbDataSet;
            // 
            // desafiovendas_dbDataSet
            // 
            this.desafiovendas_dbDataSet.DataSetName = "desafiovendas_dbDataSet";
            this.desafiovendas_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource4
            // 
            this.clienteBindingSource4.DataMember = "Cliente";
            this.clienteBindingSource4.DataSource = this.desafiovendasdbDataSetBindingSource;
            // 
            // desafiovendasdbDataSetBindingSource
            // 
            this.desafiovendasdbDataSetBindingSource.DataSource = this.desafiovendas_dbDataSet;
            this.desafiovendasdbDataSetBindingSource.Position = 0;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.desafiovendas_dbDataSet;
            // 
            // cbNome
            // 
            this.cbNome.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource6, "nome", true));
            this.cbNome.DataSource = this.produtoBindingSource4;
            this.cbNome.DisplayMember = "nome";
            this.cbNome.FormattingEnabled = true;
            this.cbNome.Location = new System.Drawing.Point(184, 205);
            this.cbNome.Name = "cbNome";
            this.cbNome.Size = new System.Drawing.Size(121, 21);
            this.cbNome.TabIndex = 14;
            this.cbNome.SelectedIndexChanged += new System.EventHandler(this.cbNome_SelectedIndexChanged);
            // 
            // produtoBindingSource6
            // 
            this.produtoBindingSource6.DataMember = "Produto";
            this.produtoBindingSource6.DataSource = this.desafiovendas_dbDataSet;
            // 
            // produtoBindingSource4
            // 
            this.produtoBindingSource4.DataMember = "Produto";
            this.produtoBindingSource4.DataSource = this.desafiovendasdbDataSetBindingSource;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.desafiovendas_dbDataSet;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.desafiovendas_dbDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(52, 189);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(85, 13);
            this.lbNomeCliente.TabIndex = 16;
            this.lbNomeCliente.Text = "Nome do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome Produto";
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
            this.dataGridView1.Location = new System.Drawing.Point(311, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 237);
            this.dataGridView1.TabIndex = 19;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "valorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "nomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome do Cliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome do Produto";
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.desafiovendas_dbDataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // btRealizarVenda
            // 
            this.btRealizarVenda.Location = new System.Drawing.Point(101, 366);
            this.btRealizarVenda.Name = "btRealizarVenda";
            this.btRealizarVenda.Size = new System.Drawing.Size(157, 49);
            this.btRealizarVenda.TabIndex = 20;
            this.btRealizarVenda.Text = "Vender";
            this.btRealizarVenda.UseVisualStyleBackColor = true;
            this.btRealizarVenda.Click += new System.EventHandler(this.btRealizarVenda_Click);
            // 
            // produtoBindingSource3
            // 
            this.produtoBindingSource3.DataMember = "Produto";
            this.produtoBindingSource3.DataSource = this.desafiovendas_dbDataSet;
            // 
            // produtoBindingSource2
            // 
            this.produtoBindingSource2.DataMember = "Produto";
            this.produtoBindingSource2.DataSource = this.desafiovendasdbDataSetBindingSource;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(37, 269);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.tbQuantidade.TabIndex = 15;
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "Cliente";
            this.clienteBindingSource2.DataSource = this.desafiovendasdbDataSetBindingSource;
            // 
            // produtoBindingSource5
            // 
            this.produtoBindingSource5.DataMember = "Produto";
            this.produtoBindingSource5.DataSource = this.desafiovendas_dbDataSet;
            // 
            // clienteBindingSource3
            // 
            this.clienteBindingSource3.DataMember = "Cliente";
            this.clienteBindingSource3.DataSource = this.desafiovendasdbDataSetBindingSource;
            // 
            // vendaBindingSource1
            // 
            this.vendaBindingSource1.DataMember = "Venda";
            this.vendaBindingSource1.DataSource = this.desafiovendasdbDataSetBindingSource;
            // 
            // produtoBindingSource7
            // 
            this.produtoBindingSource7.DataMember = "Produto";
            this.produtoBindingSource7.DataSource = this.desafiovendas_dbDataSet;
            // 
            // produtoBindingSource8
            // 
            this.produtoBindingSource8.DataMember = "Produto";
            this.produtoBindingSource8.DataSource = this.desafiovendas_dbDataSet;
            // 
            // FormRealizarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.btRealizarVenda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.cbNome);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lbRealizarVenda);
            this.Controls.Add(this.labelProgamaControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormRealizarVendas";
            this.Text = "Realizar Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafiovendas_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desafiovendasdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRealizarVenda;
        private System.Windows.Forms.Label labelProgamaControle;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbNome;
        private desafiovendas_dbDataSet desafiovendas_dbDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private desafiovendas_dbDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private desafiovendas_dbDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private desafiovendas_dbDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.Button btRealizarVenda;
        private System.Windows.Forms.BindingSource produtoBindingSource3;
        private System.Windows.Forms.BindingSource produtoBindingSource2;
        private System.Windows.Forms.BindingSource desafiovendasdbDataSetBindingSource;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.BindingSource produtoBindingSource5;
        private System.Windows.Forms.BindingSource produtoBindingSource4;
        private System.Windows.Forms.BindingSource clienteBindingSource3;
        private System.Windows.Forms.BindingSource clienteBindingSource4;
        private System.Windows.Forms.BindingSource produtoBindingSource6;
        private System.Windows.Forms.BindingSource produtoBindingSource8;
        private System.Windows.Forms.BindingSource produtoBindingSource7;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
    }
}