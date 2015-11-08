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
    public partial class ConsultaClientes : Form
    {
        

        public ConsultaClientes()
        {
            InitializeComponent();
           
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            carregarListView();
        }
        private void carregarListView(){

            ADM_BD_Cliente cli = new ADM_BD_Cliente();
            List<ADM_BD_Cliente.Clientes> lstCli = new List<ADM_BD_Cliente.Clientes>();
            lstCli = cli.Consultar();
            LV_Cliente.Items.Clear();

            foreach (var itemLista in lstCli) {
                
                ListViewItem objListView = new ListViewItem();

                objListView.Text = itemLista.NomeUser;
                objListView.SubItems.Add(itemLista.SenhaUser);
                objListView.SubItems.Add(itemLista.Nome);
                objListView.SubItems.Add(itemLista.SobreNome);
                objListView.SubItems.Add(itemLista.ID);
                objListView.SubItems.Add(itemLista.Telefone);
                objListView.SubItems.Add(itemLista.Rua);
                objListView.SubItems.Add(itemLista.Numero);
                objListView.SubItems.Add(itemLista.Bairro);
                objListView.SubItems.Add(itemLista.Cidade);
                objListView.SubItems.Add(itemLista.Estado);

                LV_Cliente.Items.Add(objListView);
            }
        }
        
        private void resultadoPesquisa()
        {
            string login = PSQ_Login.Text;
            string senha = PSQ_Senha.Text;
            string nome = PSQ_Nome.Text;
            string sobrenome = PSQ_Sobrenome.Text;
            string id = PSQ_ID.Text;
            string telefone = PSQ_Telefone.Text;
            string rua = PSQ_Rua.Text;
            string numero = PSQ_Numero.Text;
            string bairro = PSQ_Bairro.Text;
            string cidade = PSQ_Cidade.Text;
            string estado = PSQ_Estado.Text;

            ADM_BD_Cliente cli = new ADM_BD_Cliente();
            List<ADM_BD_Cliente.Clientes> lstCli = new List<ADM_BD_Cliente.Clientes>();
            lstCli = cli.Pesquisar(login, senha, nome, sobrenome, id, telefone, rua, numero, bairro, cidade, estado);
            LV_Cliente.Items.Clear();
            foreach (var itemLista in lstCli)
            {
                ListViewItem objListView = new ListViewItem();
                objListView.Text = itemLista.NomeUser;
                objListView.SubItems.Add(itemLista.SenhaUser);
                objListView.SubItems.Add(itemLista.Nome);
                objListView.SubItems.Add(itemLista.SobreNome);
                objListView.SubItems.Add(itemLista.ID);
                objListView.SubItems.Add(itemLista.Telefone);
                objListView.SubItems.Add(itemLista.Rua);
                objListView.SubItems.Add(itemLista.Numero);
                objListView.SubItems.Add(itemLista.Bairro);
                objListView.SubItems.Add(itemLista.Cidade);
                objListView.SubItems.Add(itemLista.Estado);

                LV_Cliente.Items.Add(objListView);


                


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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PSQ_Cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PSQ_Estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PSQ_Rua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
