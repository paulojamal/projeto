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
        private void IncluirBD()
        {
            try
            {
                ADM_BD_Cliente cbd = new ADM_BD_Cliente();

                cbd.Inserir(newLogin.Text, newSenha.Text);
                MessageBox.Show("CLIENTE INSERIDO !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NA INSERSÃO !" + ex.Message);
            }
        }

        private void Enviar_Click_1(object sender, EventArgs e)
        {
            IncluirBD();
        }
    }
    }
