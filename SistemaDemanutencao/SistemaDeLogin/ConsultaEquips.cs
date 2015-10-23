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
            ADM_BD_Equip usu = new ADM_BD_Equip();
            List<ADM_BD_Equip.Equips> lstUsu = new List<ADM_BD_Equip.Equips>();
            lstUsu = usu.Consultar();
            foreach (var itemLista in lstUsu) {
                ListViewItem objListView = new ListViewItem();
                objListView.Text = itemLista.Codigo;
                objListView.SubItems.Add(itemLista.Cliente);
                objListView.SubItems.Add(itemLista.Tipo);
                objListView.SubItems.Add(itemLista.Prioridade);
                LV_Equip.Items.Add(objListView);
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
