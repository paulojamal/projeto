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
    public partial class ConsultaFornecedor : Form
    {
        

        public ConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            carregarListView();

        }

        private void carregarListView()
        {
            ADM_BD_Fornecedor usu = new ADM_BD_Fornecedor();
            List<ADM_BD_Fornecedor.Fornecedores> lstUsu = new List<ADM_BD_Fornecedor.Fornecedores>();
            lstUsu = usu.Consultar();
            foreach (var itemLista in lstUsu) {
                ListViewItem objListView = new ListViewItem();
                objListView.Text = itemLista.Nome;
                objListView.SubItems.Add(itemLista.CNPJ);
                objListView.SubItems.Add(itemLista.Rua);
                objListView.SubItems.Add(itemLista.Bairro);
                objListView.SubItems.Add(itemLista.Cidade);
                objListView.SubItems.Add(itemLista.CEP);

                LV_Fornecedor.Items.Add(objListView);
            }
            
        }

        //private void carregarGrid()
        //{
        //    ADM_BD usu = new ADM_BD();
        //    List<ADM_BD.Usuarios> lstUsu = new List<ADM_BD.Usuarios>();
        //    lstUsu = usu.Consultar();
        //    DGV_Usuarios.DataSource = lstUsu;

        //}
    }
}
