namespace SistemaDeLogin
{
    partial class AlterarConta_Cliente
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
            this.Enviar = new System.Windows.Forms.Button();
            this.pesquisaLogin = new System.Windows.Forms.TextBox();
            this.alteraSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nova senha";
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(127, 148);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 2;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click_1);
            // 
            // pesquisaLogin
            // 
            this.pesquisaLogin.Location = new System.Drawing.Point(117, 65);
            this.pesquisaLogin.Name = "pesquisaLogin";
            this.pesquisaLogin.Size = new System.Drawing.Size(100, 20);
            this.pesquisaLogin.TabIndex = 3;
            // 
            // alteraSenha
            // 
            this.alteraSenha.Location = new System.Drawing.Point(117, 105);
            this.alteraSenha.Name = "alteraSenha";
            this.alteraSenha.Size = new System.Drawing.Size(100, 20);
            this.alteraSenha.TabIndex = 4;
            // 
            // AlterarConta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 191);
            this.Controls.Add(this.alteraSenha);
            this.Controls.Add(this.pesquisaLogin);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AlterarConta_Cliente";
            this.Text = "AlterarConta_Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.TextBox pesquisaLogin;
        private System.Windows.Forms.TextBox alteraSenha;
    }
}