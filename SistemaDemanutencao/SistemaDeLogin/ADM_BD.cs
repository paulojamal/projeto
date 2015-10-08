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
    class ADM_BD
    {
        static String mp = Environment.CurrentDirectory;
        //private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Guilherme\Desktop\projeto\SistemaDemanutencao\SistemaDeLogin\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
        private static string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mp + "\\BD_Usuario.mdf;Integrated Security=True;Connect Timeout=30";
        private string vsql = "";
        SqlConnection objCon = null;

        private bool conectar() {
            objCon = new SqlConnection(_strCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch {
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
            else {
                objCon.Dispose();
                return false;
            }
        }

        public bool Logou(ArrayList p_arrVerificar)
        {

            vsql = "SELECT COUNT(*) FROM tb_Usuarios WHERE NomeUser = @user AND SenhaUser =@senha";
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
                    else {

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

        public bool Insert(ArrayList p_arrInsert) {
            if (this.conectar())
            {
                vsql="INSERT INTO tb_Usuarios(NomeUser, SenhaUser) VALUES(@NomeUser,@SenhaUser)";
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

            else {
                return false;
            }
        }

        public bool Update(ArrayList p_arrUpdate)
        {
            if (this.conectar())
            {
                vsql = "UPDATE INTO tb_Usuarios(NomeUser, SenhaUser) VALUES(@NomeUser,@SenhaUser) WHERE NomeUser = @NomeUser";
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

        //public bool Delete()
        //{

        //}

        //public DataTable ListaGrid() {


        //}
        //public DataTable Pesquisar()
        //{


        //}
    }
}
