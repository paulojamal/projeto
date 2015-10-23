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
        //private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme\Desktop\projeto\projeto\SistemaDemanutencao\SistemaDeLogin\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
        //private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mp + "\\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";

       // private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Filipe\Desktop\testeBD\testeBD\testeBD\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
        private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme\Desktop\projeto\projeto\SistemaDemanutencao\SistemaDeLogin\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
        public const String strInserir = "INSERT INTO tb_Cliente(NomeUser, SenhaUser) VALUES(@NomeUser, @SenhaUser)";
        public const String strExcluir = "DELETE FROM tb_Cliente WHERE NomeUser = @NomeUser";
        public const String strAlterar = "UPDATE tb_Cliente SET SenhaUser = @SenhaUser WHERE NomeUser = @NomeUser";
        public const String strSelecionar = "SELECT COUNT(*) FROM tb_Cliente WHERE NomeUser = @NomeUser AND SenhaUser =@SenhaUser";

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
            catch (SqlException sqlerr)
            {
                throw sqlerr;
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
