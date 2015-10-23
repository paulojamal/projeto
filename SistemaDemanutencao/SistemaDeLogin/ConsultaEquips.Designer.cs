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
            this.LV_Equip.Size = new System.Drawing.Size(439, 332);
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
            // ConsultaEquips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 365);
            this.Controls.Add(this.LV_Equip);
            this.Name = "ConsultaEquips";
            this.Text = "ConsultaUsuarios";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_Equip;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Cliente;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Prioridade;
    }
}