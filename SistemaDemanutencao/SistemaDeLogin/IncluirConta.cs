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

        private void testebd(){

            ADM_BD a = new ADM_BD();
            ArrayList al = new ArrayList();
            al.Add(newLogin.Text);
            al.Add(newSenha.Text);
            if (a.Insert(al))
            {
                MessageBox.Show("USUARIO INSERIDO !");
            }
            else {
                MessageBox.Show("ERRO NA INSERSÃO !");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            testebd();
        }
           
        }
    }
