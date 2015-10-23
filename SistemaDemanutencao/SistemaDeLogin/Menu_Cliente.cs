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
    public partial class Menu_Cliente : Form
    {
        AlterarConta_Cliente alc = new AlterarConta_Cliente();
        public Menu_Cliente()
        {
            InitializeComponent();
        }

        private void alterarContaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            alc.ShowDialog();
        }

        private void novoLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
