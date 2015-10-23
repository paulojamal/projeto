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
    public partial class Menu : Form
    {
        IncluirConta i = new IncluirConta();
        AlterarConta a = new AlterarConta();
        ExcluirConta exc = new ExcluirConta();
        ConsultaUsuarios c = new ConsultaUsuarios();
        ADM_BD lista = new ADM_BD();
        ADM_BD_Cliente listacli = new ADM_BD_Cliente();
        IncluirConta_Cliente incl = new IncluirConta_Cliente();
        AlterarConta_Cliente alc = new AlterarConta_Cliente();
        ExcluirConta_Cliente excl = new ExcluirConta_Cliente();
        IncluirEquip inequi = new IncluirEquip();
        AlterarEquip alequi = new AlterarEquip();
        ExcluirEquip exclqui = new ExcluirEquip();
        IncluirFornecedor incfor = new IncluirFornecedor();
        AlterarFornecedor altfor = new AlterarFornecedor();
        ExcluirFornecedor excfor = new ExcluirFornecedor();
        public Menu()
        {
            InitializeComponent();

        }
        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void incluirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i.ShowDialog();
        }

        private void alterarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a.ShowDialog();
        }

        private void excuirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
                
        }

        private void incluirContaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            incl.ShowDialog();
        }

        private void alterarContaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alc.ShowDialog();
        }

        private void excluirContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excl.ShowDialog();
        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inequi.ShowDialog();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alequi.ShowDialog();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exclqui.ShowDialog();
        }

        private void incluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            incfor.ShowDialog();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            altfor.ShowDialog();
        }

        private void excluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            excfor.ShowDialog();
        }

        private void lISTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.ShowDialog();
        }
    }

}
