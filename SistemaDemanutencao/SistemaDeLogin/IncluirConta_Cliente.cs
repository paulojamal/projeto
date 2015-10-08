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
    public partial class IncluirConta_Cliente : Form
    {
        public IncluirConta_Cliente()
        {
            InitializeComponent();
        }

        private void testebd()
        {

            ADM_BD_Cliente a = new ADM_BD_Cliente();
            ArrayList al = new ArrayList();
            al.Add(newLoginCliente.Text);
            al.Add(newSenhaCliente.Text);
            if (a.Insert(al))
            {
                MessageBox.Show("CLIENTE INSERIDO !");
            }
            else
            {
                MessageBox.Show("ERRO NA INSERSÃO !");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            testebd();
        }
    }
}
