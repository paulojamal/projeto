namespace SistemaDeLogin
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
    //    private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.opcIncluir = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excuirContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsuarios,
            this.tsmClientes});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(790, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tsmUsuarios
            // 
            this.tsmUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcIncluir,
            this.opcAlterar,
            this.opcExcluir});
            this.tsmUsuarios.Name = "tsmUsuarios";
            this.tsmUsuarios.Size = new System.Drawing.Size(87, 20);
            this.tsmUsuarios.Text = "Funcionários";
            // 
            // opcIncluir
            // 
            this.opcIncluir.Name = "opcIncluir";
            this.opcIncluir.Size = new System.Drawing.Size(143, 22);
            this.opcIncluir.Text = "Incluir";
            // 
            // opcAlterar
            // 
            this.opcAlterar.Name = "opcAlterar";
            this.opcAlterar.Size = new System.Drawing.Size(143, 22);
            this.opcAlterar.Text = "Alterar senha";
            // 
            // opcExcluir
            // 
            this.opcExcluir.Name = "opcExcluir";
            this.opcExcluir.Size = new System.Drawing.Size(143, 22);
            this.opcExcluir.Text = "Excluir";
            // 
            // tsmClientes
            // 
            this.tsmClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.tsmClientes.Name = "tsmClientes";
            this.tsmClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmClientes.Text = "Clientes";
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.incluirToolStripMenuItem.Text = "Incluir";
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alterarToolStripMenuItem.Text = "Alterar senha";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // dados
            // 
            this.dados.AllowUserToAddRows = false;
            this.dados.AllowUserToDeleteRows = false;
            this.dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dados.Location = new System.Drawing.Point(160, 66);
            this.dados.Name = "dados";
            this.dados.ReadOnly = true;
            this.dados.Size = new System.Drawing.Size(630, 500);
            this.dados.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exibir Funcionários";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exibir Clientes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(629, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirContaToolStripMenuItem,
            this.alterarContaToolStripMenuItem,
            this.excuirContaToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // incluirContaToolStripMenuItem
            // 
            this.incluirContaToolStripMenuItem.Name = "incluirContaToolStripMenuItem";
            this.incluirContaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.incluirContaToolStripMenuItem.Text = "Incluir Conta";
            this.incluirContaToolStripMenuItem.Click += new System.EventHandler(this.incluirContaToolStripMenuItem_Click);
            // 
            // alterarContaToolStripMenuItem
            // 
            this.alterarContaToolStripMenuItem.Name = "alterarContaToolStripMenuItem";
            this.alterarContaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alterarContaToolStripMenuItem.Text = "Alterar Conta";
            this.alterarContaToolStripMenuItem.Click += new System.EventHandler(this.alterarContaToolStripMenuItem_Click);
            // 
            // excuirContaToolStripMenuItem
            // 
            this.excuirContaToolStripMenuItem.Name = "excuirContaToolStripMenuItem";
            this.excuirContaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.excuirContaToolStripMenuItem.Text = "Excuir Conta";
            this.excuirContaToolStripMenuItem.Click += new System.EventHandler(this.excuirContaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(629, 311);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem opcIncluir;
        private System.Windows.Forms.ToolStripMenuItem tsmClientes;
        private System.Windows.Forms.ToolStripMenuItem opcAlterar;
        private System.Windows.Forms.ToolStripMenuItem opcExcluir;
        private System.Windows.Forms.DataGridView dados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excuirContaToolStripMenuItem;
    }
}