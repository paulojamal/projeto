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
        ADM_BD lista = new ADM_BD();
        ADM_BD_Cliente listacli = new ADM_BD_Cliente();
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


    }

}
