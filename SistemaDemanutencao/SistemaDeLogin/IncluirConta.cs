using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaDeLogin
{
    public partial class IncluirConta : Form
    {
        String minhapasta = Environment.CurrentDirectory;
        
        String conexao;

        public IncluirConta()
        {
            InitializeComponent();

            conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + minhapasta + "\\BD_Usuario.mdf;Integrated Security=True";
          

        }
     
        private void IncluirConta_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open();
           
            String inserir = @"insert into tb_Usuarios(NomeUser, SenhaUser) values(@user,@senha)";

            //+newLogin.Text + "', '" + newSenha.Text + "')";
            SqlCommand cmd = new SqlCommand(inserir, con);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = newLogin.Text;
            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = newSenha.Text;

            cmd.ExecuteNonQuery();
               con.Close();
                MessageBox.Show("inclusao concluida");
            }

      
    }
}
