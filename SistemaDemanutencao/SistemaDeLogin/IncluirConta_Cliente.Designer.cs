namespace SistemaDeLogin
{
    partial class IncluirConta_Cliente
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
            this.newLogin = new System.Windows.Forms.TextBox();
            this.newSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nova senha:";
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(93, 120);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(64, 23);
            this.Enviar.TabIndex = 2;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click_1);
            // 
            // newLogin
            // 
            this.newLogin.Location = new System.Drawing.Point(82, 37);
            this.newLogin.Name = "newLogin";
            this.newLogin.Size = new System.Drawing.Size(100, 20);
            this.newLogin.TabIndex = 3;
            // 
            // newSenha
            // 
            this.newSenha.Location = new System.Drawing.Point(82, 77);
            this.newSenha.Name = "newSenha";
            this.newSenha.Size = new System.Drawing.Size(100, 20);
            this.newSenha.TabIndex = 4;
            // 
            // IncluirConta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 176);
            this.Controls.Add(this.newSenha);
            this.Controls.Add(this.newLogin);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IncluirConta_Cliente";
            this.Text = "IncluirConta_Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.TextBox newLogin;
        private System.Windows.Forms.TextBox newSenha;
    }
}