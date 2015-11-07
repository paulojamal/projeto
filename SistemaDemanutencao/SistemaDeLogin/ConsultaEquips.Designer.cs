namespace SistemaDeLogin
{
    partial class ConsultaEquips
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
            this.LV_Equip = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prioridade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PSQ_Cliente = new System.Windows.Forms.TextBox();
            this.PSQ_Codigo = new System.Windows.Forms.TextBox();
            this.PSQ_Tipo = new System.Windows.Forms.TextBox();
            this.PSQ_Prioridade = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_Equip
            // 
            this.LV_Equip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Cliente,
            this.Tipo,
            this.Prioridade});
            this.LV_Equip.FullRowSelect = true;
            this.LV_Equip.GridLines = true;
            this.LV_Equip.Location = new System.Drawing.Point(12, 12);
            this.LV_Equip.Name = "LV_Equip";
            this.LV_Equip.Size = new System.Drawing.Size(434, 332);
            this.LV_Equip.TabIndex = 1;
            this.LV_Equip.UseCompatibleStateImageBehavior = false;
            this.LV_Equip.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 110;
            // 
            // Cliente
            // 
            this.Cliente.Text = "Cliente";
            this.Cliente.Width = 111;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 112;
            // 
            // Prioridade
            // 
            this.Prioridade.Text = "Prioridade";
            this.Prioridade.Width = 97;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PSQ_Cliente);
            this.groupBox1.Controls.Add(this.PSQ_Codigo);
            this.groupBox1.Controls.Add(this.PSQ_Tipo);
            this.groupBox1.Controls.Add(this.PSQ_Prioridade);
            this.groupBox1.Location = new System.Drawing.Point(491, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prioridade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PSQ_Cliente
            // 
            this.PSQ_Cliente.Location = new System.Drawing.Point(19, 88);
            this.PSQ_Cliente.Name = "PSQ_Cliente";
            this.PSQ_Cliente.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Cliente.TabIndex = 3;
            // 
            // PSQ_Codigo
            // 
            this.PSQ_Codigo.Location = new System.Drawing.Point(19, 39);
            this.PSQ_Codigo.Name = "PSQ_Codigo";
            this.PSQ_Codigo.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Codigo.TabIndex = 2;
            // 
            // PSQ_Tipo
            // 
            this.PSQ_Tipo.Location = new System.Drawing.Point(181, 39);
            this.PSQ_Tipo.Name = "PSQ_Tipo";
            this.PSQ_Tipo.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Tipo.TabIndex = 1;
            // 
            // PSQ_Prioridade
            // 
            this.PSQ_Prioridade.Location = new System.Drawing.Point(181, 88);
            this.PSQ_Prioridade.Name = "PSQ_Prioridade";
            this.PSQ_Prioridade.Size = new System.Drawing.Size(100, 20);
            this.PSQ_Prioridade.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Equipamentos cadastrados";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(491, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 52);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Completa";
            // 
            // ConsultaEquips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LV_Equip);
            this.Name = "ConsultaEquips";
            this.Text = "ConsultaEquips";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_Equip;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Cliente;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Prioridade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PSQ_Cliente;
        private System.Windows.Forms.TextBox PSQ_Codigo;
        private System.Windows.Forms.TextBox PSQ_Tipo;
        private System.Windows.Forms.TextBox PSQ_Prioridade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}