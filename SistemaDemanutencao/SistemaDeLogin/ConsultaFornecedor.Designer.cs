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
            this.LV_Fornecedor.Location = new System.Drawing.Point(12, 12);
            this.LV_Fornecedor.Name = "LV_Fornecedor";
            this.LV_Fornecedor.Size = new System.Drawing.Size(745, 332);
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
            // ConsultaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 365);
            this.Controls.Add(this.LV_Fornecedor);
            this.Name = "ConsultaFornecedor";
            this.Text = "ConsultaFornecedor";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_Fornecedor;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader CNPJ;
        private System.Windows.Forms.ColumnHeader Rua;
        private System.Windows.Forms.ColumnHeader Bairro;
        private System.Windows.Forms.ColumnHeader Cidade;
        private System.Windows.Forms.ColumnHeader CEP;
    }
}