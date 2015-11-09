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
    public partial class IncluirConta : Form
    {
        public IncluirConta()
        {
            InitializeComponent();
        }
        private void IncluirBD()
        {
            try
            {
                ADM_BD cbd = new ADM_BD();

                cbd.Inserir(newLogin.Text, newSenha.Text);
                MessageBox.Show("USUARIO INSERIDO !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NA INSERSÃO !" + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IncluirBD();
            newLogin.Text = "";
            newSenha.Text = "";
            this.Close();
        }
    }
}
