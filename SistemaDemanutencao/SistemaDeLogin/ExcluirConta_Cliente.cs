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

        private void testebd()
        {

            ADM_BD_Cliente a = new ADM_BD_Cliente();
            ArrayList al = new ArrayList();
            al.Add(nomeDelCli.Text);
            if (a.Delete(al))
            {
                MessageBox.Show("CLIENTE DELETADO !");
            }
            else
            {
                MessageBox.Show("ERRO !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testebd();
        }
    }
}
