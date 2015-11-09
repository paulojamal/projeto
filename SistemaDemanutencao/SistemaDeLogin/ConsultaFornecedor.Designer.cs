namespace SistemaDeLogin
{
    partial class ConsultaFornecedor
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
            this.LV_Fornecedor = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNPJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CEP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.PSQ_Bairro = new System.Windows.Forms.TextBox();
            this.PSQ_Cidade = new System.Windows.Forms.TextBox();
            this.PSQ_CEP = new System.Windows.Forms.TextBox();
            this.PSQ_Nome = new System.Windows.Forms.TextBox();
            this.PSQ_CNPJ = new System.Windows.Forms.TextBox();
            this.PSQ_Rua = new System.Windows.Forms.TextBox();
            this.Atualizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Fornecedor
            // 
            this.LV_Fornecedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.CNPJ,
            this.Rua,
            this.Bairro,
            this.Cidade,
            this.CEP});
            this.LV_Fornecedor.FullRowSelect = true;
            this.LV_Fornecedor.GridLines = true;
            this.LV_Fornecedor.Location = new System.Drawing.Point(12, 57);
            this.LV_Fornecedor.Name = "LV_Fornecedor";
            this.LV_Fornecedor.Size = new System.Drawing.Size(460, 350);
            this.LV_Fornecedor.TabIndex = 1;
            this.LV_Fornecedor.UseCompatibleStateImageBehavior = false;
            this.LV_Fornecedor.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 110;
            // 
            // CNPJ
            // 
            this.CNPJ.Text = "CNPJ";
            this.CNPJ.Width = 111;
            // 
            // Rua
            // 
            this.Rua.Text = "Rua";
            this.Rua.Width = 138;
            // 
            // Bairro
            // 
            this.Bairro.Text = "Bairro";
            this.Bairro.Width = 140;
            // 
            // Cidade
            // 
            this.Cidade.Text = "Cidade";
            this.Cidade.Width = 114;
            // 
            // CEP
            // 
            this.CEP.Text = "CEP";
            this.CEP.Width = 122;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Pesquisar);
            this.groupBox1.Controls.Add(this.PSQ_Bairro);
            this.groupBox1.Controls.Add(this.PSQ_Cidade);
            this.groupBox1.Controls.Add(this.PSQ_CEP);
            this.groupBox1.Controls.Add(this.PSQ_Nome);
            this.groupBox1.Controls.Add(this.PSQ_CNPJ);
            this.groupBox1.Controls.Add(this.PSQ_Rua);
            this.groupBox1.Location = new System.Drawing.Point(478, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rua:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CNPJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(11, 187);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.Pesquisar.TabIndex = 6;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // PSQ_Bairro
            // 
            this.PSQ_Bairro.Location = new System.Drawing.Point(11, 84);
            this.PSQ_Bairro.Name = "PSQ_Bairro";
            this.PSQ_Bairro.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Bairro.TabIndex = 5;
            // 
            // PSQ_Cidade
            // 
            this.PSQ_Cidade.Location = new System.Drawing.Point(127, 35);
            this.PSQ_Cidade.Name = "PSQ_Cidade";
            this.PSQ_Cidade.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Cidade.TabIndex = 4;
            // 
            // PSQ_CEP
            // 
            this.PSQ_CEP.Location = new System.Drawing.Point(127, 129);
            this.PSQ_CEP.Name = "PSQ_CEP";
            this.PSQ_CEP.Size = new System.Drawing.Size(100, 20);
            this.PSQ_CEP.TabIndex = 3;
            // 
            // PSQ_Nome
            // 
            this.PSQ_Nome.Location = new System.Drawing.Point(11, 35);
            this.PSQ_Nome.Name = "PSQ_Nome";
            this.PSQ_Nome.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Nome.TabIndex = 2;
            // 
            // PSQ_CNPJ
            // 
            this.PSQ_CNPJ.Location = new System.Drawing.Point(11, 129);
            this.PSQ_CNPJ.Name = "PSQ_CNPJ";
            this.PSQ_CNPJ.Size = new System.Drawing.Size(100, 20);
            this.PSQ_CNPJ.TabIndex = 1;
            // 
            // PSQ_Rua
            // 
            this.PSQ_Rua.Location = new System.Drawing.Point(127, 84);
            this.PSQ_Rua.Name = "PSQ_Rua";
            this.PSQ_Rua.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Rua.TabIndex = 0;
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(6, 19);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 13;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fornecedores cadastrados";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Atualizar);
            this.groupBox2.Location = new System.Drawing.Point(478, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 60);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Completa";
            // 
            // ConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LV_Fornecedor);
            this.Name = "ConsultaFornecedor";
            this.Text = "ConsultaFornecedor";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_Fornecedor;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader CNPJ;
        private System.Windows.Forms.ColumnHeader Rua;
        private System.Windows.Forms.ColumnHeader Bairro;
        private System.Windows.Forms.ColumnHeader Cidade;
        private System.Windows.Forms.ColumnHeader CEP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.TextBox PSQ_Bairro;
        private System.Windows.Forms.TextBox PSQ_Cidade;
        private System.Windows.Forms.TextBox PSQ_CEP;
        private System.Windows.Forms.TextBox PSQ_Nome;
        private System.Windows.Forms.TextBox PSQ_CNPJ;
        private System.Windows.Forms.TextBox PSQ_Rua;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}