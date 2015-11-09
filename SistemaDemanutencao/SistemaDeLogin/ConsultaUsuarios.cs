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
    public partial class ConsultaUsuarios : Form
    {
        
        public ConsultaUsuarios()
        {
            InitializeComponent();
            
        }
        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            carregarListView();
            PSQ_Login.Text = "";
            PSQ_Senha.Text = "";
        }
        private void carregarListView()
        {
            ADM_BD usu = new ADM_BD();
            List<ADM_BD.Usuarios> lstUsu = new List<ADM_BD.Usuarios>();
            lstUsu = usu.Consultar();
            LV_Usuario.Items.Clear();
            foreach (var itemLista in lstUsu) {
                ListViewItem objListView = new ListViewItem();
                objListView.Text = itemLista.NomeUser;
                objListView.SubItems.Add(itemLista.SenhaUser);

                LV_Usuario.Items.Add(objListView);
                
            }            
        }

        private void resultadoPesquisa()
        {
            string login = PSQ_Login.Text;
            string senha = PSQ_Senha.Text;

            ADM_BD usu = new ADM_BD();
            List<ADM_BD.Usuarios> lstUsu = new List<ADM_BD.Usuarios>();
            lstUsu = usu.Pesquisar(login, senha);
            LV_Usuario.Items.Clear();
            foreach (var itemLista in lstUsu)
            {
                ListViewItem objListView = new ListViewItem();
                objListView.Text = itemLista.NomeUser;
                objListView.SubItems.Add(itemLista.SenhaUser);

                LV_Usuario.Items.Add(objListView);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultadoPesquisa();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            carregarListView();
        }
    }
}
