using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaDeLogin
{
    public class ADM_BD
    {
        static String mp = Environment.CurrentDirectory;
        //private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mp + "\\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
            //String Guilherme:
            //private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme\Desktop\projeto\projeto\SistemaDemanutencao\SistemaDeLogin\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";

        private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme\Desktop\projeto\projeto\SistemaDemanutencao\SistemaDeLogin\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";

        public const String strInserir = "INSERT INTO tb_Usuarios(NomeUser, SenhaUser) VALUES(@NomeUser, @SenhaUser)";
        public const String strExcluir = "DELETE FROM tb_Usuarios WHERE NomeUser = @NomeUser";
        public const String strAlterar = "UPDATE tb_Usuarios SET SenhaUser = @SenhaUser WHERE NomeUser = @NomeUser";
        public const String strSelecionar = "SELECT COUNT(*) FROM tb_Usuarios WHERE NomeUser = @NomeUser AND SenhaUser =@SenhaUser";
        public void Inserir(String Nome, String Senha)
        {
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strInserir, objCon))
                {
                    objCmd.Parameters.AddWithValue("@NomeUser", Nome);
                    objCmd.Parameters.AddWithValue("@SenhaUser", Senha);
                    objCon.Open();
                    objCmd.ExecuteNonQuery();
                    objCon.Close();
                }

            }

        }

        public void Atualizar(String Nome, String Senha)
        {

            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strAlterar, objCon))
                {

                    objCmd.Parameters.AddWithValue("@NomeUser", Nome);
                    objCmd.Parameters.AddWithValue("@SenhaUser", Senha);
                    objCon.Open();
                    objCmd.ExecuteNonQuery();
                    objCon.Close();
                }

            }
        }

        public void Excluir(String Nome)
        {

            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strExcluir, objCon))
                {

                    objCmd.Parameters.AddWithValue("@NomeUser", Nome);
                    objCon.Open();
                    objCmd.ExecuteNonQuery();
                    objCon.Close();
                }

            }
        }

        public DataTable Listar(){

            /* using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strSelecionar, objCon)) //testar objCon, strSelecionar 
                {


                    SqlDataAdapter adp = new SqlDataAdapter(objCmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;

                }

            }*/
            try
            {
                SqlConnection objCon = new SqlConnection(_strCon);
                SqlCommand objcmd = null;
                objcmd = new SqlCommand(strSelecionar, objCon);
                SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch(SqlException sqlerr)
            {
                throw sqlerr;
            }

            
       }

        public bool Logou(String Nome, String Senha)
        {

            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strSelecionar, objCon))
                {
                    objCmd.Parameters.AddWithValue("@NomeUser", Nome);
                    objCmd.Parameters.AddWithValue("@SenhaUser", Senha);
                    objCon.Open();

                    int i = (int)objCmd.ExecuteScalar();
                    if (i > 0)
                    {
                        objCon.Close();
                        return true;
                    }
                    else
                    {
                        objCon.Close();
                        return false;
                    }
                }
            }
        }
    }
}


