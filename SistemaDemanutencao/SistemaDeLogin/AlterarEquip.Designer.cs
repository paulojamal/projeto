namespace SistemaDeLogin
{
    partial class AlterarEquip
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
            this.pesquisaCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newCliente = new System.Windows.Forms.TextBox();
            this.newTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newPrioridade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pesquisaCod
            // 
            this.pesquisaCod.Location = new System.Drawing.Point(9, 77);
            this.pesquisaCod.Name = "pesquisaCod";
            this.pesquisaCod.Size = new System.Drawing.Size(100, 20);
            this.pesquisaCod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código para modificar os dados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nova prioridade:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newCliente
            // 
            this.newCliente.Location = new System.Drawing.Point(93, 39);
            this.newCliente.Name = "newCliente";
            this.newCliente.Size = new System.Drawing.Size(100, 20);
            this.newCliente.TabIndex = 5;
            // 
            // newTipo
            // 
            this.newTipo.Location = new System.Drawing.Point(93, 65);
            this.newTipo.Name = "newTipo";
            this.newTipo.Size = new System.Drawing.Size(100, 20);
            this.newTipo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Novo cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Novo tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alterar equipamento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newPrioridade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newCliente);
            this.groupBox1.Controls.Add(this.newTipo);
            this.groupBox1.Location = new System.Drawing.Point(9, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 122);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados para alterar";
            // 
            // newPrioridade
            // 
            this.newPrioridade.FormattingEnabled = true;
            this.newPrioridade.Items.AddRange(new object[] {
            "",
            "Baixa",
            "Média",
            "Alta",
            "Urgente"});
            this.newPrioridade.Location = new System.Drawing.Point(93, 13);
            this.newPrioridade.Name = "newPrioridade";
            this.newPrioridade.Size = new System.Drawing.Size(100, 21);
            this.newPrioridade.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "* campos vazios não irão alterar o antigo valor";
            // 
            // AlterarEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 254);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pesquisaCod);
            this.Name = "AlterarEquip";
            this.Text = "AlterarEquip";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pesquisaCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newCliente;
        private System.Windows.Forms.TextBox newTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox newPrioridade;
    }
}