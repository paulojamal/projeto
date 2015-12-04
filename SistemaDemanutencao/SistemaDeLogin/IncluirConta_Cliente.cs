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

                cbd.Inserir(newLogin.Text, newSenha.Text, name.Text, sobrenome.Text, id.Text, tel.Text, rua.Text, n.Text, bairro.Text, cidade.Text, estado.Text);
                MessageBox.Show("CLIENTE INSERIDO !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NA INSERSÃO !" + ex.Message);
            }
        }
        private void Enviar_Click(object sender, EventArgs e)
        {
            if (newLogin.Text != "" && newSenha.Text != "" && name.Text != "" && sobrenome.Text != "" && id.Text != "   .   .   -" && tel.Text != "(  )    -" && rua.Text != "" && n.Text != "" && bairro.Text != "" && cidade.Text != "" && estado.Text != "")
            {
                IncluirBD();
                newLogin.Text = "";
                newSenha.Text = "";
                name.Text = "";
                sobrenome.Text = "";
                id.Text = "";
                tel.Text = "";
                rua.Text = "";
                n.Text = "";
                bairro.Text = "";
                cidade.Text = "";
                estado.Text = "";
                this.Close();

            }
            else
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS !");
            }
        }
    }
    }
