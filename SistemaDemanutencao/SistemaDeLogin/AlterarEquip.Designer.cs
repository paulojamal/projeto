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
            this.newPrioridade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newCliente = new System.Windows.Forms.TextBox();
            this.newTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pesquisaCod
            // 
            this.pesquisaCod.Location = new System.Drawing.Point(48, 36);
            this.pesquisaCod.Name = "pesquisaCod";
            this.pesquisaCod.Size = new System.Drawing.Size(100, 20);
            this.pesquisaCod.TabIndex = 0;
            // 
            // newPrioridade
            // 
            this.newPrioridade.Location = new System.Drawing.Point(90, 82);
            this.newPrioridade.Name = "newPrioridade";
            this.newPrioridade.Size = new System.Drawing.Size(100, 20);
            this.newPrioridade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código para modificar os dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nova prioridade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newCliente
            // 
            this.newCliente.Location = new System.Drawing.Point(90, 134);
            this.newCliente.Name = "newCliente";
            this.newCliente.Size = new System.Drawing.Size(100, 20);
            this.newCliente.TabIndex = 5;
            // 
            // newTipo
            // 
            this.newTipo.Location = new System.Drawing.Point(90, 181);
            this.newTipo.Name = "newTipo";
            this.newTipo.Size = new System.Drawing.Size(100, 20);
            this.newTipo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Novo cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Novo tipo";
            // 
            // AlterarEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 267);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newTipo);
            this.Controls.Add(this.newCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPrioridade);
            this.Controls.Add(this.pesquisaCod);
            this.Name = "AlterarEquip";
            this.Text = "AlterarEquip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pesquisaCod;
        private System.Windows.Forms.TextBox newPrioridade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newCliente;
        private System.Windows.Forms.TextBox newTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}