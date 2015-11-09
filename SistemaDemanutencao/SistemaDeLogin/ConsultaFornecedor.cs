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
            PSQ_Nome.Text ="";
            PSQ_CNPJ.Text = "";
            PSQ_Rua.Text = "";
            PSQ_Bairro.Text = "";
            PSQ_Cidade.Text = "";
            PSQ_CEP.Text = "";
        }

        private void carregarListView()
        {
            ADM_BD_Fornecedor forn = new ADM_BD_Fornecedor();
            List<ADM_BD_Fornecedor.Fornecedores> lstForn = new List<ADM_BD_Fornecedor.Fornecedores>();
            lstForn = forn.Consultar();
            LV_Fornecedor.Items.Clear();

            foreach (var itemLista in lstForn) {
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

        private void Atualizar_Click(object sender, EventArgs e)
        {
            carregarListView();
        }

        
        private void resultadoPesquisa()
        {
            string nome = PSQ_Nome.Text;
            string cnpj = PSQ_CNPJ.Text;
            string rua = PSQ_Rua.Text;
            string bairro = PSQ_Bairro.Text;
            string cidade = PSQ_Cidade.Text;
            string cep = PSQ_CEP.Text;

            ADM_BD_Fornecedor forn = new ADM_BD_Fornecedor();
            List<ADM_BD_Fornecedor.Fornecedores> lstForn = new List<ADM_BD_Fornecedor.Fornecedores>();
            lstForn = forn.Pesquisar(nome, cnpj, rua, bairro, cidade, cep);
            LV_Fornecedor.Items.Clear();
            foreach (var itemLista in lstForn)
            {
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

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            resultadoPesquisa();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
