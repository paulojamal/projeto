namespace SistemaDeLogin
{
    partial class Menu_Cliente
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarContaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(443, 24);
            this.menuStrip3.TabIndex = 1;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarContaToolStripMenuItem1,
            this.novoLoginToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.clientesToolStripMenuItem.Text = "Opções";
            // 
            // alterarContaToolStripMenuItem1
            // 
            this.alterarContaToolStripMenuItem1.Name = "alterarContaToolStripMenuItem1";
            this.alterarContaToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.alterarContaToolStripMenuItem1.Text = "Alterar conta";
            this.alterarContaToolStripMenuItem1.Click += new System.EventHandler(this.alterarContaToolStripMenuItem1_Click);
            // 
            // novoLoginToolStripMenuItem
            // 
            this.novoLoginToolStripMenuItem.Name = "novoLoginToolStripMenuItem";
            this.novoLoginToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.novoLoginToolStripMenuItem.Text = "Novo login";
            this.novoLoginToolStripMenuItem.Click += new System.EventHandler(this.novoLoginToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sistema de manutenção";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bem-Vindo! Você está logado com privilégios de um cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Menu_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 191);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip3);
            this.Name = "Menu_Cliente";
            this.Text = "Menu_Cliente";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarContaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoLoginToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}