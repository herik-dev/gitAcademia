namespace glicemiaComBDADO
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
            this.button_conectar = new System.Windows.Forms.Button();
            this.listView_medidasGlicemias = new System.Windows.Forms.ListView();
            this.columnHeader_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ValorGlicemico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DataMedicao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Paciente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_conectar
            // 
            this.button_conectar.Location = new System.Drawing.Point(40, 337);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(344, 23);
            this.button_conectar.TabIndex = 1;
            this.button_conectar.Text = "Conectar";
            this.button_conectar.UseVisualStyleBackColor = true;
            this.button_conectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView_medidasGlicemias
            // 
            this.listView_medidasGlicemias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_ID,
            this.columnHeader_ValorGlicemico,
            this.columnHeader_DataMedicao,
            this.columnHeader_Paciente});
            this.listView_medidasGlicemias.HideSelection = false;
            this.listView_medidasGlicemias.Location = new System.Drawing.Point(1, 1);
            this.listView_medidasGlicemias.Name = "listView_medidasGlicemias";
            this.listView_medidasGlicemias.Size = new System.Drawing.Size(749, 273);
            this.listView_medidasGlicemias.TabIndex = 2;
            this.listView_medidasGlicemias.UseCompatibleStateImageBehavior = false;
            this.listView_medidasGlicemias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_ID
            // 
            this.columnHeader_ID.Text = "ID";
            this.columnHeader_ID.Width = 35;
            // 
            // columnHeader_ValorGlicemico
            // 
            this.columnHeader_ValorGlicemico.Text = "Valor Glicêmico";
            this.columnHeader_ValorGlicemico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_ValorGlicemico.Width = 99;
            // 
            // columnHeader_DataMedicao
            // 
            this.columnHeader_DataMedicao.Text = "Data Medição";
            this.columnHeader_DataMedicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_DataMedicao.Width = 94;
            // 
            // columnHeader_Paciente
            // 
            this.columnHeader_Paciente.Text = "Paciente";
            this.columnHeader_Paciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_Paciente.Width = 290;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_medidasGlicemias);
            this.Controls.Add(this.button_conectar);
            this.Name = "Form1";
            this.Text = "Software Glicemia";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_conectar;
        private System.Windows.Forms.ListView listView_medidasGlicemias;
        private System.Windows.Forms.ColumnHeader columnHeader_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_ValorGlicemico;
        private System.Windows.Forms.ColumnHeader columnHeader_DataMedicao;
        private System.Windows.Forms.ColumnHeader columnHeader_Paciente;
    }
}

