﻿namespace SistemaDeLogin
{
    partial class ConsultaClientes
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
            this.LV_Cliente = new System.Windows.Forms.ListView();
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Senha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PSQ_Sobrenome = new System.Windows.Forms.TextBox();
            this.PSQ_Senha = new System.Windows.Forms.TextBox();
            this.PSQ_Bairro = new System.Windows.Forms.TextBox();
            this.PSQ_Login = new System.Windows.Forms.TextBox();
            this.PSQ_Rua = new System.Windows.Forms.TextBox();
            this.PSQ_Nome = new System.Windows.Forms.TextBox();
            this.PSQ_Cidade = new System.Windows.Forms.TextBox();
            this.PSQ_ID = new System.Windows.Forms.TextBox();
            this.PSQ_Telefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PSQ_Estado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PSQ_Numero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Cliente
            // 
            this.LV_Cliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Login,
            this.Senha,
            this.Nome,
            this.Sobrenome,
            this.ID,
            this.Telefone,
            this.Rua,
            this.Numero,
            this.Bairro,
            this.Cidade,
            this.Estado});
            this.LV_Cliente.FullRowSelect = true;
            this.LV_Cliente.GridLines = true;
            this.LV_Cliente.Location = new System.Drawing.Point(12, 12);
            this.LV_Cliente.Name = "LV_Cliente";
            this.LV_Cliente.Size = new System.Drawing.Size(1152, 332);
            this.LV_Cliente.TabIndex = 1;
            this.LV_Cliente.UseCompatibleStateImageBehavior = false;
            this.LV_Cliente.View = System.Windows.Forms.View.Details;
            // 
            // Login
            // 
            this.Login.Text = "Login";
            this.Login.Width = 110;
            // 
            // Senha
            // 
            this.Senha.Text = "Senha";
            this.Senha.Width = 111;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 149;
            // 
            // Sobrenome
            // 
            this.Sobrenome.Text = "Sobrenome";
            this.Sobrenome.Width = 142;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 84;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 110;
            // 
            // Rua
            // 
            this.Rua.Text = "Rua";
            this.Rua.Width = 115;
            // 
            // Bairro
            // 
            this.Bairro.Text = "Bairro";
            this.Bairro.Width = 106;
            // 
            // Cidade
            // 
            this.Cidade.Text = "Cidade";
            this.Cidade.Width = 104;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            this.Estado.Width = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.PSQ_Numero);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PSQ_Estado);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PSQ_Telefone);
            this.groupBox1.Controls.Add(this.PSQ_ID);
            this.groupBox1.Controls.Add(this.PSQ_Cidade);
            this.groupBox1.Controls.Add(this.PSQ_Nome);
            this.groupBox1.Controls.Add(this.PSQ_Rua);
            this.groupBox1.Controls.Add(this.PSQ_Login);
            this.groupBox1.Controls.Add(this.PSQ_Bairro);
            this.groupBox1.Controls.Add(this.PSQ_Senha);
            this.groupBox1.Controls.Add(this.PSQ_Sobrenome);
            this.groupBox1.Location = new System.Drawing.Point(50, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // PSQ_Sobrenome
            // 
            this.PSQ_Sobrenome.Location = new System.Drawing.Point(205, 97);
            this.PSQ_Sobrenome.Name = "PSQ_Sobrenome";
            this.PSQ_Sobrenome.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Sobrenome.TabIndex = 0;
            // 
            // PSQ_Senha
            // 
            this.PSQ_Senha.Location = new System.Drawing.Point(31, 97);
            this.PSQ_Senha.Name = "PSQ_Senha";
            this.PSQ_Senha.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Senha.TabIndex = 1;
            // 
            // PSQ_Bairro
            // 
            this.PSQ_Bairro.Location = new System.Drawing.Point(660, 42);
            this.PSQ_Bairro.Name = "PSQ_Bairro";
            this.PSQ_Bairro.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Bairro.TabIndex = 2;
            // 
            // PSQ_Login
            // 
            this.PSQ_Login.Location = new System.Drawing.Point(31, 42);
            this.PSQ_Login.Name = "PSQ_Login";
            this.PSQ_Login.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Login.TabIndex = 3;
            // 
            // PSQ_Rua
            // 
            this.PSQ_Rua.Location = new System.Drawing.Point(519, 42);
            this.PSQ_Rua.Name = "PSQ_Rua";
            this.PSQ_Rua.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Rua.TabIndex = 4;
            // 
            // PSQ_Nome
            // 
            this.PSQ_Nome.Location = new System.Drawing.Point(205, 42);
            this.PSQ_Nome.Name = "PSQ_Nome";
            this.PSQ_Nome.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Nome.TabIndex = 5;
            // 
            // PSQ_Cidade
            // 
            this.PSQ_Cidade.Location = new System.Drawing.Point(660, 96);
            this.PSQ_Cidade.Name = "PSQ_Cidade";
            this.PSQ_Cidade.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Cidade.TabIndex = 6;
            // 
            // PSQ_ID
            // 
            this.PSQ_ID.Location = new System.Drawing.Point(382, 42);
            this.PSQ_ID.Name = "PSQ_ID";
            this.PSQ_ID.Size = new System.Drawing.Size(100, 20);
            this.PSQ_ID.TabIndex = 7;
            // 
            // PSQ_Telefone
            // 
            this.PSQ_Telefone.Location = new System.Drawing.Point(382, 97);
            this.PSQ_Telefone.Name = "PSQ_Telefone";
            this.PSQ_Telefone.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Telefone.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sobrenome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(657, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bairro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(657, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cidade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PSQ_Estado
            // 
            this.PSQ_Estado.Location = new System.Drawing.Point(773, 42);
            this.PSQ_Estado.Name = "PSQ_Estado";
            this.PSQ_Estado.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Estado.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(770, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Estado";
            // 
            // Numero
            // 
            this.Numero.Text = "Numero";
            // 
            // PSQ_Numero
            // 
            this.PSQ_Numero.Location = new System.Drawing.Point(519, 97);
            this.PSQ_Numero.Name = "PSQ_Numero";
            this.PSQ_Numero.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Numero.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Numero";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1031, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LV_Cliente);
            this.Name = "ConsultaClientes";
            this.Text = "ConsultaClientes";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_Cliente;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Senha;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Sobrenome;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader Rua;
        private System.Windows.Forms.ColumnHeader Bairro;
        private System.Windows.Forms.ColumnHeader Cidade;
        private System.Windows.Forms.ColumnHeader Estado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PSQ_Estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PSQ_Telefone;
        private System.Windows.Forms.TextBox PSQ_ID;
        private System.Windows.Forms.TextBox PSQ_Cidade;
        private System.Windows.Forms.TextBox PSQ_Nome;
        private System.Windows.Forms.TextBox PSQ_Rua;
        private System.Windows.Forms.TextBox PSQ_Login;
        private System.Windows.Forms.TextBox PSQ_Bairro;
        private System.Windows.Forms.TextBox PSQ_Senha;
        private System.Windows.Forms.TextBox PSQ_Sobrenome;
        private System.Windows.Forms.ColumnHeader Numero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PSQ_Numero;
        private System.Windows.Forms.Button button2;
    }
}