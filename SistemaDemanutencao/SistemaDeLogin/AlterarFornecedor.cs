using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeLogin
{
    public partial class AlterarFornecedor : Form
    {
        public AlterarFornecedor()
        {
            InitializeComponent();
        }
        private void AlterarBD()
        {
            ADM_BD_Fornecedor a = new ADM_BD_Fornecedor();
            a.Atualizar(pesquisaNome.Text, newCNPJ.Text, newRua.Text, newBairro.Text, newCidade.Text, newCEP.Text);
            try
            {
                MessageBox.Show("DADOS MODIFICADOS !");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO !" + e.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AlterarBD();
            pesquisaNome.Text = "";
            newCNPJ.Text = "";
            newRua.Text = "";
            newBairro.Text = "";
            newCidade.Text = "";
            newCEP.Text = "";
            this.Close();
        }
    }
}
