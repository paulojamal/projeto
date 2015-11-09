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
    public class ADM_BD_Cliente
    {

        static String mp = Environment.CurrentDirectory;

        private static string _strCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + mp + "\\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";

        public const String strInserir = "INSERT INTO tb_Cliente(NomeUser, SenhaUser, Name, Sobrenome, ID, Telefone, Rua, Numero, Bairro, Cidade, Estado) VALUES(@NomeUser, @SenhaUser, @Name, @Sobrenome, @ID, @Telefone, @Rua, @Numero, @Bairro, @Cidade, @Estado)";
        public const String strExcluir = "DELETE FROM tb_Cliente WHERE NomeUser = @NomeUser";
        //public const String strAlterar = "UPDATE tb_Cliente SET SenhaUser = @SenhaUser , Name = @Name ,  Sobrenome = @Sobrenome , ID = @ID  , Telefone = @Telefone , Rua = @Rua , Numero = @Numero , Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado  WHERE NomeUser = @NomeUser";
        public const String strSelecionar = "SELECT COUNT(*) FROM tb_Cliente WHERE NomeUser = @NomeUser AND SenhaUser =@SenhaUser";
        public const string strConsultar = "SELECT NomeUser , SenhaUser , Name, Sobrenome, ID, Telefone, Rua, Numero, Bairro, Cidade, Estado FROM tb_Cliente";

        public void Inserir(String Login, String Senha, String Nome, String Sobrenome, String Identidade, String Telefone, String Rua, String N, String Bairro, String Cidade, String Estado)
        {
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strInserir, objCon))
                {
                    objCmd.Parameters.AddWithValue("@NomeUser", Login);
                    objCmd.Parameters.AddWithValue("@SenhaUser", Senha);
                    objCmd.Parameters.AddWithValue("@Name", Nome);
                    objCmd.Parameters.AddWithValue("@Sobrenome", Sobrenome);
                    objCmd.Parameters.AddWithValue("@ID", Identidade);
                    objCmd.Parameters.AddWithValue("@Telefone", Telefone);
                    objCmd.Parameters.AddWithValue("@Rua", Rua);
                    objCmd.Parameters.AddWithValue("@Numero", N);
                    objCmd.Parameters.AddWithValue("@Bairro", Bairro);
                    objCmd.Parameters.AddWithValue("@Cidade", Cidade);
                    objCmd.Parameters.AddWithValue("@Estado", Estado);
                    objCon.Open();
                    objCmd.ExecuteNonQuery();
                    objCon.Close();
                }

            }

        }

        public void Atualizar(String Login, String Senha, String Name, String Sobrenome, String Identidade, String Telefone, String Rua, String N, String Bairro, String Cidade, String Estado)
        {
            String strAlterar = "UPDATE tb_Cliente SET NomeUser = @NomeUser ";

            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                if (Senha != "")
                {
                    strAlterar += " , SenhaUser = @SenhaUser ";
                }
                if (Name != "")
                {
                    strAlterar += " , Name = @Name ";
                }
                if (Sobrenome != "")
                {
                    strAlterar += " , SobreNome = @SobreNome ";
                }
                if (Telefone != "")
                {
                    strAlterar += " , Telefone = @Telefone ";
                }
                if (Rua != "")
                {
                    strAlterar += " , Rua = @Rua ";
                }
                if (strAlterar != "")
                {
                    strAlterar += " , Numero = @Numero ";
                }
                if (Bairro != "")
                {
                    strAlterar += " , Bairro = @Bairro ";
                }
                if (Cidade != "")
                {
                    strAlterar += " , Cidade = @Cidade ";
                }
                if (Estado != "")
                {
                    strAlterar += " , Estado = @Estado ";
                }

                strAlterar += "WHERE NomeUser = @NomeUser";

                using (SqlCommand objCmd = new SqlCommand(strAlterar, objCon))
                {
                    if (Login != "")
                    {
                        objCmd.Parameters.AddWithValue("@NomeUser", Login);
                    }
                    if (Senha != "")
                    {
                        objCmd.Parameters.AddWithValue("@SenhaUser", Senha);
                    }
                    if (Name != "")
                    {
                        objCmd.Parameters.AddWithValue("@Name", Name);
                    }
                    if (Sobrenome != "")
                    {
                        objCmd.Parameters.AddWithValue("@SobreNome", Sobrenome);
                    }
                    if (Telefone != "")
                    {
                        objCmd.Parameters.AddWithValue("@Telefone", Telefone);
                    }
                    if (Rua != "")
                    {
                        objCmd.Parameters.AddWithValue("@Rua", Rua);
                    }
                    if (N != "")
                    {
                        objCmd.Parameters.AddWithValue("@Numero", N);
                    }
                    if (Bairro != "")
                    {
                        objCmd.Parameters.AddWithValue("@Bairro", Bairro);
                    }
                    if (Cidade != "")
                    {
                        objCmd.Parameters.AddWithValue("@Cidade", Cidade);
                    }
                    if (Estado != "")
                    {
                        objCmd.Parameters.AddWithValue("@Estado", Estado);
                    }

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

        public class Clientes
        {
            public String NomeUser { get; set; }
            public String SenhaUser { get; set; }
            public String Name { get; set; }
            public String Sobrenome { get; set; }
            public String ID { get; set; }
            public String Telefone { get; set; }
            public String Rua { get; set; }
            public String Numero { get; set; }
            public String Bairro { get; set; }
            public String Cidade { get; set; }
            public String Estado { get; set; }



        }
        public List<Clientes> Consultar()
        {
            List<Clientes> lstClientes = new List<Clientes>();
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
                            Clientes objClientes = new Clientes();
                            objClientes.NomeUser = objDataReader["NomeUser"].ToString();
                            objClientes.SenhaUser = objDataReader["SenhaUser"].ToString();
                            objClientes.Name = objDataReader["Name"].ToString();
                            objClientes.Sobrenome = objDataReader["Sobrenome"].ToString();
                            objClientes.ID = objDataReader["ID"].ToString();
                            objClientes.Telefone = objDataReader["Telefone"].ToString();
                            objClientes.Rua = objDataReader["Rua"].ToString();
                            objClientes.Numero = objDataReader["Numero"].ToString();
                            objClientes.Bairro = objDataReader["Bairro"].ToString();
                            objClientes.Cidade = objDataReader["Cidade"].ToString();
                            objClientes.Estado = objDataReader["Estado"].ToString();
                            lstClientes.Add(objClientes);
                        }

                        objCon.Close();

                    }


                    objCon.Close();
                }
                return lstClientes;
            }
        }

        public List<Clientes> Pesquisar(String Login, String Senha, String Name, String Sobrenome, String ID, String Telefone, String Rua, String Numero, String Bairro, String Cidade, String Estado)
        {
            string strPesquisa = "SELECT NomeUser , SenhaUser , Name, Sobrenome, ID, Telefone, Rua, Numero, Bairro, Cidade, Estado FROM tb_Cliente WHERE 1=1 ";
            List<Clientes> lstClientes = new List<Clientes>();
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                if (Login != "")
                {
                    strPesquisa += " AND NomeUser LIKE @NomeUser ";
                }
                if (Senha != "")
                {
                    strPesquisa += " AND SenhaUser LIKE @SenhaUser ";
                }
                if (Name != "")
                {
                    strPesquisa += " AND Name LIKE @Name ";
                }
                if (Sobrenome != "")
                {
                    strPesquisa += " AND Sobrenome LIKE @Sobrenome ";
                }
                if (ID != "")
                {
                    strPesquisa += " AND ID LIKE @ID ";
                }
                if (Telefone != "")
                {
                    strPesquisa += " AND Telefone LIKE @Telefone ";
                }
                if (Rua != "")
                {
                    strPesquisa += " AND Rua LIKE @Rua ";
                }
                if (Numero != "")
                {
                    strPesquisa += " AND Numero LIKE @Numero ";
                }
                if (Bairro != "")
                {
                    strPesquisa += " AND Bairro LIKE @Bairro ";
                }
                if (Cidade != "")
                {
                    strPesquisa += " AND Cidade LIKE @Cidade ";
                }
                if (Estado != "")
                {
                    strPesquisa += " AND Estado LIKE @Estado ";
                }
                using (SqlCommand objCmd = new SqlCommand(strPesquisa, objCon))
                {
                    if (Login != "")
                    {
                        objCmd.Parameters.AddWithValue("@NomeUser", "%" + Login + "%");
                    }
                    if (Senha != "")
                    {
                        objCmd.Parameters.AddWithValue("@SenhaUser", "%" + Senha + "%");
                    }
                    if (Name != "")
                    {
                        objCmd.Parameters.AddWithValue("@Name", "%" + Name + "%");
                    }
                    if (Sobrenome != "")
                    {
                        objCmd.Parameters.AddWithValue("@Sobrenome", "%" + Sobrenome + "%");
                    }
                    if (ID != "")
                    {
                        objCmd.Parameters.AddWithValue("@ID", "%" + ID + "%");
                    }
                    if (Telefone != "")
                    {
                        objCmd.Parameters.AddWithValue("@Telefone", "%" + Telefone + "%");
                    }
                    if (Rua != "")
                    {
                        objCmd.Parameters.AddWithValue("@Rua", "%" + Rua + "%");
                    }
                    if (Numero != "")
                    {
                        objCmd.Parameters.AddWithValue("@Numero", "%" + Numero + "%");
                    }
                    if (Bairro != "")
                    {
                        objCmd.Parameters.AddWithValue("@Bairro", "%" + Bairro + "%");
                    }
                    if (Cidade != "")
                    {
                        objCmd.Parameters.AddWithValue("@Cidade", "%" + Cidade + "%");
                    }
                    if (Estado != "")
                    {
                        objCmd.Parameters.AddWithValue("@Estado", "%" + Estado + "%");
                    }


                    objCon.Open();

                    SqlDataReader objDataReader = objCmd.ExecuteReader();
                    if (objDataReader.HasRows)
                    {

                        while (objDataReader.Read())
                        {
                            Clientes objClientes = new Clientes();
                            objClientes.NomeUser = objDataReader["NomeUser"].ToString();
                            objClientes.SenhaUser = objDataReader["SenhaUser"].ToString();
                            objClientes.Name = objDataReader["Name"].ToString();
                            objClientes.Sobrenome = objDataReader["Sobrenome"].ToString();
                            objClientes.ID = objDataReader["ID"].ToString();
                            objClientes.Telefone = objDataReader["Telefone"].ToString();
                            objClientes.Rua = objDataReader["Rua"].ToString();
                            objClientes.Numero = objDataReader["Numero"].ToString();
                            objClientes.Bairro = objDataReader["Bairro"].ToString();
                            objClientes.Cidade = objDataReader["Cidade"].ToString();
                            objClientes.Estado = objDataReader["Estado"].ToString();
                            lstClientes.Add(objClientes);
                        }

                        objCon.Close();

                    }


                    objCon.Close();
                }
                return lstClientes;
            }

        }

    }
}



