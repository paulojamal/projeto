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
            this.SuspendLayout();
            // 
            // LV_Usuario
            // 
            this.LV_Usuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Login,
            this.Senha});
            this.LV_Usuario.FullRowSelect = true;
            this.LV_Usuario.GridLines = true;
            this.LV_Usuario.Location = new System.Drawing.Point(12, 12);
            this.LV_Usuario.Name = "LV_Usuario";
            this.LV_Usuario.Size = new System.Drawing.Size(225, 332);
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
            // ConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 365);
            this.Controls.Add(this.LV_Usuario);
            this.Name = "ConsultaUsuarios";
            this.Text = "ConsultaUsuarios";
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LV_Usuario;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Senha;
    }
}