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
    public partial class ExcluirConta : Form
    {
        public ExcluirConta()
        {
            InitializeComponent();
        }

        private void ExcluirBD()
        {

            ADM_BD a = new ADM_BD();
            ArrayList al = new ArrayList();
            a.Excluir(nDel.Text);
            try
            {
                MessageBox.Show("USUARIO DELETADO !");
            }
            catch
            {
                MessageBox.Show("ERRO !");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ExcluirBD();
        }
    }
}
