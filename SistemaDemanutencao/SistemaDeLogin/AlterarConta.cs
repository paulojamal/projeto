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
    public partial class AlterarConta : Form
    {
        public AlterarConta()
        {
            InitializeComponent();
        }
        private void AlterarConta_Load(object sender, EventArgs e)
        {

        }
        private void AlterarBD()
        {
            ADM_BD a = new ADM_BD();
            a.Atualizar(pesquisaLogin.Text, alteraSenha.Text);
            try {
                MessageBox.Show("SENHA MODIFICADA !");
            }
           catch(Exception e)
            {
                MessageBox.Show("ERRO !"+e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pesquisaLogin.Text != "" && alteraSenha.Text != "")
            {
                AlterarBD();

                pesquisaLogin.Text = "";
                alteraSenha.Text = "";

                this.Close();
            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS CORRETAMENTE !");
            }

        }
    }
}
