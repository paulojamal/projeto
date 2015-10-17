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
    public partial class ExcluirConta_Cliente : Form
    {
        public ExcluirConta_Cliente()
        {
            InitializeComponent();
        }

        private void ExcluirBD()
        {

            ADM_BD_Cliente a = new ADM_BD_Cliente();
            ArrayList al = new ArrayList();
            a.Excluir(nDel.Text);
            try
            {
                MessageBox.Show("CLIENTE DELETADO !");
            }
            catch
            {
                MessageBox.Show("ERRO !");
            }
        }
        private void Enviar_Click(object sender, EventArgs e)
        {
            ExcluirBD();
        }
    }
}



