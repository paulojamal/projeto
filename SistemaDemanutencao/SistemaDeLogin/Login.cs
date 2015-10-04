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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        Menu m = new Menu();
       
        private void button1_Click(object sender, EventArgs e)
        {

         String minhaPasta = Environment.CurrentDirectory;
           String conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+minhaPasta+ "\\BD_Usuario.mdf;Integrated Security=True";
           SqlConnection conn = new SqlConnection(conexao);
           SqlCommand comando = new SqlCommand("SELECT COUNT(*) FROM tb_Usuarios WHERE NomeUser = @user AND SenhaUser =@senha", conn);

            comando.Parameters.Add("@user", SqlDbType.VarChar).Value = textBox1.Text;
            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = textBox2.Text;

            conn.Open();
            int i = (int)comando.ExecuteScalar();

            if (i > 0)
            {
                m.Show();
                this.Hide();
                   
            }
            else
            {
                MessageBox.Show("Login ou Senha  não encontrado");

            }
            conn.Close();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode  == Keys.Enter)
            button1_Click(sender, null);
        }
    }
}
