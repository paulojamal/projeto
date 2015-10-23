namespace SistemaDeLogin
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
            this.Bairro,
            this.Cidade,
            this.Estado});
            this.LV_Cliente.FullRowSelect = true;
            this.LV_Cliente.GridLines = true;
            this.LV_Cliente.Location = new System.Drawing.Point(12, 12);
            this.LV_Cliente.Name = "LV_Cliente";
            this.LV_Cliente.Size = new System.Drawing.Size(1091, 332);
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
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 365);
            this.Controls.Add(this.LV_Cliente);
            this.Name = "ConsultaClientes";
            this.Text = "ConsultaClientes";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
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
    }
}