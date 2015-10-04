namespace SistemaDeLogin
{
    partial class IncluirConta
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
            this.newLogin = new System.Windows.Forms.TextBox();
            this.newSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newLogin
            // 
            this.newLogin.Location = new System.Drawing.Point(103, 41);
            this.newLogin.Name = "newLogin";
            this.newLogin.Size = new System.Drawing.Size(100, 20);
            this.newLogin.TabIndex = 0;
            // 
            // newSenha
            // 
            this.newSenha.Location = new System.Drawing.Point(103, 80);
            this.newSenha.Name = "newSenha";
            this.newSenha.Size = new System.Drawing.Size(100, 20);
            this.newSenha.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IncluirConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newSenha);
            this.Controls.Add(this.newLogin);
            this.Name = "IncluirConta";
            this.Text = "IncluirConta";
            this.Load += new System.EventHandler(this.IncluirConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newLogin;
        private System.Windows.Forms.TextBox newSenha;
        private System.Windows.Forms.Button button1;
    }
}