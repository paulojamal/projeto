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
    public partial class IncluirEquip : Form
    {
        public IncluirEquip()
        {
            InitializeComponent();
        }
        private void IncluirBD()
        {
            try
            {
                ADM_BD_Equip cbd = new ADM_BD_Equip();

                cbd.Inserir(codigo.Text, cliente.Text, tipo.Text, prioridade.Text);
                MessageBox.Show("EQUIPAMENTO INSERIDO !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO NA INSERSÃO !" + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            IncluirBD();
            codigo.Text = "";
            cliente.Text = "";
            tipo.Text = "";
            prioridade.Text = "";
            this.Close();
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
