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
                MessageBox.Show("Login ou Senha  não encontrado");
            }
        }
    } 
}

