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
    public partial class ExcluirEquip : Form
    {
        public ExcluirEquip()
        {
            InitializeComponent();
        }
        private void ExcluirBD()
        {

            ADM_BD_Equip a = new ADM_BD_Equip();
            
            a.Excluir(excCodigo.Text);
            try
            {
                MessageBox.Show("EQUIPAMENTO DELETADO !");
            }
            catch
            {
                MessageBox.Show("ERRO !");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExcluirBD();
            excCodigo.Text = "";
            this.Close();
        }
    }
}
