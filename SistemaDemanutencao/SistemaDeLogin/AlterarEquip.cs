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
    public partial class AlterarEquip : Form
    {
        public AlterarEquip()
        {
            InitializeComponent();
        }
        private void AlterarBD()
        {
            ADM_BD_Equip a = new ADM_BD_Equip();
            a.Atualizar(pesquisaCod.Text, newCliente.Text, newTipo.Text, newPrioridade.Text);
            try
            {
                MessageBox.Show("DADOS MODIFICADOS !");
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO !" + e.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AlterarBD();
            pesquisaCod.Text = "";
            newCliente.Text = "";
            newTipo.Text = "";
            newPrioridade.Text = "";
            this.Close();

        }

        private void AlterarEquip_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
