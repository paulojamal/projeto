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
        private static String _strCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + mp + "\\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";

        public const String strInserir = "INSERT INTO tb_Equip(Codigo, Cliente, Tipo, Prioridade) VALUES(@Codigo, @Cliente, @Tipo, @Prioridade)";
        public const String strExcluir = "DELETE FROM tb_Equip WHERE Codigo = @Codigo";
        public const String strConsultar = "SELECT Codigo , Cliente, Tipo, Prioridade FROM tb_Equip";

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
            String strAlterar = "UPDATE tb_Equip SET Codigo = @Codigo";
            
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                if (Cliente != "")
                {
                    strAlterar += ", Cliente = @Cliente ";
                }
                if (Tipo != "")
                {
                    strAlterar += ", Tipo = @Tipo ";
                }
                if (Prioridade != "")
                {
                    strAlterar += " , Prioridade = @Prioridade ";
                }
               
                    strAlterar += " WHERE Codigo = @Codigo";
                


                using (SqlCommand objCmd = new SqlCommand(strAlterar, objCon))
                {
                    if (Codigo != "")
                    {
                        objCmd.Parameters.AddWithValue("@Codigo", Codigo);
                    }
                    if (Cliente != "")
                    {
                        objCmd.Parameters.AddWithValue("@Cliente",Cliente);
                    }
                    if (Tipo != "")
                    {
                        objCmd.Parameters.AddWithValue("@Tipo",Tipo);
                    }
                    if (Prioridade != "")
                    {
                        objCmd.Parameters.AddWithValue("@Prioridade",Prioridade);
                    }
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
            List<Equips> lstEquips = new List<Equips>();
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
                            Equips objEquips = new Equips();
                            objEquips.Codigo = objDataReader["Codigo"].ToString();
                            objEquips.Cliente = objDataReader["Cliente"].ToString();
                            objEquips.Tipo = objDataReader["Tipo"].ToString();
                            objEquips.Prioridade = objDataReader["Prioridade"].ToString();
                            lstEquips.Add(objEquips);
                        }

                        objCon.Close();
                    }

                    objCon.Close();
                }
                return lstEquips;
            }
        }

        public List<Equips> Pesquisar(String Codigo, String Cliente, String Tipo, String Prioridade)
        {
            string strPesquisa = "SELECT Codigo , Cliente, Tipo, Prioridade FROM tb_Equip WHERE 1=1 ";
            List<Equips> lstEquips = new List<Equips>();
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                if (Codigo != "")
                {
                    strPesquisa += " AND Codigo LIKE @Codigo ";
                }
                if (Cliente != "")
                {
                    strPesquisa += " AND Cliente LIKE @Cliente ";
                }
                if (Tipo != "")
                {
                    strPesquisa += " AND Tipo LIKE @Tipo ";
                }
                if (Prioridade != "")
                {
                    strPesquisa += " AND Prioridade LIKE @Prioridade ";
                }
                using (SqlCommand objCmd = new SqlCommand(strPesquisa, objCon))
                {
                    if (Codigo != "")
                    {
                        objCmd.Parameters.AddWithValue("@Codigo", "%" + Codigo + "%");
                    }
                    if (Cliente != "")
                    {
                        objCmd.Parameters.AddWithValue("@Cliente", "%" + Cliente + "%");
                    }
                    if (Tipo != "")
                    {
                        objCmd.Parameters.AddWithValue("@Tipo", "%" + Tipo + "%");
                    }
                    if (Prioridade != "")
                    {
                        objCmd.Parameters.AddWithValue("@Prioridade", "%" + Prioridade + "%");
                    }



                    objCon.Open();

                    SqlDataReader objDataReader = objCmd.ExecuteReader();
                    if (objDataReader.HasRows)
                    {

                        while (objDataReader.Read())
                        {
                            Equips objEquips = new Equips();
                            objEquips.Codigo = objDataReader["Codigo"].ToString();
                            objEquips.Cliente = objDataReader["Cliente"].ToString();
                            objEquips.Tipo = objDataReader["Tipo"].ToString();
                            objEquips.Prioridade = objDataReader["Prioridade"].ToString();
                            lstEquips.Add(objEquips);
                        }

                        objCon.Close();

                    }


                    objCon.Close();
                }
                return lstEquips;
            }

        }

    }
}