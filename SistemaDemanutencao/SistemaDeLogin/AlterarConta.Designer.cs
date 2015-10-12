namespace SistemaDeLogin
{
    partial class AlterarConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SenhaMudar = new System.Windows.Forms.TextBox();
            this.LoginPesquisar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pesquisaLogin = new System.Windows.Forms.TextBox();
            this.alteraSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SenhaMudar
            // 
            this.SenhaMudar.Location = new System.Drawing.Point(69, 110);
            this.SenhaMudar.Name = "SenhaMudar";
            this.SenhaMudar.Size = new System.Drawing.Size(100, 20);
            this.SenhaMudar.TabIndex = 0;
            // 
            // LoginPesquisar
            // 
            this.LoginPesquisar.Location = new System.Drawing.Point(69, 46);
            this.LoginPesquisar.Name = "LoginPesquisar";
            this.LoginPesquisar.Size = new System.Drawing.Size(100, 20);
            this.LoginPesquisar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nova senha";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pesquisaLogin
            // 
            this.pesquisaLogin.Location = new System.Drawing.Point(121, 55);
            this.pesquisaLogin.Name = "pesquisaLogin";
            this.pesquisaLogin.Size = new System.Drawing.Size(100, 20);
            this.pesquisaLogin.TabIndex = 1;
            // 
            // alteraSenha
            // 
            this.alteraSenha.Location = new System.Drawing.Point(121, 95);
            this.alteraSenha.Name = "alteraSenha";
            this.alteraSenha.Size = new System.Drawing.Size(100, 20);
            this.alteraSenha.TabIndex = 2;
            // 
            // AlterarConta
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.alteraSenha);
            this.Controls.Add(this.pesquisaLogin);
            this.Controls.Add(this.button2);
            this.Name = "AlterarConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SenhaMudar;
        private System.Windows.Forms.TextBox LoginPesquisar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pesquisaLogin;
        private System.Windows.Forms.TextBox alteraSenha;
    }
}