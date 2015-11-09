namespace SistemaDeLogin
{
    partial class AlterarConta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
      //  private System.ComponentModel.IContainer components = null;

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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alteraSenha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            this.button2.Location = new System.Drawing.Point(74, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pesquisaLogin
            // 
            this.pesquisaLogin.Location = new System.Drawing.Point(12, 87);
            this.pesquisaLogin.Name = "pesquisaLogin";
            this.pesquisaLogin.Size = new System.Drawing.Size(100, 20);
            this.pesquisaLogin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nova senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alterar conta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.alteraSenha);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados para alterar";
            // 
            // alteraSenha
            // 
            this.alteraSenha.Location = new System.Drawing.Point(74, 13);
            this.alteraSenha.Name = "alteraSenha";
            this.alteraSenha.PasswordChar = '*';
            this.alteraSenha.Size = new System.Drawing.Size(100, 20);
            this.alteraSenha.TabIndex = 2;
            // 
            // AlterarConta
            // 
            this.ClientSize = new System.Drawing.Size(207, 196);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pesquisaLogin);
            this.Name = "AlterarConta";
            this.Text = "AlterarConta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox alteraSenha;
    }
}