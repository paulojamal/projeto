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
    class ADM_BD_Equip
    {
        static String mp = Environment.CurrentDirectory;
        private static string _strCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + mp + "\\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";

        public const String strInserir = "INSERT INTO tb_Equip(Codigo, Cliente, Tipo, Prioridade) VALUES(@Codigo, @Cliente, @Tipo, @Prioridade)";
        public const String strExcluir = "DELETE FROM tb_Equip WHERE Codigo = @Codigo";
        public const String strAlterar = "UPDATE tb_Equip SET Cliente = @Cliente , Tipo = @Tipo ,  Prioridade = @Prioridade WHERE Codigo = @Codigo";
        public const string strConsultar = "SELECT Codigo , Cliente, Tipo, Prioridade FROM tb_Equip";

        public class Equips
        {
            public String Codigo { get; set; }
            public String Cliente { get; set; }
            public String Tipo { get; set; }
            public String Prioridade { get; set; }


        }

        public void Inserir(String Codigo, String Cliente, String Tipo, String Prioridade)
        {
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strInserir, objCon))
                {
                    objCmd.Parameters.AddWithValue("@Codigo", Codigo);
                    objCmd.Parameters.AddWithValue("@Cliente", Cliente);
                    objCmd.Parameters.AddWithValue("@Tipo", Tipo);
                    objCmd.Parameters.AddWithValue("@Prioridade", Prioridade);
                    objCon.Open();
                    objCmd.ExecuteNonQuery();
                    objCon.Close();
                }

            }

        }

        public void Atualizar(String Codigo, String Cliente, String Tipo, String Prioridade)
        {

            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strAlterar, objCon))
                {

                    objCmd.Parameters.AddWithValue("@Codigo", Codigo);
                    objCmd.Parameters.AddWithValue("@Cliente", Cliente);
                    objCmd.Parameters.AddWithValue("@Tipo", Tipo);
                    objCmd.Parameters.AddWithValue("@Prioridade", Prioridade);
                    objCon.Open();
                    objCmd.ExecuteNonQuery();
                    objCon.Close();
                }

            }
        }

        public void Excluir(String Codigo)
        {

            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strExcluir, objCon))
                {

                    objCmd.Parameters.AddWithValue("@Codigo", Codigo);
                    objCon.Open();
                    objCmd.ExecuteNonQuery();
                    objCon.Close();
                }

            }
        }



        public List<Equips> Consultar()
        {
            List<Equips> lstUsuarios = new List<Equips>();
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
                            Equips objUsuarios = new Equips();
                            objUsuarios.Codigo = objDataReader["Codigo"].ToString();
                            objUsuarios.Cliente = objDataReader["Cliente"].ToString();
                            objUsuarios.Tipo = objDataReader["Tipo"].ToString();
                            objUsuarios.Prioridade = objDataReader["Prioridade"].ToString();
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