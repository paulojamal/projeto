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
            if(pesquisaCod.Text != "")
            {
                AlterarBD();
                pesquisaCod.Text = "";
                newCliente.Text = "";
                newTipo.Text = "";
                newPrioridade.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("DIGITE O CÓDIGO PARA MUDAR OS DADOS !");
            }


        }
    }
}
