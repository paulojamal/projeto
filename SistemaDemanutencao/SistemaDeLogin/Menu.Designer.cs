﻿namespace SistemaDeLogin
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.opcIncluir = new System.Windows.Forms.ToolStripMenuItem();
            this.opcAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.opcExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.dados = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).BeginInit();
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
            this.tsmUsuarios.Size = new System.Drawing.Size(64, 20);
            this.tsmUsuarios.Text = "Usuários";
            this.tsmUsuarios.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // opcIncluir
            // 
            this.opcIncluir.Name = "opcIncluir";
            this.opcIncluir.Size = new System.Drawing.Size(152, 22);
            this.opcIncluir.Text = "Incluir";
            this.opcIncluir.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // opcAlterar
            // 
            this.opcAlterar.Name = "opcAlterar";
            this.opcAlterar.Size = new System.Drawing.Size(152, 22);
            this.opcAlterar.Text = "Alterar";
            this.opcAlterar.Click += new System.EventHandler(this.opcAlterar_Click);
            // 
            // opcExcluir
            // 
            this.opcExcluir.Name = "opcExcluir";
            this.opcExcluir.Size = new System.Drawing.Size(152, 22);
            this.opcExcluir.Text = "Excluir";
            this.opcExcluir.Click += new System.EventHandler(this.opcExcluir_Click);
            // 
            // tsmClientes
            // 
            this.tsmClientes.Name = "tsmClientes";
            this.tsmClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmClientes.Text = "Clientes";
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
            this.button1.Location = new System.Drawing.Point(61, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exibir Usuários";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dados);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).EndInit();
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
    }
}