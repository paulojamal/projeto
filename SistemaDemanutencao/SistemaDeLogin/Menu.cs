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

        
        public Menu()
        {
            InitializeComponent();
            
        }
        private void Menu_Load(object sender, EventArgs e)
        {
           

            
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
