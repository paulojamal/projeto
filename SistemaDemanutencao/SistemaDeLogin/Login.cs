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
        Menu m = new Menu();      

        private void B_Entrar_Click_1(object sender, EventArgs e)
        {
            ADM_BD adm = new ADM_BD();
            ArrayList al = new ArrayList();
            al.Add(textLogin.Text);
            al.Add(textSenha.Text);

            if (adm.Logou(al))
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

    /*
         public void Login_KeyDown(object sender, KeyEventArgs e) { 
            if (e.KeyCode  == Keys.Enter)
            B_Entrar_Click1(sender, null);
        }
      */  
       
    }

