namespace usuarioFormsBD
{
    partial class Consulta
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
            this.listView_Consulta = new System.Windows.Forms.ListView();
            this.idUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button_conectarBD = new System.Windows.Forms.Button();
            this.button_adicionarUsuari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_Consulta
            // 
            this.listView_Consulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idUsuario,
            this.nomeCompleto,
            this.email});
            this.listView_Consulta.HideSelection = false;
            this.listView_Consulta.Location = new System.Drawing.Point(-1, 12);
            this.listView_Consulta.Name = "listView_Consulta";
            this.listView_Consulta.Size = new System.Drawing.Size(623, 338);
            this.listView_Consulta.TabIndex = 0;
            this.listView_Consulta.UseCompatibleStateImageBehavior = false;
            this.listView_Consulta.View = System.Windows.Forms.View.Details;
            // 
            // idUsuario
            // 
            this.idUsuario.Text = "ID";
            // 
            // nomeCompleto
            // 
            this.nomeCompleto.Text = "Nome Completo";
            this.nomeCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nomeCompleto.Width = 257;
            // 
            // email
            // 
            this.email.Text = "E-mail";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.Width = 222;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(-1, 343);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(636, 17);
            this.hScrollBar1.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(616, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 331);
            this.vScrollBar1.TabIndex = 2;
            // 
            // button_conectarBD
            // 
            this.button_conectarBD.Location = new System.Drawing.Point(0, 363);
            this.button_conectarBD.Name = "button_conectarBD";
            this.button_conectarBD.Size = new System.Drawing.Size(636, 30);
            this.button_conectarBD.TabIndex = 3;
            this.button_conectarBD.Text = "Conectar";
            this.button_conectarBD.UseVisualStyleBackColor = true;
            this.button_conectarBD.Click += new System.EventHandler(this.button_conectarBD_Click);
            // 
            // button_adicionarUsuari
            // 
            this.button_adicionarUsuari.Location = new System.Drawing.Point(0, 399);
            this.button_adicionarUsuari.Name = "button_adicionarUsuari";
            this.button_adicionarUsuari.Size = new System.Drawing.Size(636, 30);
            this.button_adicionarUsuari.TabIndex = 4;
            this.button_adicionarUsuari.Text = "Adicionar novo Usuario";
            this.button_adicionarUsuari.UseVisualStyleBackColor = true;
            this.button_adicionarUsuari.Click += new System.EventHandler(this.button_adicionarUsuari_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.button_adicionarUsuari);
            this.Controls.Add(this.button_conectarBD);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.listView_Consulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Consulta;
        private System.Windows.Forms.ColumnHeader idUsuario;
        private System.Windows.Forms.ColumnHeader nomeCompleto;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button_conectarBD;
        private System.Windows.Forms.Button button_adicionarUsuari;
    }
}

