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

        private void testebd()
        {

            ADM_BD a = new ADM_BD();
            ArrayList al = new ArrayList();
            al.Add(LoginPesquisar.Text);
            al.Add(SenhaMudar.Text);
            if (a.Update(al))
            {
                MessageBox.Show("SENHA MODIFICADA !");
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
