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
    public class ADM_BD_Fornecedor
    {
        static String mp = Environment.CurrentDirectory;
        private static string _strCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + mp + "\\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";

        public const String strInserir = "INSERT INTO tb_Fornecedor(Nome, CNPJ, Rua, Bairro, Cidade, CEP) VALUES(@Nome, @CNPJ, @Rua, @Bairro, @Cidade, @CEP)";
        public const String strExcluir = "DELETE FROM tb_Fornecedor WHERE Nome = @Nome";
        public const String strAlterar = "UPDATE tb_Fornecedor SET CNPJ = @CNPJ ,  Rua = @Rua , Bairro = @Bairro  , Cidade = @Cidade , CEP = @CEP WHERE Nome = @Nome";
        public const String strSelecionar = "SELECT COUNT(*) FROM tb_Fornecedor WHERE Nome = @Nome";
        public const string strConsultar = "SELECT Nome , CNPJ , Rua, Bairro, Cidade, CEP FROM tb_Fornecedor";
        public void Inserir(String Nome, String CNPJ, String Rua, String Bairro, String Cidade, String CEP)
        {
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strInserir, objCon))
                {
                    objCmd.Parameters.AddWithValue("@Nome", Nome);
                    objCmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                    objCmd.Parameters.AddWithValue("@Rua", Rua);
                    objCmd.Parameters.AddWithValue("@Bairro", Bairro);
                    objCmd.Parameters.AddWithValue("@Cidade", Cidade);
                    objCmd.Parameters.AddWithValue("@CEP", CEP);
                    objCon.Open();
                    objCmd.ExecuteNonQuery();
                    objCon.Close();
                }

            }

        }

        public void Atualizar(String Nome, String CNPJ, String Rua, String Bairro, String Cidade, String CEP)
        {

            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strAlterar, objCon))
                {

                    objCmd.Parameters.AddWithValue("@Nome", Nome);
                    objCmd.Parameters.AddWithValue("@CNPJ", CNPJ);
                    objCmd.Parameters.AddWithValue("@Rua", Rua);
                    objCmd.Parameters.AddWithValue("@Bairro", Bairro);
                    objCmd.Parameters.AddWithValue("@Cidade", Cidade);
                    objCmd.Parameters.AddWithValue("@CEP", CEP);
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

                    objCmd.Parameters.AddWithValue("@Nome", Nome);
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
        public class Fornecedores
        {
            public String Nome { get; set; }
            public String CNPJ { get; set; }
            public String Rua { get; set; }
            public String Bairro { get; set; }
            public String Cidade { get; set; }
            public String CEP { get; set; }

        }
        public List<Fornecedores> Consultar()
        {
            List<Fornecedores> lstFornecedores = new List<Fornecedores>();
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
                            Fornecedores objFornecedores = new Fornecedores();
                            objFornecedores.Nome = objDataReader["Nome"].ToString();
                            objFornecedores.CNPJ = objDataReader["CNPJ"].ToString();
                            objFornecedores.Rua = objDataReader["Rua"].ToString();
                            objFornecedores.Bairro = objDataReader["Bairro"].ToString();
                            objFornecedores.Cidade = objDataReader["Cidade"].ToString();
                            objFornecedores.CEP = objDataReader["CEP"].ToString();
                            lstFornecedores.Add(objFornecedores);
                        }

                        objCon.Close();

                    }


                    objCon.Close();
                }
                return lstFornecedores;
            }
        }


        public List<Fornecedores> Pesquisar(String Nome, String CNPJ, String Rua, String Bairro, String Cidade, String CEP)
        {
            string strPesquisa = "SELECT Nome , CNPJ , Rua, Bairro, Cidade, CEP FROM tb_Fornecedor WHERE 1=1 ";
            List<Fornecedores> lstFornecedores = new List<Fornecedores>();
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                if (Nome != "")
                {
                    strPesquisa += " AND Nome LIKE @Nome ";
                }
                if (CNPJ != "")
                {
                    strPesquisa += " AND CNPJ LIKE @CNPJ ";
                }
                if (Rua != "")
                {
                    strPesquisa += " AND Rua LIKE @Rua ";
                }
                if (Bairro != "")
                {
                    strPesquisa += " AND Bairro LIKE @Bairro ";
                }
                if (Cidade != "")
                {
                    strPesquisa += " AND Cidade LIKE @Cidade ";
                }
                if (CEP != "")
                {
                    strPesquisa += " AND CEP LIKE @CEP ";
                }
                using (SqlCommand objCmd = new SqlCommand(strPesquisa, objCon))
                {
                    if (Nome != "")
                    {
                        objCmd.Parameters.AddWithValue("@Nome", "%" + Nome + "%");
                    }
                    if (CNPJ != "")
                    {
                        objCmd.Parameters.AddWithValue("@CNPJ", "%" + CNPJ + "%");
                    }
                    if (Rua != "")
                    {
                        objCmd.Parameters.AddWithValue("@Rua", "%" + Rua + "%");
                    }
                    if (Bairro != "")
                    {
                        objCmd.Parameters.AddWithValue("@Bairro", "%" + Bairro + "%");
                    }
                    if (Cidade != "")
                    {
                        objCmd.Parameters.AddWithValue("@Cidade", "%" + Cidade + "%");
                    }
                    if (CEP != "")
                    {
                        objCmd.Parameters.AddWithValue("@CEP", "%" + CEP + "%");
                    }



                    objCon.Open();

                    SqlDataReader objDataReader = objCmd.ExecuteReader();
                    if (objDataReader.HasRows)
                    {

                        while (objDataReader.Read())
                        {
                            Fornecedores objFornecedores = new Fornecedores();
                            objFornecedores.Nome = objDataReader["Nome"].ToString();
                            objFornecedores.CNPJ = objDataReader["CNPJ"].ToString();
                            objFornecedores.Rua = objDataReader["Rua"].ToString();
                            objFornecedores.Bairro = objDataReader["Bairro"].ToString();
                            objFornecedores.Cidade = objDataReader["Cidade"].ToString();
                            objFornecedores.CEP = objDataReader["CEP"].ToString();
                            lstFornecedores.Add(objFornecedores);
                        }

                        objCon.Close();

                    }


                    objCon.Close();
                }
                return lstFornecedores;
            }

        }



    }
}


