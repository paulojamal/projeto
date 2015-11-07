namespace SistemaDeLogin
{
    partial class ConsultaUsuarios
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
            this.LV_Usuario = new System.Windows.Forms.ListView();
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Senha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.PSQ_Login = new System.Windows.Forms.TextBox();
            this.PSQ_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Usuario
            // 
            this.LV_Usuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Login,
            this.Senha});
            this.LV_Usuario.FullRowSelect = true;
            this.LV_Usuario.GridLines = true;
            this.LV_Usuario.Location = new System.Drawing.Point(55, 105);
            this.LV_Usuario.Name = "LV_Usuario";
            this.LV_Usuario.Size = new System.Drawing.Size(229, 263);
            this.LV_Usuario.TabIndex = 1;
            this.LV_Usuario.UseCompatibleStateImageBehavior = false;
            this.LV_Usuario.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PSQ_Login
            // 
            this.PSQ_Login.Location = new System.Drawing.Point(25, 40);
            this.PSQ_Login.Name = "PSQ_Login";
            this.PSQ_Login.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Login.TabIndex = 3;
            // 
            // PSQ_Senha
            // 
            this.PSQ_Senha.Location = new System.Drawing.Point(150, 40);
            this.PSQ_Senha.Name = "PSQ_Senha";
            this.PSQ_Senha.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Senha.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PSQ_Senha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PSQ_Login);
            this.groupBox1.Location = new System.Drawing.Point(40, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Funcionários cadastrados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "no sistema";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 542);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LV_Usuario);
            this.Name = "ConsultaUsuarios";
            this.Text = "ConsultaFuncionários";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_Usuario;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Senha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PSQ_Login;
        private System.Windows.Forms.TextBox PSQ_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}