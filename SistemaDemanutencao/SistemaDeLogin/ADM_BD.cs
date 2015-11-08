using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaDeLogin
{
    public class ADM_BD
    {
        public  static string mp = Environment.CurrentDirectory;

        public static string _strCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + mp + "\\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";

        public const String strInserir = "INSERT INTO tb_Usuarios(NomeUser, SenhaUser) VALUES(@NomeUser, @SenhaUser)";
        public const String strExcluir = "DELETE FROM tb_Usuarios WHERE NomeUser = @NomeUser";
        public const String strAlterar = "UPDATE tb_Usuarios SET SenhaUser = @SenhaUser WHERE NomeUser = @NomeUser";
        public const String strSelecionar = "SELECT COUNT(*) FROM tb_Usuarios WHERE NomeUser = @NomeUser AND SenhaUser =@SenhaUser";
        public const string strConsultar = "SELECT NomeUser , SenhaUser FROM tb_Usuarios";
        

        public class Usuarios
        {
            public String NomeUser { get; set; }
            public String SenhaUser { get; set; }


        }
 
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

        public List<Usuarios> Consultar()
        {
            List<Usuarios> lstUsuarios = new List<Usuarios>();
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strConsultar, objCon))
                {
                    objCon.Open();

                    SqlDataReader objDataReader = objCmd.ExecuteReader();
                    if (objDataReader.HasRows)
                    {

                        while (objDataReader.Read())
                        {
                            Usuarios objUsuarios = new Usuarios();
                            objUsuarios.NomeUser = objDataReader["NomeUser"].ToString();
                            objUsuarios.SenhaUser = objDataReader["SenhaUser"].ToString();
                            lstUsuarios.Add(objUsuarios);
                        }

                        objCon.Close();

                    }


                    objCon.Close();
                }
                return lstUsuarios;
            }

        }


               public List<Usuarios> Pesquisar(String Nome, String Senha)
        {
             string strPesquisa = "SELECT NomeUser , SenhaUser FROM tb_Usuarios WHERE 1=1 " ;
            List<Usuarios> lstUsuarios = new List<Usuarios>();
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                if (Nome != "") {
                    strPesquisa += " AND NomeUser LIKE @NomeUser ";
                }
                if (Senha != "")
                {
                    strPesquisa += " AND SenhaUser LIKE @SenhaUser ";
                }
                using (SqlCommand objCmd = new SqlCommand(strPesquisa, objCon))
                {
                    if (Nome != "")
                    {
                        objCmd.Parameters.AddWithValue("@NomeUser", "%" + Nome + "%");
                    }
                    if (Senha != "")
                    {
                        objCmd.Parameters.AddWithValue("@SenhaUser", "%" + Senha + "%");
                    }

                    
                    
                    objCon.Open();

                    SqlDataReader objDataReader = objCmd.ExecuteReader();
                    if (objDataReader.HasRows)
                    {

                        while (objDataReader.Read())
                        {
                            Usuarios objUsuarios = new Usuarios();
                            objUsuarios.NomeUser = objDataReader["NomeUser"].ToString();
                            objUsuarios.SenhaUser = objDataReader["SenhaUser"].ToString();
                            lstUsuarios.Add(objUsuarios);
                        }

                        objCon.Close();

                    }


                    objCon.Close();
                }
                return lstUsuarios;
            }

        }
        }
}


