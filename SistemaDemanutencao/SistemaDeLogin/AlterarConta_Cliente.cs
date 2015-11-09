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
    public partial class AlterarConta_Cliente : Form
    {
        public AlterarConta_Cliente()
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
            AlterarBD();
            pesquisaLogin.Text = "";
            alteraSenha.Text = "";
            nome.Text = "";
            sobrenome.Text= "";
            identidade.Text = "";
            telefone.Text = "";
            rua.Text = "";
            n.Text = "";
            bairro.Text = "";
            cidade.Text = "";
            estado.Text = "";
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pesquisaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void AlterarConta_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
