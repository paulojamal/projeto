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
    public partial class AlterarConta_Cliente_Logado_Cliente : Form
    {
        public AlterarConta_Cliente_Logado_Cliente()
        {
            InitializeComponent();
        }
        private void AlterarConta_Load(object sender, EventArgs e)
        {

        }
        private void AlterarBD()
        {
            ADM_BD_Cliente a = new ADM_BD_Cliente();
            a.Atualizar(pesquisaLogin.Text, alteraSenha.Text, nome.Text, sobrenome.Text, identidade.Text, telefone.Text, rua.Text, n.Text, bairro.Text, cidade.Text, estado.Text);
            try {
                MessageBox.Show("DADOS MODIFICADOS !");
            }
           catch(Exception e)
            {
                MessageBox.Show("ERRO !"+e.Message);
            }
        }

        private void Enviar_Click_1(object sender, EventArgs e)
        {
            ADM_BD_Cliente cli = new ADM_BD_Cliente();
            Menu_Cliente mc = new Menu_Cliente();
            if (cli.Logou(pesquisaLogin.Text, senhadi.Text) && pesquisaLogin.Text != "" && senhadi.Text !="")
            {
                AlterarBD();
                pesquisaLogin.Text = "";
                alteraSenha.Text = "";
                nome.Text = "";
                sobrenome.Text = "";
                identidade.Text = "";
                telefone.Text = "";
                rua.Text = "";
                n.Text = "";
                bairro.Text = "";
                cidade.Text = "";
                estado.Text = "";
                senhadi.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("LOGIN OU SENHA INCORRETOS !");
                pesquisaLogin.Text = "";
                senhadi.Text = "";
            }
            
        }
    }
}
