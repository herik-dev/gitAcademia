namespace usuarioFormsBD
{
    partial class Adicionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_voltarConsulta = new System.Windows.Forms.Button();
            this.textBox_nomeCompleto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vamos criar o seu e-mail!";
            // 
            // button_Limpar
            // 
            this.button_Limpar.Location = new System.Drawing.Point(12, 160);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpar.TabIndex = 2;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.Location = new System.Drawing.Point(93, 160);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cadastrar.TabIndex = 3;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_voltarConsulta
            // 
            this.button_voltarConsulta.Location = new System.Drawing.Point(435, 160);
            this.button_voltarConsulta.Name = "button_voltarConsulta";
            this.button_voltarConsulta.Size = new System.Drawing.Size(157, 23);
            this.button_voltarConsulta.TabIndex = 4;
            this.button_voltarConsulta.Text = "Voltar para a tela de consulta";
            this.button_voltarConsulta.UseVisualStyleBackColor = true;
            this.button_voltarConsulta.Click += new System.EventHandler(this.button_voltarConsulta_Click);
            // 
            // textBox_nomeCompleto
            // 
            this.textBox_nomeCompleto.Location = new System.Drawing.Point(98, 76);
            this.textBox_nomeCompleto.Name = "textBox_nomeCompleto";
            this.textBox_nomeCompleto.Size = new System.Drawing.Size(399, 20);
            this.textBox_nomeCompleto.TabIndex = 5;
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 192);
            this.Controls.Add(this.textBox_nomeCompleto);
            this.Controls.Add(this.button_voltarConsulta);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_voltarConsulta;
        private System.Windows.Forms.TextBox textBox_nomeCompleto;
    }
}