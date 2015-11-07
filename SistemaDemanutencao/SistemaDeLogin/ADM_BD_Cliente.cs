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
        public const String strAlterar = "UPDATE tb_Cliente SET SenhaUser = @SenhaUser , Name = @Name ,  Sobrenome = @Sobrenome , ID = @ID  , Telefone = @Telefone , Rua = @Rua , Numero = @Numero , Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado  WHERE NomeUser = @NomeUser";
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

        public void Atualizar(String Login, String Senha, String Nome, String Sobrenome, String Identidade, String Telefone, String Rua, String N, String Bairro, String Cidade, String Estado)
        {

            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strAlterar, objCon))
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
        /*public DataTable Listar()
        {

            /*using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                using (SqlCommand objCmd = new SqlCommand(strSelecionar, objCon)) //testar objCon, strSelecionar 
                {


                    SqlDataAdapter adp = new SqlDataAdapter(objCmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;

                }

            }
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
            catch (SqlException sqlerr)
            {
                throw sqlerr;
            }
        }*/
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
            List<Clientes> lstUsuarios = new List<Clientes>();
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
                            Clientes objUsuarios = new Clientes();
                            objUsuarios.NomeUser = objDataReader["NomeUser"].ToString();
                            objUsuarios.SenhaUser = objDataReader["SenhaUser"].ToString();
                            objUsuarios.Name = objDataReader["Name"].ToString();
                            objUsuarios.Sobrenome = objDataReader["Sobrenome"].ToString();
                            objUsuarios.ID = objDataReader["ID"].ToString();
                            objUsuarios.Telefone = objDataReader["Telefone"].ToString();
                            objUsuarios.Rua = objDataReader["Rua"].ToString();
                            objUsuarios.Numero = objDataReader["Numero"].ToString();
                            objUsuarios.Bairro = objDataReader["Bairro"].ToString();
                            objUsuarios.Cidade = objDataReader["Cidade"].ToString();
                            objUsuarios.Estado = objDataReader["Estado"].ToString();
                            lstUsuarios.Add(objUsuarios);
                        }

                        objCon.Close();

                    }


                    objCon.Close();
                }
                return lstUsuarios;
            }
        }
        
        public List<Clientes> Pesquisar(String Login, String Senha, String Name, String Sobrenome, String ID, String Telefone, String Rua, String Numero, String Bairro, String Cidade, String Estado)
        {
            string strPesquisa = "SELECT NomeUser , SenhaUser , Name, Sobrenome, ID, Telefone, Rua, Numero, Bairro, Cidade, Estado FROM tb_Cliente WHERE 1=1 ";
            List<Clientes> lstClientes = new List<Clientes>();
            using (SqlConnection objCon = new SqlConnection(_strCon))
            {
                if (Login != "") {
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


//backup da versão passada, não remova
/*namespace SistemaDeLogin
{
    class ADM_BD_Cliente
    {
        private string vsql = "";
        SqlConnection objCon = null;

        private bool conectar()
        {
            objCon = new SqlConnection(_strCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch
            {
                return false;

            }
        }

        private bool desconectar()
        {
            if (objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                objCon.Dispose();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;
            }
        }

        public bool Logou(ArrayList p_arrVerificar)
        {

            vsql = "SELECT COUNT(*) FROM tb_Cliente WHERE NomeUser = @user AND SenhaUser =@senha";
            SqlCommand objcmd = null;
            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add("@user", SqlDbType.VarChar).Value = p_arrVerificar[0];
                    objcmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = p_arrVerificar[1];


                    int i = (int)objcmd.ExecuteScalar();

                    if (i > 0)
                    {
                        return true;
                    }
                    else
                    {

                        return false;
                    }


                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }

        public bool Insert(ArrayList p_arrInsert)
        {
            if (this.conectar())
            {
                vsql = "INSERT INTO tb_Cliente(NomeUser, SenhaUser) VALUES(@NomeUser,@SenhaUser)";
                SqlCommand objcmd = null;

                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@NomeUser", p_arrInsert[0]));
                    objcmd.Parameters.Add(new SqlParameter("@SenhaUser", p_arrInsert[1]));
                    objcmd.ExecuteNonQuery();


                    return true;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }

            else
            {
                return false;
            }
        }

        public bool Update(ArrayList p_arrUpdate)
        {
            if (this.conectar())
            {
                //                vsql = "UPDATE INTO tb_Cliente(NomeUser, SenhaUser) VALUES(@NomeUser,@SenhaUser) WHERE NomeUser = @NomeUser";
                vsql = "UPDATE tb_Cliente SET NomeUser = @NomeUser, SenhaUser = @SenhaUser WHERE NomeUser = @NomeUser";
                SqlCommand objcmd = null;

                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@NomeUser", p_arrUpdate[0]));
                    objcmd.Parameters.Add(new SqlParameter("@SenhaUser", p_arrUpdate[1]));
                    objcmd.ExecuteNonQuery();


                    return true;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }

            else
            {
                return false;
            }
        }

        public bool Delete(ArrayList nome_deletado)
        {
            if (this.conectar())
            {
                vsql = "DELETE FROM tb_Cliente WHERE NomeUser = @NomeUser";
                SqlCommand objcmd = null;

                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@NomeUser", nome_deletado);
                    objcmd.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }

            else
            {
                return false;
            }
        }

        public DataTable ListaGrid()
        {

            if (this.conectar())
            {
                vsql = "SELECT INTO tb_Cliente(NomeUser, SenhaUser) VALUES(@NomeUser,@SenhaUser)";
                SqlCommand objcmd = null;

                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }

            else
            {
                return null;
            }
        }
    }
}
*/
