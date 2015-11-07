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
    public partial class IncluirFornecedor : Form
    {
        public IncluirFornecedor()
        {
            InitializeComponent();
        }

        private void IncluirBD()
        {
            try
            {
                ADM_BD_Fornecedor cbd = new ADM_BD_Fornecedor();

                cbd.Inserir(nome.Text, CNPJ.Text, rua.Text, bairro.Text, cidade.Text, CEP.Text);
                MessageBox.Show("FORNECEDOR INSERIDO !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NA INSERSÃO !" + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IncluirBD();
        }
    }
}
