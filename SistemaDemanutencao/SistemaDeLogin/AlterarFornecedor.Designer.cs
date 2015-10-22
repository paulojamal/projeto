namespace SistemaDeLogin
{
    partial class AlterarFornecedor
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
            this.pesquisaNome = new System.Windows.Forms.TextBox();
            this.newCNPJ = new System.Windows.Forms.TextBox();
            this.newRua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newBairro = new System.Windows.Forms.TextBox();
            this.newCidade = new System.Windows.Forms.TextBox();
            this.newCEP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome para modificar os dados";
            // 
            // pesquisaNome
            // 
            this.pesquisaNome.Location = new System.Drawing.Point(128, 63);
            this.pesquisaNome.Name = "pesquisaNome";
            this.pesquisaNome.Size = new System.Drawing.Size(100, 20);
            this.pesquisaNome.TabIndex = 1;
            // 
            // newCNPJ
            // 
            this.newCNPJ.Location = new System.Drawing.Point(128, 109);
            this.newCNPJ.Name = "newCNPJ";
            this.newCNPJ.Size = new System.Drawing.Size(100, 20);
            this.newCNPJ.TabIndex = 2;
            // 
            // newRua
            // 
            this.newRua.Location = new System.Drawing.Point(128, 153);
            this.newRua.Name = "newRua";
            this.newRua.Size = new System.Drawing.Size(100, 20);
            this.newRua.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rua";
            // 
            // newBairro
            // 
            this.newBairro.Location = new System.Drawing.Point(128, 197);
            this.newBairro.Name = "newBairro";
            this.newBairro.Size = new System.Drawing.Size(100, 20);
            this.newBairro.TabIndex = 6;
            // 
            // newCidade
            // 
            this.newCidade.Location = new System.Drawing.Point(128, 242);
            this.newCidade.Name = "newCidade";
            this.newCidade.Size = new System.Drawing.Size(100, 20);
            this.newCidade.TabIndex = 7;
            // 
            // newCEP
            // 
            this.newCEP.Location = new System.Drawing.Point(128, 290);
            this.newCEP.Name = "newCEP";
            this.newCEP.Size = new System.Drawing.Size(100, 20);
            this.newCEP.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "CEP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlterarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newCEP);
            this.Controls.Add(this.newCidade);
            this.Controls.Add(this.newBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newRua);
            this.Controls.Add(this.newCNPJ);
            this.Controls.Add(this.pesquisaNome);
            this.Controls.Add(this.label1);
            this.Name = "AlterarFornecedor";
            this.Text = "AlterarFornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pesquisaNome;
        private System.Windows.Forms.TextBox newCNPJ;
        private System.Windows.Forms.TextBox newRua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newBairro;
        private System.Windows.Forms.TextBox newCidade;
        private System.Windows.Forms.TextBox newCEP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}