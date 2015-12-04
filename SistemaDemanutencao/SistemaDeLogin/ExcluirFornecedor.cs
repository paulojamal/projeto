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
    public partial class ExcluirFornecedor : Form
    {
        public ExcluirFornecedor()
        {
            InitializeComponent();
        }
        private void ExcluirBD()
        {

            ADM_BD_Fornecedor a = new ADM_BD_Fornecedor();
            
            a.Excluir(excNome.Text);
            try
            {
                MessageBox.Show("FORNECEDOR DELETADO !");
            }
            catch
            {
                MessageBox.Show("ERRO !");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (excNome.Text != "")
            {
                ExcluirBD();
                excNome.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("DIGITE O NOME DO FORNECEDOR PARA DELETAR !");
            }

        }
    }
}
