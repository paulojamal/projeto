using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SistemaDeLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void B_Entrar_Click_1(object sender, EventArgs e)
        {
            ADM_BD adm = new ADM_BD();
            Menu m = new Menu();
            if (adm.Logou(textLogin.Text, textSenha.Text))
            {
                m.Show();
                this.Hide();
            }
            else
            {
                
                ADM_BD_Cliente cli = new ADM_BD_Cliente();
                Menu_Cliente mc = new Menu_Cliente();
                if(cli.Logou(textLogin.Text, textSenha.Text))
                {
                    mc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login ou senha não encontrados");
                }
            }
        }

        private void B_Entrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                B_Entrar_Click_1(sender, e);
            }
        }
    } 
}

