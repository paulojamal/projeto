﻿using System;
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
        //private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme\Desktop\projeto\projeto\SistemaDemanutencao\SistemaDeLogin\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
        //private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mp + "\\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
        //private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme\Desktop\projeto\projeto\SistemaDemanutencao\SistemaDeLogin\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
        //String Filipe
        //private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Filipe\Desktop\Sistema de Manutencao\projeto\SistemaDemanutencao\SistemaDeLogin\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
        //String Guilherme
        private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme\Desktop\projeto\projeto\SistemaDemanutencao\SistemaDeLogin\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
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
            List<Fornecedores> lstUsuarios = new List<Fornecedores>();
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
                            Fornecedores objUsuarios = new Fornecedores();
                            objUsuarios.Nome = objDataReader["Nome"].ToString();
                            objUsuarios.CNPJ = objDataReader["CNPJ"].ToString();
                            objUsuarios.Rua = objDataReader["Rua"].ToString();
                            objUsuarios.Bairro = objDataReader["Bairro"].ToString();
                            objUsuarios.Cidade = objDataReader["Cidade"].ToString();
                            objUsuarios.CEP = objDataReader["CEP"].ToString();
                            lstUsuarios.Add(objUsuarios);
                        }

                        objCon.Close();

                    }


                    objCon.Close();
                }
                return lstUsuarios;
            }
        }
            /*
            public DataTable Listar()
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
            }

    */

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

            vsql = "SELECT COUNT(*) FROM tb_Fornecedor WHERE NomeUser = @user AND SenhaUser =@senha";
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
                vsql = "INSERT INTO tb_Fornecedor(NomeUser, SenhaUser) VALUES(@NomeUser,@SenhaUser)";
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
                //                vsql = "UPDATE INTO tb_Fornecedor(NomeUser, SenhaUser) VALUES(@NomeUser,@SenhaUser) WHERE NomeUser = @NomeUser";
                vsql = "UPDATE tb_Fornecedor SET NomeUser = @NomeUser, SenhaUser = @SenhaUser WHERE NomeUser = @NomeUser";
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
                vsql = "DELETE FROM tb_Fornecedor WHERE NomeUser = @NomeUser";
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
                vsql = "SELECT INTO tb_Fornecedor(NomeUser, SenhaUser) VALUES(@NomeUser,@SenhaUser)";
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
