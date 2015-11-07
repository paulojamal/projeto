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
    public partial class ConsultaEquips : Form
    {
        

        public ConsultaEquips()
        {
            InitializeComponent();
            
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {

            carregarListView();
        }

        private void carregarListView()
        {
            ADM_BD_Equip equip = new ADM_BD_Equip();
            List<ADM_BD_Equip.Equips> lstEquip = new List<ADM_BD_Equip.Equips>();
            lstEquip = equip.Consultar();
            LV_Equip.Items.Clear();
            foreach (var itemLista in lstEquip) {
                ListViewItem objListView = new ListViewItem();
                objListView.Text = itemLista.Codigo;
                objListView.SubItems.Add(itemLista.Cliente);
                objListView.SubItems.Add(itemLista.Tipo);
                objListView.SubItems.Add(itemLista.Prioridade);
                LV_Equip.Items.Add(objListView);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carregarListView();
        }

        
        private void resultadoPesquisa()
        {
            string codigo = PSQ_Codigo.Text;
            string cliente = PSQ_Cliente.Text;
            string tipo = PSQ_Tipo.Text;
            string prioridade = PSQ_Prioridade.Text;

            ADM_BD_Equip equip = new ADM_BD_Equip();
            List<ADM_BD_Equip.Equips> lstEquip = new List<ADM_BD_Equip.Equips>();
            lstEquip = equip.Pesquisar(codigo, cliente, tipo, prioridade);
            LV_Equip.Items.Clear();
            foreach (var itemLista in lstEquip)
            {
                ListViewItem objListView = new ListViewItem();
                objListView.Text = itemLista.Codigo;
                objListView.SubItems.Add(itemLista.Cliente);
                objListView.SubItems.Add(itemLista.Tipo);
                objListView.SubItems.Add(itemLista.Prioridade);
                LV_Equip.Items.Add(objListView);


                


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultadoPesquisa();
        }


    }
}
