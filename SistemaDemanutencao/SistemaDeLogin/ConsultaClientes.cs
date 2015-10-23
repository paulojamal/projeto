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
                objListView.SubItems.Add(itemLista.Name);
                objListView.SubItems.Add(itemLista.Sobrenome);
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
    }
}
